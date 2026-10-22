using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using MotorbikeApp.FolderforModel;

namespace MotorbikeApp
{
    public partial class MainForm : Form
    {
        // экземпляр модели EF (класс контекста)
        private ModelDB db = new ModelDB();

        // список записей (после фильтрации) и номер первой показанной плитки
        private List<Table_Motorbike> motorbikes = new List<Table_Motorbike>();
        private int number = 0;

        private const int CardsOnPage = 2;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                // бренды для фильтра
                var brands = db.Table_Motorbike.Select(m => m.Brand).Distinct().OrderBy(b => b).ToList();
                comboBrand.Items.Add("Все");
                comboBrand.Items.AddRange(brands.ToArray());
                comboBrand.SelectedIndex = 0;

                ApplyFilter();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось подключиться к БД MotorbikeDB:\n" + ex.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------- заполнение плиток ----------

        private void LoadData()
        {
            motorbikeCard1.SetData(number < motorbikes.Count ? motorbikes[number] : null);
            motorbikeCard2.SetData(number + 1 < motorbikes.Count ? motorbikes[number + 1] : null);

            int pages = Math.Max(1, (motorbikes.Count + CardsOnPage - 1) / CardsOnPage);
            labelPage.Text = motorbikes.Count == 0
                ? "Ничего не найдено"
                : $"Страница {number / CardsOnPage + 1} из {pages}  (найдено: {motorbikes.Count})";

            buttonPrev.Enabled = number > 0;
            buttonNext.Enabled = number + CardsOnPage < motorbikes.Count;
        }

        // перегрузка: true - вперед, false - назад
        private void LoadData(bool next)
        {
            if (next && number + CardsOnPage < motorbikes.Count)
                number += CardsOnPage;
            else if (!next && number - CardsOnPage >= 0)
                number -= CardsOnPage;

            LoadData();
        }

        private void buttonNext_Click(object sender, EventArgs e) { LoadData(true); }

        private void buttonPrev_Click(object sender, EventArgs e) { LoadData(false); }

        // ---------- фильтрация (дополнительное задание) ----------

        private static double? ParseNumber(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return null;
            text = text.Trim().Replace(',', '.');
            double v;
            return double.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out v) ? (double?)v : null;
        }

        private void ApplyFilter()
        {
            IQueryable<Table_Motorbike> q = db.Table_Motorbike;

            if (comboBrand.SelectedIndex > 0)
            {
                string brand = comboBrand.SelectedItem.ToString();
                q = q.Where(m => m.Brand == brand);
            }

            string model = textModel.Text.Trim();
            if (model.Length > 0)
                q = q.Where(m => m.Model.Contains(model));

            double? priceFrom = ParseNumber(textPriceFrom.Text), priceTo = ParseNumber(textPriceTo.Text);
            double? hpFrom = ParseNumber(textHpFrom.Text), hpTo = ParseNumber(textHpTo.Text);
            double? mileFrom = ParseNumber(textMileFrom.Text), mileTo = ParseNumber(textMileTo.Text);

            if (priceFrom.HasValue) q = q.Where(m => m.Price >= priceFrom.Value);
            if (priceTo.HasValue)   q = q.Where(m => m.Price <= priceTo.Value);
            if (hpFrom.HasValue)    q = q.Where(m => m.Horsepower >= hpFrom.Value);
            if (hpTo.HasValue)      q = q.Where(m => m.Horsepower <= hpTo.Value);
            if (mileFrom.HasValue)  q = q.Where(m => m.Mileage >= mileFrom.Value);
            if (mileTo.HasValue)    q = q.Where(m => m.Mileage <= mileTo.Value);

            motorbikes = q.OrderBy(m => m.ID).ToList();
            number = 0;
            LoadData();
        }

        private void buttonApply_Click(object sender, EventArgs e) { ApplyFilter(); }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            comboBrand.SelectedIndex = 0;
            foreach (var tb in new[] { textModel, textPriceFrom, textPriceTo, textHpFrom, textHpTo, textMileFrom, textMileTo })
                tb.Clear();
            ApplyFilter();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            db.Dispose();
            base.OnFormClosed(e);
        }
    }
}

using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MotorbikeApp.FolderforModel;

namespace MotorbikeApp
{
    /// <summary>Плитка (UserControl) для показа одной записи Table_Motorbike.</summary>
    public partial class MotorbikeCard : UserControl
    {
        public MotorbikeCard()
        {
            InitializeComponent();
        }

        /// <summary>Заполняет плитку данными мотоцикла. null - плитка очищается.</summary>
        public void SetData(Table_Motorbike m)
        {
            if (m == null)
            {
                Visible = false;
                return;
            }

            Visible = true;
            labelIDData.Text = m.ID.ToString();
            labelBrandData.Text = m.Brand;
            labelModelData.Text = m.Model;
            labelPriceData.Text = m.Price.HasValue ? m.Price.Value.ToString("N0") + " ₽" : "—";
            labelHorsepowerData.Text = m.Horsepower.HasValue ? m.Horsepower.Value + " л.с." : "—";
            labelMileageData.Text = m.Mileage.HasValue ? m.Mileage.Value.ToString("N0") + " км" : "—";

            // Картинки лежат в папке Pictures рядом с exe (bin\Debug\Pictures)
            string path = Path.Combine(Application.StartupPath, "Pictures", m.Picture ?? "");
            if (pictureBox.Image != null)
            {
                pictureBox.Image.Dispose();
                pictureBox.Image = null;
            }
            if (File.Exists(path))
            {
                // читаем через поток, чтобы файл не блокировался
                using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                using (var img = Image.FromStream(fs))
                {
                    pictureBox.Image = new Bitmap(img);
                }
            }
        }
    }
}

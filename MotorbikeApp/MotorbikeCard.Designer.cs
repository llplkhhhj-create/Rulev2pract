namespace MotorbikeApp
{
    partial class MotorbikeCard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelIDCaption = new System.Windows.Forms.Label();
            this.labelIDData = new System.Windows.Forms.Label();
            this.labelBrandCaption = new System.Windows.Forms.Label();
            this.labelBrandData = new System.Windows.Forms.Label();
            this.labelModelCaption = new System.Windows.Forms.Label();
            this.labelModelData = new System.Windows.Forms.Label();
            this.labelPriceCaption = new System.Windows.Forms.Label();
            this.labelPriceData = new System.Windows.Forms.Label();
            this.labelHorsepowerCaption = new System.Windows.Forms.Label();
            this.labelHorsepowerData = new System.Windows.Forms.Label();
            this.labelMileageCaption = new System.Windows.Forms.Label();
            this.labelMileageData = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            this.pictureBox.Location = new System.Drawing.Point(10, 5);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(360, 225);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabStop = false;
            this.labelIDCaption.AutoSize = true;
            this.labelIDCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelIDCaption.Location = new System.Drawing.Point(15, 240);
            this.labelIDCaption.Name = "labelIDCaption";
            this.labelIDCaption.Text = "ID";
            this.labelIDData.AutoSize = true;
            this.labelIDData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.labelIDData.Location = new System.Drawing.Point(140, 240);
            this.labelIDData.Name = "labelIDData";
            this.labelIDData.Text = "";
            this.labelBrandCaption.AutoSize = true;
            this.labelBrandCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelBrandCaption.Location = new System.Drawing.Point(15, 268);
            this.labelBrandCaption.Name = "labelBrandCaption";
            this.labelBrandCaption.Text = "Бренд";
            this.labelBrandData.AutoSize = true;
            this.labelBrandData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.labelBrandData.Location = new System.Drawing.Point(140, 268);
            this.labelBrandData.Name = "labelBrandData";
            this.labelBrandData.Text = "";
            this.labelModelCaption.AutoSize = true;
            this.labelModelCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelModelCaption.Location = new System.Drawing.Point(15, 296);
            this.labelModelCaption.Name = "labelModelCaption";
            this.labelModelCaption.Text = "Модель";
            this.labelModelData.AutoSize = true;
            this.labelModelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.labelModelData.Location = new System.Drawing.Point(140, 296);
            this.labelModelData.Name = "labelModelData";
            this.labelModelData.Text = "";
            this.labelPriceCaption.AutoSize = true;
            this.labelPriceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelPriceCaption.Location = new System.Drawing.Point(15, 324);
            this.labelPriceCaption.Name = "labelPriceCaption";
            this.labelPriceCaption.Text = "Цена";
            this.labelPriceData.AutoSize = true;
            this.labelPriceData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.labelPriceData.Location = new System.Drawing.Point(140, 324);
            this.labelPriceData.Name = "labelPriceData";
            this.labelPriceData.Text = "";
            this.labelHorsepowerCaption.AutoSize = true;
            this.labelHorsepowerCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelHorsepowerCaption.Location = new System.Drawing.Point(15, 352);
            this.labelHorsepowerCaption.Name = "labelHorsepowerCaption";
            this.labelHorsepowerCaption.Text = "Мощность";
            this.labelHorsepowerData.AutoSize = true;
            this.labelHorsepowerData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.labelHorsepowerData.Location = new System.Drawing.Point(140, 352);
            this.labelHorsepowerData.Name = "labelHorsepowerData";
            this.labelHorsepowerData.Text = "";
            this.labelMileageCaption.AutoSize = true;
            this.labelMileageCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelMileageCaption.Location = new System.Drawing.Point(15, 380);
            this.labelMileageCaption.Name = "labelMileageCaption";
            this.labelMileageCaption.Text = "Пробег";
            this.labelMileageData.AutoSize = true;
            this.labelMileageData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.labelMileageData.Location = new System.Drawing.Point(140, 380);
            this.labelMileageData.Name = "labelMileageData";
            this.labelMileageData.Text = "";
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.labelIDCaption);
            this.Controls.Add(this.labelIDData);
            this.Controls.Add(this.labelBrandCaption);
            this.Controls.Add(this.labelBrandData);
            this.Controls.Add(this.labelModelCaption);
            this.Controls.Add(this.labelModelData);
            this.Controls.Add(this.labelPriceCaption);
            this.Controls.Add(this.labelPriceData);
            this.Controls.Add(this.labelHorsepowerCaption);
            this.Controls.Add(this.labelHorsepowerData);
            this.Controls.Add(this.labelMileageCaption);
            this.Controls.Add(this.labelMileageData);
            this.Name = "MotorbikeCard";
            this.Size = new System.Drawing.Size(380, 420);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelIDCaption;
        private System.Windows.Forms.Label labelIDData;
        private System.Windows.Forms.Label labelBrandCaption;
        private System.Windows.Forms.Label labelBrandData;
        private System.Windows.Forms.Label labelModelCaption;
        private System.Windows.Forms.Label labelModelData;
        private System.Windows.Forms.Label labelPriceCaption;
        private System.Windows.Forms.Label labelPriceData;
        private System.Windows.Forms.Label labelHorsepowerCaption;
        private System.Windows.Forms.Label labelHorsepowerData;
        private System.Windows.Forms.Label labelMileageCaption;
        private System.Windows.Forms.Label labelMileageData;
    }
}


namespace Pogoda2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LCityAndCountry = new System.Windows.Forms.Label();
            this.Ltemp = new System.Windows.Forms.Label();
            this.LPressureAndHumidity = new System.Windows.Forms.Label();
            this.LSunrise = new System.Windows.Forms.Label();
            this.LSunset = new System.Windows.Forms.Label();
            this.LDateTime = new System.Windows.Forms.Label();
            this.LSpeedVis = new System.Windows.Forms.Label();
            this.LDescription = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LCityAndCountry
            // 
            this.LCityAndCountry.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LCityAndCountry.AutoSize = true;
            this.LCityAndCountry.BackColor = System.Drawing.Color.Transparent;
            this.LCityAndCountry.Font = new System.Drawing.Font("Impact", 20.25F);
            this.LCityAndCountry.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LCityAndCountry.Location = new System.Drawing.Point(426, 50);
            this.LCityAndCountry.Name = "LCityAndCountry";
            this.LCityAndCountry.Size = new System.Drawing.Size(191, 34);
            this.LCityAndCountry.TabIndex = 2;
            this.LCityAndCountry.Text = "Город и страна";
            // 
            // Ltemp
            // 
            this.Ltemp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ltemp.AutoSize = true;
            this.Ltemp.BackColor = System.Drawing.Color.Transparent;
            this.Ltemp.Font = new System.Drawing.Font("Impact", 20.25F);
            this.Ltemp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Ltemp.Location = new System.Drawing.Point(450, 84);
            this.Ltemp.Name = "Ltemp";
            this.Ltemp.Size = new System.Drawing.Size(167, 34);
            this.Ltemp.TabIndex = 4;
            this.Ltemp.Text = "Температура";
            this.Ltemp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LPressureAndHumidity
            // 
            this.LPressureAndHumidity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LPressureAndHumidity.AutoSize = true;
            this.LPressureAndHumidity.BackColor = System.Drawing.Color.Transparent;
            this.LPressureAndHumidity.Font = new System.Drawing.Font("Impact", 20.25F);
            this.LPressureAndHumidity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LPressureAndHumidity.Location = new System.Drawing.Point(257, 403);
            this.LPressureAndHumidity.Name = "LPressureAndHumidity";
            this.LPressureAndHumidity.Size = new System.Drawing.Size(288, 34);
            this.LPressureAndHumidity.TabIndex = 5;
            this.LPressureAndHumidity.Text = "Давление и влажность";
            // 
            // LSunrise
            // 
            this.LSunrise.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LSunrise.AutoSize = true;
            this.LSunrise.BackColor = System.Drawing.Color.Transparent;
            this.LSunrise.Font = new System.Drawing.Font("Impact", 20.25F);
            this.LSunrise.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LSunrise.Location = new System.Drawing.Point(426, 471);
            this.LSunrise.Name = "LSunrise";
            this.LSunrise.Size = new System.Drawing.Size(99, 34);
            this.LSunrise.TabIndex = 6;
            this.LSunrise.Text = "Восход";
            // 
            // LSunset
            // 
            this.LSunset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LSunset.AutoSize = true;
            this.LSunset.BackColor = System.Drawing.Color.Transparent;
            this.LSunset.Font = new System.Drawing.Font("Impact", 20.25F);
            this.LSunset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LSunset.Location = new System.Drawing.Point(426, 505);
            this.LSunset.Name = "LSunset";
            this.LSunset.Size = new System.Drawing.Size(83, 34);
            this.LSunset.TabIndex = 7;
            this.LSunset.Text = "Закат";
            // 
            // LDateTime
            // 
            this.LDateTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LDateTime.AutoSize = true;
            this.LDateTime.BackColor = System.Drawing.Color.Transparent;
            this.LDateTime.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDateTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LDateTime.Location = new System.Drawing.Point(411, 16);
            this.LDateTime.Name = "LDateTime";
            this.LDateTime.Size = new System.Drawing.Size(172, 34);
            this.LDateTime.TabIndex = 8;
            this.LDateTime.Text = "Дата и время";
            // 
            // LSpeedVis
            // 
            this.LSpeedVis.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LSpeedVis.AutoSize = true;
            this.LSpeedVis.BackColor = System.Drawing.Color.Transparent;
            this.LSpeedVis.Font = new System.Drawing.Font("Impact", 20.25F);
            this.LSpeedVis.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LSpeedVis.Location = new System.Drawing.Point(170, 437);
            this.LSpeedVis.Name = "LSpeedVis";
            this.LSpeedVis.Size = new System.Drawing.Size(241, 34);
            this.LSpeedVis.TabIndex = 9;
            this.LSpeedVis.Text = "Ветер и видимость";
            // 
            // LDescription
            // 
            this.LDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LDescription.AutoSize = true;
            this.LDescription.BackColor = System.Drawing.Color.Transparent;
            this.LDescription.Font = new System.Drawing.Font("Impact", 20.25F);
            this.LDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LDescription.Location = new System.Drawing.Point(467, 118);
            this.LDescription.Name = "LDescription";
            this.LDescription.Size = new System.Drawing.Size(129, 34);
            this.LDescription.TabIndex = 10;
            this.LDescription.Text = "Описание";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(383, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pogoda2.Properties.Resources._000;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LDescription);
            this.Controls.Add(this.LSpeedVis);
            this.Controls.Add(this.LDateTime);
            this.Controls.Add(this.LSunset);
            this.Controls.Add(this.LSunrise);
            this.Controls.Add(this.LPressureAndHumidity);
            this.Controls.Add(this.Ltemp);
            this.Controls.Add(this.LCityAndCountry);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.Text = "ПОГОДА";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LCityAndCountry;
        private System.Windows.Forms.Label Ltemp;
        private System.Windows.Forms.Label LPressureAndHumidity;
        private System.Windows.Forms.Label LSunrise;
        private System.Windows.Forms.Label LSunset;
        private System.Windows.Forms.Label LDateTime;
        private System.Windows.Forms.Label LSpeedVis;
        private System.Windows.Forms.Label LDescription;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


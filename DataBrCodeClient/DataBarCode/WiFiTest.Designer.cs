namespace DataBarCode
{
    partial class WiFiTest
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс  следует удалить; иначе ложно.</param>
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WiFiTest));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.labelNetWiFi = new System.Windows.Forms.Label();
            this.buttonWifiOff = new System.Windows.Forms.Button();
            this.textBoxWiFi = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(215, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // label11
            // 
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(3, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 24);
            this.label11.Text = "Сеть WiFi:";
            // 
            // labelNetWiFi
            // 
            this.labelNetWiFi.ForeColor = System.Drawing.Color.White;
            this.labelNetWiFi.Location = new System.Drawing.Point(75, 31);
            this.labelNetWiFi.Name = "labelNetWiFi";
            this.labelNetWiFi.Size = new System.Drawing.Size(160, 24);
            this.labelNetWiFi.Text = "--";
            // 
            // buttonWifiOff
            // 
            this.buttonWifiOff.BackColor = System.Drawing.Color.Azure;
            this.buttonWifiOff.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonWifiOff.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.buttonWifiOff.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.buttonWifiOff.Location = new System.Drawing.Point(22, 242);
            this.buttonWifiOff.Name = "buttonWifiOff";
            this.buttonWifiOff.Size = new System.Drawing.Size(193, 26);
            this.buttonWifiOff.TabIndex = 52;
            this.buttonWifiOff.Text = "Подключить WiFi";
            this.buttonWifiOff.Click += new System.EventHandler(this.buttonWifiOff_Click);
            // 
            // textBoxWiFi
            // 
            this.textBoxWiFi.Location = new System.Drawing.Point(30, 142);
            this.textBoxWiFi.Name = "textBoxWiFi";
            this.textBoxWiFi.Size = new System.Drawing.Size(176, 23);
            this.textBoxWiFi.TabIndex = 53;
            this.textBoxWiFi.Text = "GoshaFree";
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(30, 171);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(176, 23);
            this.textBoxPass.TabIndex = 54;
            this.textBoxPass.Text = "1q2w3e4r";
            // 
            // WiFiTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(238, 295);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxWiFi);
            this.Controls.Add(this.buttonWifiOff);
            this.Controls.Add(this.labelNetWiFi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Name = "WiFiTest";
            this.Text = "WiFiTest";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WiFiTest_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelNetWiFi;
        private System.Windows.Forms.Button buttonWifiOff;
        private System.Windows.Forms.TextBox textBoxWiFi;
        private System.Windows.Forms.TextBox textBoxPass;
    }
}
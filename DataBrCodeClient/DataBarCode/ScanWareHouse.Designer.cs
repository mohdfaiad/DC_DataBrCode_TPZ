namespace DataBarCode
{
    partial class ScanWareHouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScanWareHouse));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.labelBD = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelCaption = new System.Windows.Forms.Label();
            this.textBoxScan = new System.Windows.Forms.TextBox();
            this.labelCode = new System.Windows.Forms.Label();
            this.labelGo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer();
            this.SuspendLayout();
            // 
            // labelBD
            // 
            this.labelBD.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labelBD.ForeColor = System.Drawing.Color.White;
            this.labelBD.Location = new System.Drawing.Point(0, 279);
            this.labelBD.Name = "labelBD";
            this.labelBD.Size = new System.Drawing.Size(235, 16);
            this.labelBD.Text = "БД: Нет данных. Операции: 0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(215, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelCaption
            // 
            this.labelCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelCaption.ForeColor = System.Drawing.Color.White;
            this.labelCaption.Location = new System.Drawing.Point(3, 0);
            this.labelCaption.Name = "labelCaption";
            this.labelCaption.Size = new System.Drawing.Size(206, 28);
            this.labelCaption.Text = "Место хранения";
            // 
            // textBoxScan
            // 
            this.textBoxScan.Location = new System.Drawing.Point(17, 123);
            this.textBoxScan.Name = "textBoxScan";
            this.textBoxScan.Size = new System.Drawing.Size(206, 23);
            this.textBoxScan.TabIndex = 35;
            // 
            // labelCode
            // 
            this.labelCode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.labelCode.ForeColor = System.Drawing.Color.White;
            this.labelCode.Location = new System.Drawing.Point(6, 154);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(232, 28);
            this.labelCode.Text = "Сканируйте код";
            this.labelCode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelGo
            // 
            this.labelGo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.labelGo.ForeColor = System.Drawing.Color.White;
            this.labelGo.Location = new System.Drawing.Point(3, 70);
            this.labelGo.Name = "labelGo";
            this.labelGo.Size = new System.Drawing.Size(232, 50);
            this.labelGo.Text = "Для просмотра места хранения";
            this.labelGo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ScanWareHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(238, 295);
            this.ControlBox = false;
            this.Controls.Add(this.labelGo);
            this.Controls.Add(this.labelCaption);
            this.Controls.Add(this.textBoxScan);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelBD);
            this.Name = "ScanWareHouse";
            this.Text = "ScanWareHouse";
            this.Closed += new System.EventHandler(this.ScanWareHouse_Closed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ScanWareHouse_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelBD;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelCaption;
        private System.Windows.Forms.TextBox textBoxScan;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.Label labelGo;
        private System.Windows.Forms.Timer timer1;
    }
}
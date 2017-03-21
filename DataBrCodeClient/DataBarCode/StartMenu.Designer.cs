namespace DataBarCode
{
    partial class StartMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartMenu));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.buttonScales = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxScan = new System.Windows.Forms.TextBox();
            this.buttonWarehouse = new System.Windows.Forms.Button();
            this.buttonOutCGP = new System.Windows.Forms.Button();
            this.buttonPlace = new System.Windows.Forms.Button();
            this.buttonAgr = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelBD = new System.Windows.Forms.Label();
            this.timerUpdateDich = new System.Windows.Forms.Timer();
            this.timerUpdateRelise = new System.Windows.Forms.Timer();
            this.buttonPushUE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonScales
            // 
            this.buttonScales.BackColor = System.Drawing.Color.Azure;
            this.buttonScales.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.buttonScales.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.buttonScales.Location = new System.Drawing.Point(23, 79);
            this.buttonScales.Name = "buttonScales";
            this.buttonScales.Size = new System.Drawing.Size(190, 26);
            this.buttonScales.TabIndex = 23;
            this.buttonScales.Text = "Взвесить";
            this.buttonScales.Click += new System.EventHandler(this.buttonScales_Click);
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
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, -3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 28);
            this.label2.Text = "Сканируйте код";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxScan
            // 
            this.textBoxScan.Location = new System.Drawing.Point(30, 23);
            this.textBoxScan.Name = "textBoxScan";
            this.textBoxScan.Size = new System.Drawing.Size(180, 23);
            this.textBoxScan.TabIndex = 29;
            // 
            // buttonWarehouse
            // 
            this.buttonWarehouse.BackColor = System.Drawing.Color.Azure;
            this.buttonWarehouse.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.buttonWarehouse.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.buttonWarehouse.Location = new System.Drawing.Point(23, 108);
            this.buttonWarehouse.Name = "buttonWarehouse";
            this.buttonWarehouse.Size = new System.Drawing.Size(190, 26);
            this.buttonWarehouse.TabIndex = 30;
            this.buttonWarehouse.Text = "Разместить";
            this.buttonWarehouse.Click += new System.EventHandler(this.buttonWarehouse_Click);
            // 
            // buttonOutCGP
            // 
            this.buttonOutCGP.BackColor = System.Drawing.Color.Azure;
            this.buttonOutCGP.Enabled = false;
            this.buttonOutCGP.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.buttonOutCGP.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.buttonOutCGP.Location = new System.Drawing.Point(23, 137);
            this.buttonOutCGP.Name = "buttonOutCGP";
            this.buttonOutCGP.Size = new System.Drawing.Size(190, 26);
            this.buttonOutCGP.TabIndex = 31;
            this.buttonOutCGP.Text = "Отгрузить";
            this.buttonOutCGP.Click += new System.EventHandler(this.buttonOutCGP_Click);
            // 
            // buttonPlace
            // 
            this.buttonPlace.BackColor = System.Drawing.Color.Azure;
            this.buttonPlace.Enabled = false;
            this.buttonPlace.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.buttonPlace.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.buttonPlace.Location = new System.Drawing.Point(23, 165);
            this.buttonPlace.Name = "buttonPlace";
            this.buttonPlace.Size = new System.Drawing.Size(190, 26);
            this.buttonPlace.TabIndex = 32;
            this.buttonPlace.Text = "Склад";
            this.buttonPlace.Click += new System.EventHandler(this.buttonPlace_Click);
            // 
            // buttonAgr
            // 
            this.buttonAgr.BackColor = System.Drawing.Color.Azure;
            this.buttonAgr.Enabled = false;
            this.buttonAgr.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.buttonAgr.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.buttonAgr.Location = new System.Drawing.Point(23, 194);
            this.buttonAgr.Name = "buttonAgr";
            this.buttonAgr.Size = new System.Drawing.Size(190, 26);
            this.buttonAgr.TabIndex = 33;
            this.buttonAgr.Text = "Агрегаты";
            this.buttonAgr.Click += new System.EventHandler(this.buttonAgr_Click_1);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Azure;
            this.buttonExit.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.buttonExit.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.buttonExit.Location = new System.Drawing.Point(23, 225);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(190, 31);
            this.buttonExit.TabIndex = 35;
            this.buttonExit.Text = "Выход";
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular);
            this.labelStatus.ForeColor = System.Drawing.Color.White;
            this.labelStatus.Location = new System.Drawing.Point(0, 258);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(235, 16);
            // 
            // labelBD
            // 
            this.labelBD.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labelBD.ForeColor = System.Drawing.Color.White;
            this.labelBD.Location = new System.Drawing.Point(0, 278);
            this.labelBD.Name = "labelBD";
            this.labelBD.Size = new System.Drawing.Size(235, 16);
            this.labelBD.Text = "БД: Нет данных. Операции: 0";
            // 
            // timerUpdateDich
            // 
            this.timerUpdateDich.Enabled = true;
            this.timerUpdateDich.Interval = 200;
            this.timerUpdateDich.Tick += new System.EventHandler(this.timerUpdateDich_Tick);
            // 
            // timerUpdateRelise
            // 
            this.timerUpdateRelise.Interval = 10000;
            this.timerUpdateRelise.Tick += new System.EventHandler(this.timerUpdateRelise_Tick);
            // 
            // buttonPushUE
            // 
            this.buttonPushUE.BackColor = System.Drawing.Color.Azure;
            this.buttonPushUE.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.buttonPushUE.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.buttonPushUE.Location = new System.Drawing.Point(24, 50);
            this.buttonPushUE.Name = "buttonPushUE";
            this.buttonPushUE.Size = new System.Drawing.Size(190, 26);
            this.buttonPushUE.TabIndex = 38;
            this.buttonPushUE.Text = "Прием УЕ";
            this.buttonPushUE.Click += new System.EventHandler(this.buttonPushUE_Click);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(238, 295);
            this.ControlBox = false;
            this.Controls.Add(this.buttonPushUE);
            this.Controls.Add(this.labelBD);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonAgr);
            this.Controls.Add(this.buttonPlace);
            this.Controls.Add(this.buttonOutCGP);
            this.Controls.Add(this.buttonWarehouse);
            this.Controls.Add(this.textBoxScan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonScales);
            this.Controls.Add(this.pictureBox1);
            this.Name = "StartMenu";
            this.Text = "StartMenu";
            this.Closed += new System.EventHandler(this.StartMenu_Closed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StartMenu_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonScales;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxScan;
        private System.Windows.Forms.Button buttonWarehouse;
        private System.Windows.Forms.Button buttonOutCGP;
        private System.Windows.Forms.Button buttonPlace;
        private System.Windows.Forms.Button buttonAgr;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelBD;
        private System.Windows.Forms.Timer timerUpdateDich;
        private System.Windows.Forms.Timer timerUpdateRelise;
        private System.Windows.Forms.Button buttonPushUE;
    }
}
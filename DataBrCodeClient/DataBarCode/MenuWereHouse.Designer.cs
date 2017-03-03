namespace DataBarCode
{
    partial class MenuWereHouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuWereHouse));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.labelBD = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonFactPlace = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer();
            this.buttonTaskMove = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonIntrovert = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSearchSRZ = new System.Windows.Forms.Button();
            this.buttonSearchYEUGP = new System.Windows.Forms.Button();
            this.buttonSearchRulon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelBD
            // 
            this.labelBD.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labelBD.ForeColor = System.Drawing.Color.White;
            this.labelBD.Location = new System.Drawing.Point(2, 278);
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 23);
            this.label2.Text = "Просмотр";
            // 
            // buttonFactPlace
            // 
            this.buttonFactPlace.BackColor = System.Drawing.Color.Azure;
            this.buttonFactPlace.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.buttonFactPlace.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.buttonFactPlace.Location = new System.Drawing.Point(25, 99);
            this.buttonFactPlace.Name = "buttonFactPlace";
            this.buttonFactPlace.Size = new System.Drawing.Size(186, 26);
            this.buttonFactPlace.TabIndex = 24;
            this.buttonFactPlace.Text = "Просмотр МХ";
            this.buttonFactPlace.Click += new System.EventHandler(this.buttonFactPlace_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonTaskMove
            // 
            this.buttonTaskMove.BackColor = System.Drawing.Color.Azure;
            this.buttonTaskMove.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.buttonTaskMove.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.buttonTaskMove.Location = new System.Drawing.Point(218, 266);
            this.buttonTaskMove.Name = "buttonTaskMove";
            this.buttonTaskMove.Size = new System.Drawing.Size(20, 26);
            this.buttonTaskMove.TabIndex = 28;
            this.buttonTaskMove.Text = "Перемещение";
            this.buttonTaskMove.Visible = false;
            this.buttonTaskMove.Click += new System.EventHandler(this.buttonTaskMove_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 23);
            this.label3.Text = "Склад";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonIntrovert
            // 
            this.buttonIntrovert.BackColor = System.Drawing.Color.Azure;
            this.buttonIntrovert.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.buttonIntrovert.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.buttonIntrovert.Location = new System.Drawing.Point(25, 41);
            this.buttonIntrovert.Name = "buttonIntrovert";
            this.buttonIntrovert.Size = new System.Drawing.Size(186, 26);
            this.buttonIntrovert.TabIndex = 33;
            this.buttonIntrovert.Text = "Инвентаризация";
            this.buttonIntrovert.Click += new System.EventHandler(this.buttonIntrovert_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 23);
            this.label4.Text = "Поиск УЕ";
            // 
            // buttonSearchSRZ
            // 
            this.buttonSearchSRZ.BackColor = System.Drawing.Color.Azure;
            this.buttonSearchSRZ.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.buttonSearchSRZ.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.buttonSearchSRZ.Location = new System.Drawing.Point(26, 192);
            this.buttonSearchSRZ.Name = "buttonSearchSRZ";
            this.buttonSearchSRZ.Size = new System.Drawing.Size(186, 26);
            this.buttonSearchSRZ.TabIndex = 41;
            this.buttonSearchSRZ.Text = "Поиск: штрипсы";
            this.buttonSearchSRZ.Click += new System.EventHandler(this.buttonSearchSRZ_Click);
            // 
            // buttonSearchYEUGP
            // 
            this.buttonSearchYEUGP.BackColor = System.Drawing.Color.Azure;
            this.buttonSearchYEUGP.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.buttonSearchYEUGP.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.buttonSearchYEUGP.Location = new System.Drawing.Point(25, 225);
            this.buttonSearchYEUGP.Name = "buttonSearchYEUGP";
            this.buttonSearchYEUGP.Size = new System.Drawing.Size(186, 26);
            this.buttonSearchYEUGP.TabIndex = 42;
            this.buttonSearchYEUGP.Text = "Поиск: пакеты";
            this.buttonSearchYEUGP.Click += new System.EventHandler(this.buttonSearchYEUGP_Click);
            // 
            // buttonSearchRulon
            // 
            this.buttonSearchRulon.BackColor = System.Drawing.Color.Azure;
            this.buttonSearchRulon.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.buttonSearchRulon.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.buttonSearchRulon.Location = new System.Drawing.Point(26, 159);
            this.buttonSearchRulon.Name = "buttonSearchRulon";
            this.buttonSearchRulon.Size = new System.Drawing.Size(186, 26);
            this.buttonSearchRulon.TabIndex = 48;
            this.buttonSearchRulon.Text = "Поиск: рулоны";
            this.buttonSearchRulon.Click += new System.EventHandler(this.buttonSearchRulon_Click);
            // 
            // MenuWereHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(238, 295);
            this.ControlBox = false;
            this.Controls.Add(this.buttonSearchRulon);
            this.Controls.Add(this.buttonSearchYEUGP);
            this.Controls.Add(this.buttonSearchSRZ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonIntrovert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonTaskMove);
            this.Controls.Add(this.buttonFactPlace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelBD);
            this.Name = "MenuWereHouse";
            this.Text = "MenuWereHouse";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MenuWereHouse_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelBD;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonFactPlace;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonTaskMove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonIntrovert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSearchSRZ;
        private System.Windows.Forms.Button buttonSearchYEUGP;
        private System.Windows.Forms.Button buttonSearchRulon;
    }
}
namespace DataBarCode
{
    partial class MenuAgr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAgr));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelBD = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer();
            this.buttonapr = new System.Windows.Forms.Button();
            this.buttonT19 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 23);
            this.label3.Text = "Агрегаты";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(215, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonapr
            // 
            this.buttonapr.BackColor = System.Drawing.Color.Azure;
            this.buttonapr.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.buttonapr.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.buttonapr.Location = new System.Drawing.Point(26, 39);
            this.buttonapr.Name = "buttonapr";
            this.buttonapr.Size = new System.Drawing.Size(186, 26);
            this.buttonapr.TabIndex = 25;
            this.buttonapr.Text = "АПР";
            this.buttonapr.Click += new System.EventHandler(this.buttonapr_Click);
            // 
            // buttonT19
            // 
            this.buttonT19.BackColor = System.Drawing.Color.Azure;
            this.buttonT19.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.buttonT19.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.buttonT19.Location = new System.Drawing.Point(26, 74);
            this.buttonT19.Name = "buttonT19";
            this.buttonT19.Size = new System.Drawing.Size(186, 26);
            this.buttonT19.TabIndex = 28;
            this.buttonT19.Text = "ТЭСА";
            this.buttonT19.Click += new System.EventHandler(this.buttonT19_Click);
            // 
            // MenuAgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(238, 295);
            this.ControlBox = false;
            this.Controls.Add(this.buttonT19);
            this.Controls.Add(this.buttonapr);
            this.Controls.Add(this.labelBD);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Name = "MenuAgr";
            this.Text = "Агрегаты";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MenuAgr_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelBD;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonapr;
        private System.Windows.Forms.Button buttonT19;
    }
}
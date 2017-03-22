namespace DataBarCode
{
    partial class DataScalesFixAndPost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataScalesFixAndPost));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.labelWeigth = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxScales = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelBD = new System.Windows.Forms.Label();
            this.buttonFix = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxAgr = new System.Windows.Forms.ComboBox();
            this.comboBoxWareHouse = new System.Windows.Forms.ComboBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWeigth
            // 
            this.labelWeigth.Font = new System.Drawing.Font("Tahoma", 28F, System.Drawing.FontStyle.Bold);
            this.labelWeigth.ForeColor = System.Drawing.Color.White;
            this.labelWeigth.Location = new System.Drawing.Point(3, 30);
            this.labelWeigth.Name = "labelWeigth";
            this.labelWeigth.Size = new System.Drawing.Size(176, 42);
            this.labelWeigth.Text = "5842";
            this.labelWeigth.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(179, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 24);
            this.label2.Text = "кг";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBoxScales
            // 
            this.comboBoxScales.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.comboBoxScales.Items.Add("22-т:Склад штрипсов");
            this.comboBoxScales.Location = new System.Drawing.Point(73, 1);
            this.comboBoxScales.Name = "comboBoxScales";
            this.comboBoxScales.Size = new System.Drawing.Size(140, 29);
            this.comboBoxScales.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.Text = "Весы: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(214, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // labelBD
            // 
            this.labelBD.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labelBD.ForeColor = System.Drawing.Color.White;
            this.labelBD.Location = new System.Drawing.Point(-1, 276);
            this.labelBD.Name = "labelBD";
            this.labelBD.Size = new System.Drawing.Size(235, 16);
            this.labelBD.Text = "БД: Нет данных. Операции: 0";
            // 
            // buttonFix
            // 
            this.buttonFix.BackColor = System.Drawing.Color.Azure;
            this.buttonFix.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.buttonFix.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.buttonFix.Location = new System.Drawing.Point(39, 79);
            this.buttonFix.Name = "buttonFix";
            this.buttonFix.Size = new System.Drawing.Size(160, 26);
            this.buttonFix.TabIndex = 53;
            this.buttonFix.Text = "Фиксировать";
            this.buttonFix.Click += new System.EventHandler(this.buttonFix_Click_1);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(10, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 19);
            this.label5.Text = "Место хранения";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 19);
            this.label4.Text = "Склад";
            // 
            // comboBoxAgr
            // 
            this.comboBoxAgr.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.comboBoxAgr.Location = new System.Drawing.Point(10, 136);
            this.comboBoxAgr.Name = "comboBoxAgr";
            this.comboBoxAgr.Size = new System.Drawing.Size(206, 29);
            this.comboBoxAgr.TabIndex = 57;
            this.comboBoxAgr.SelectedIndexChanged += new System.EventHandler(this.comboBoxAgr_SelectedIndexChanged_1);
            // 
            // comboBoxWareHouse
            // 
            this.comboBoxWareHouse.Enabled = false;
            this.comboBoxWareHouse.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.comboBoxWareHouse.Location = new System.Drawing.Point(10, 193);
            this.comboBoxWareHouse.Name = "comboBoxWareHouse";
            this.comboBoxWareHouse.Size = new System.Drawing.Size(206, 29);
            this.comboBoxWareHouse.TabIndex = 56;
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.Azure;
            this.buttonNext.Enabled = false;
            this.buttonNext.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.buttonNext.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.buttonNext.Location = new System.Drawing.Point(39, 239);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(160, 26);
            this.buttonNext.TabIndex = 60;
            this.buttonNext.Text = "Продолжить";
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click_1);
            // 
            // DataScalesFixAndPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(238, 295);
            this.ControlBox = false;
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxAgr);
            this.Controls.Add(this.comboBoxWareHouse);
            this.Controls.Add(this.buttonFix);
            this.Controls.Add(this.labelBD);
            this.Controls.Add(this.labelWeigth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxScales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Name = "DataScalesFixAndPost";
            this.Text = "Прием УЕ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataScalesFixAndPost_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelWeigth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxScales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelBD;
        private System.Windows.Forms.Button buttonFix;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxAgr;
        private System.Windows.Forms.ComboBox comboBoxWareHouse;
        private System.Windows.Forms.Button buttonNext;
    }
}
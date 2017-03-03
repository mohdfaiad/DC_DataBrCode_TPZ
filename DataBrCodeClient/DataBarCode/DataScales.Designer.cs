namespace DataBarCode
{
    partial class DataScales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataScales));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.labelplav = new System.Windows.Forms.Label();
            this.labelPart = new System.Windows.Forms.Label();
            this.labelMark = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxScales = new System.Windows.Forms.ComboBox();
            this.buttonFix = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelWeigth = new System.Windows.Forms.Label();
            this.labelLabel = new System.Windows.Forms.Label();
            this.labelUnitWegth = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelBD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelplav
            // 
            this.labelplav.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.labelplav.ForeColor = System.Drawing.Color.White;
            this.labelplav.Location = new System.Drawing.Point(10, 169);
            this.labelplav.Name = "labelplav";
            this.labelplav.Size = new System.Drawing.Size(195, 24);
            this.labelplav.Text = "Плавка:";
            // 
            // labelPart
            // 
            this.labelPart.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.labelPart.ForeColor = System.Drawing.Color.White;
            this.labelPart.Location = new System.Drawing.Point(10, 147);
            this.labelPart.Name = "labelPart";
            this.labelPart.Size = new System.Drawing.Size(195, 24);
            this.labelPart.Text = "Партия:";
            // 
            // labelMark
            // 
            this.labelMark.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.labelMark.ForeColor = System.Drawing.Color.White;
            this.labelMark.Location = new System.Drawing.Point(10, 190);
            this.labelMark.Name = "labelMark";
            this.labelMark.Size = new System.Drawing.Size(195, 24);
            this.labelMark.Text = "Марка:";
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
            // lblID
            // 
            this.lblID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(10, 124);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(195, 24);
            this.lblID.Text = "ID: ";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.Text = "Весы: ";
            // 
            // comboBoxScales
            // 
            this.comboBoxScales.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.comboBoxScales.Location = new System.Drawing.Point(82, 9);
            this.comboBoxScales.Name = "comboBoxScales";
            this.comboBoxScales.Size = new System.Drawing.Size(127, 29);
            this.comboBoxScales.TabIndex = 45;
            this.comboBoxScales.SelectedIndexChanged += new System.EventHandler(this.comboBoxScales_SelectedIndexChanged);
            // 
            // buttonFix
            // 
            this.buttonFix.BackColor = System.Drawing.Color.Azure;
            this.buttonFix.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.buttonFix.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.buttonFix.Location = new System.Drawing.Point(36, 236);
            this.buttonFix.Name = "buttonFix";
            this.buttonFix.Size = new System.Drawing.Size(160, 26);
            this.buttonFix.TabIndex = 46;
            this.buttonFix.Text = "Фиксировать";
            this.buttonFix.Click += new System.EventHandler(this.buttonFix_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 24);
            this.label2.Text = "Текущий вес, кг";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelWeigth
            // 
            this.labelWeigth.Font = new System.Drawing.Font("Tahoma", 28F, System.Drawing.FontStyle.Bold);
            this.labelWeigth.ForeColor = System.Drawing.Color.White;
            this.labelWeigth.Location = new System.Drawing.Point(3, 59);
            this.labelWeigth.Name = "labelWeigth";
            this.labelWeigth.Size = new System.Drawing.Size(232, 42);
            this.labelWeigth.Text = "0";
            this.labelWeigth.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelLabel
            // 
            this.labelLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.labelLabel.ForeColor = System.Drawing.Color.White;
            this.labelLabel.Location = new System.Drawing.Point(10, 100);
            this.labelLabel.Name = "labelLabel";
            this.labelLabel.Size = new System.Drawing.Size(195, 24);
            this.labelLabel.Text = "Label: ";
            // 
            // labelUnitWegth
            // 
            this.labelUnitWegth.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.labelUnitWegth.ForeColor = System.Drawing.Color.White;
            this.labelUnitWegth.Location = new System.Drawing.Point(10, 213);
            this.labelUnitWegth.Name = "labelUnitWegth";
            this.labelUnitWegth.Size = new System.Drawing.Size(195, 24);
            this.labelUnitWegth.Text = "Вес:";
            // 
            // labelStatus
            // 
            this.labelStatus.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular);
            this.labelStatus.ForeColor = System.Drawing.Color.White;
            this.labelStatus.Location = new System.Drawing.Point(0, 266);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(235, 13);
            // 
            // labelBD
            // 
            this.labelBD.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labelBD.ForeColor = System.Drawing.Color.White;
            this.labelBD.Location = new System.Drawing.Point(2, 279);
            this.labelBD.Name = "labelBD";
            this.labelBD.Size = new System.Drawing.Size(235, 16);
            this.labelBD.Text = "БД: Нет данных. Операции: 0";
            // 
            // DataScales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(238, 295);
            this.ControlBox = false;
            this.Controls.Add(this.labelBD);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelUnitWegth);
            this.Controls.Add(this.labelLabel);
            this.Controls.Add(this.labelWeigth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonFix);
            this.Controls.Add(this.comboBoxScales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelplav);
            this.Controls.Add(this.labelPart);
            this.Controls.Add(this.labelMark);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblID);
            this.Name = "DataScales";
            this.Text = "DataScales";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataScales_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelplav;
        private System.Windows.Forms.Label labelPart;
        private System.Windows.Forms.Label labelMark;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxScales;
        private System.Windows.Forms.Button buttonFix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelWeigth;
        private System.Windows.Forms.Label labelLabel;
        private System.Windows.Forms.Label labelUnitWegth;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelBD;
    }
}
namespace DataBarCode
{
    partial class EU_Action
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EU_Action));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.lblID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelMark = new System.Windows.Forms.Label();
            this.labelPart = new System.Windows.Forms.Label();
            this.labelplav = new System.Windows.Forms.Label();
            this.labelLabel = new System.Windows.Forms.Label();
            this.labelUnitWegth = new System.Windows.Forms.Label();
            this.labelBD = new System.Windows.Forms.Label();
            this.labelPlanMX = new System.Windows.Forms.Label();
            this.labelFactMX = new System.Windows.Forms.Label();
            this.labelUnitWegthASUP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(4, 48);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(195, 24);
            this.lblID.Text = "ID: ";
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
            // labelMark
            // 
            this.labelMark.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.labelMark.ForeColor = System.Drawing.Color.White;
            this.labelMark.Location = new System.Drawing.Point(4, 118);
            this.labelMark.Name = "labelMark";
            this.labelMark.Size = new System.Drawing.Size(195, 24);
            this.labelMark.Text = "Марка:";
            // 
            // labelPart
            // 
            this.labelPart.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.labelPart.ForeColor = System.Drawing.Color.White;
            this.labelPart.Location = new System.Drawing.Point(4, 72);
            this.labelPart.Name = "labelPart";
            this.labelPart.Size = new System.Drawing.Size(195, 24);
            this.labelPart.Text = "Партия:";
            // 
            // labelplav
            // 
            this.labelplav.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.labelplav.ForeColor = System.Drawing.Color.White;
            this.labelplav.Location = new System.Drawing.Point(4, 95);
            this.labelplav.Name = "labelplav";
            this.labelplav.Size = new System.Drawing.Size(195, 24);
            this.labelplav.Text = "Плавка:";
            // 
            // labelLabel
            // 
            this.labelLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.labelLabel.ForeColor = System.Drawing.Color.White;
            this.labelLabel.Location = new System.Drawing.Point(4, 24);
            this.labelLabel.Name = "labelLabel";
            this.labelLabel.Size = new System.Drawing.Size(195, 24);
            this.labelLabel.Text = "Label: ";
            // 
            // labelUnitWegth
            // 
            this.labelUnitWegth.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.labelUnitWegth.ForeColor = System.Drawing.Color.White;
            this.labelUnitWegth.Location = new System.Drawing.Point(5, 141);
            this.labelUnitWegth.Name = "labelUnitWegth";
            this.labelUnitWegth.Size = new System.Drawing.Size(195, 24);
            this.labelUnitWegth.Text = "Вес факт:";
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
            // labelPlanMX
            // 
            this.labelPlanMX.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.labelPlanMX.ForeColor = System.Drawing.Color.White;
            this.labelPlanMX.Location = new System.Drawing.Point(4, 214);
            this.labelPlanMX.Name = "labelPlanMX";
            this.labelPlanMX.Size = new System.Drawing.Size(231, 24);
            this.labelPlanMX.Text = "План MX:";
            // 
            // labelFactMX
            // 
            this.labelFactMX.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.labelFactMX.ForeColor = System.Drawing.Color.White;
            this.labelFactMX.Location = new System.Drawing.Point(4, 188);
            this.labelFactMX.Name = "labelFactMX";
            this.labelFactMX.Size = new System.Drawing.Size(231, 24);
            this.labelFactMX.Text = "Факт MX:";
            // 
            // labelUnitWegthASUP
            // 
            this.labelUnitWegthASUP.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.labelUnitWegthASUP.ForeColor = System.Drawing.Color.White;
            this.labelUnitWegthASUP.Location = new System.Drawing.Point(4, 165);
            this.labelUnitWegthASUP.Name = "labelUnitWegthASUP";
            this.labelUnitWegthASUP.Size = new System.Drawing.Size(231, 24);
            this.labelUnitWegthASUP.Text = "Вес АСУП:";
            // 
            // EU_Action
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(238, 295);
            this.ControlBox = false;
            this.Controls.Add(this.labelUnitWegthASUP);
            this.Controls.Add(this.labelFactMX);
            this.Controls.Add(this.labelPlanMX);
            this.Controls.Add(this.labelBD);
            this.Controls.Add(this.labelUnitWegth);
            this.Controls.Add(this.labelLabel);
            this.Controls.Add(this.labelplav);
            this.Controls.Add(this.labelPart);
            this.Controls.Add(this.labelMark);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblID);
            this.Name = "EU_Action";
            this.Text = "Информация о ЕУ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EU_Action_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelMark;
        private System.Windows.Forms.Label labelPart;
        private System.Windows.Forms.Label labelplav;
        private System.Windows.Forms.Label labelLabel;
        private System.Windows.Forms.Label labelUnitWegth;
        private System.Windows.Forms.Label labelBD;
        private System.Windows.Forms.Label labelPlanMX;
        private System.Windows.Forms.Label labelFactMX;
        private System.Windows.Forms.Label labelUnitWegthASUP;

    }
}
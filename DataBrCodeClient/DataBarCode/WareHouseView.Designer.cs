namespace DataBarCode
{
    partial class WareHouseView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WareHouseView));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.labelBD = new System.Windows.Forms.Label();
            this.dataGridEu = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.labelMXMore = new System.Windows.Forms.Label();
            this.labelMX = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer();
            this.dataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
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
            // dataGridEu
            // 
            this.dataGridEu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridEu.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular);
            this.dataGridEu.GridLineColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridEu.Location = new System.Drawing.Point(4, 42);
            this.dataGridEu.Name = "dataGridEu";
            this.dataGridEu.RowHeadersVisible = false;
            this.dataGridEu.Size = new System.Drawing.Size(228, 233);
            this.dataGridEu.TabIndex = 13;
            this.dataGridEu.TableStyles.Add(this.dataGridTableStyle1);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn5);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn4);
            this.dataGridTableStyle1.MappingName = "EU";
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.HeaderText = "УЕ";
            this.dataGridTextBoxColumn1.MappingName = "УЕ";
            this.dataGridTextBoxColumn1.NullText = "-";
            this.dataGridTextBoxColumn1.Width = 75;
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.Format = "";
            this.dataGridTextBoxColumn2.FormatInfo = null;
            this.dataGridTextBoxColumn2.HeaderText = "Марка";
            this.dataGridTextBoxColumn2.MappingName = "Марка";
            this.dataGridTextBoxColumn2.NullText = "-";
            this.dataGridTextBoxColumn2.Width = 75;
            // 
            // dataGridTextBoxColumn3
            // 
            this.dataGridTextBoxColumn3.Format = "";
            this.dataGridTextBoxColumn3.FormatInfo = null;
            this.dataGridTextBoxColumn3.HeaderText = "Размер";
            this.dataGridTextBoxColumn3.MappingName = "Размер";
            this.dataGridTextBoxColumn3.NullText = "-";
            this.dataGridTextBoxColumn3.Width = 75;
            // 
            // dataGridTextBoxColumn4
            // 
            this.dataGridTextBoxColumn4.Format = "";
            this.dataGridTextBoxColumn4.FormatInfo = null;
            this.dataGridTextBoxColumn4.HeaderText = "Label";
            this.dataGridTextBoxColumn4.MappingName = "Label";
            this.dataGridTextBoxColumn4.NullText = "-";
            this.dataGridTextBoxColumn4.Width = 90;
            // 
            // labelMXMore
            // 
            this.labelMXMore.ForeColor = System.Drawing.Color.White;
            this.labelMXMore.Location = new System.Drawing.Point(3, 23);
            this.labelMXMore.Name = "labelMXMore";
            this.labelMXMore.Size = new System.Drawing.Size(232, 22);
            this.labelMXMore.Text = "MX_More";
            // 
            // labelMX
            // 
            this.labelMX.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.labelMX.ForeColor = System.Drawing.Color.White;
            this.labelMX.Location = new System.Drawing.Point(0, 2);
            this.labelMX.Name = "labelMX";
            this.labelMX.Size = new System.Drawing.Size(209, 21);
            this.labelMX.Text = "MX";
            this.labelMX.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridTextBoxColumn5
            // 
            this.dataGridTextBoxColumn5.Format = "";
            this.dataGridTextBoxColumn5.FormatInfo = null;
            this.dataGridTextBoxColumn5.HeaderText = "Вес";
            this.dataGridTextBoxColumn5.MappingName = "Вес";
            this.dataGridTextBoxColumn5.NullText = "-";
            // 
            // WareHouseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(238, 295);
            this.ControlBox = false;
            this.Controls.Add(this.labelBD);
            this.Controls.Add(this.dataGridEu);
            this.Controls.Add(this.labelMXMore);
            this.Controls.Add(this.labelMX);
            this.Controls.Add(this.pictureBox1);
            this.Name = "WareHouseView";
            this.Text = "WareHouseView";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WareHouseView_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelBD;
        private System.Windows.Forms.DataGrid dataGridEu;
        private System.Windows.Forms.Label labelMXMore;
        private System.Windows.Forms.Label labelMX;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn5;
    }
}
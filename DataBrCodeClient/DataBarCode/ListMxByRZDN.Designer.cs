namespace DataBarCode
{
    partial class ListMxByRZDN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListMxByRZDN));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.labelMX = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.dataGridEu = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.SuspendLayout();
            // 
            // labelMX
            // 
            this.labelMX.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.labelMX.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelMX.Location = new System.Drawing.Point(0, 2);
            this.labelMX.Name = "labelMX";
            this.labelMX.Size = new System.Drawing.Size(209, 21);
            this.labelMX.Text = "Расположение ЕУ";
            this.labelMX.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(215, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Azure;
            this.buttonClose.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.buttonClose.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.buttonClose.Location = new System.Drawing.Point(39, 266);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(160, 26);
            this.buttonClose.TabIndex = 61;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // dataGridEu
            // 
            this.dataGridEu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridEu.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.dataGridEu.GridLineColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridEu.Location = new System.Drawing.Point(3, 29);
            this.dataGridEu.Name = "dataGridEu";
            this.dataGridEu.RowHeadersVisible = false;
            this.dataGridEu.Size = new System.Drawing.Size(230, 231);
            this.dataGridEu.TabIndex = 65;
            this.dataGridEu.TableStyles.Add(this.dataGridTableStyle1);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
            this.dataGridTableStyle1.MappingName = "EU";
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.HeaderText = "Склад";
            this.dataGridTextBoxColumn1.MappingName = "Склад";
            this.dataGridTextBoxColumn1.NullText = "-";
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.Format = "";
            this.dataGridTextBoxColumn2.FormatInfo = null;
            this.dataGridTextBoxColumn2.HeaderText = "MX";
            this.dataGridTextBoxColumn2.MappingName = "MX";
            this.dataGridTextBoxColumn2.NullText = "-";
            this.dataGridTextBoxColumn2.Width = 110;
            // 
            // dataGridTextBoxColumn3
            // 
            this.dataGridTextBoxColumn3.Format = "";
            this.dataGridTextBoxColumn3.FormatInfo = null;
            this.dataGridTextBoxColumn3.HeaderText = "УЕ";
            this.dataGridTextBoxColumn3.MappingName = "УЕ";
            this.dataGridTextBoxColumn3.NullText = "-";
            this.dataGridTextBoxColumn3.Width = 80;
            // 
            // ListMxByRZDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(238, 295);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridEu);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelMX);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Name = "ListMxByRZDN";
            this.Text = "ЕУ под задание";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListMxByRZDN_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelMX;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonClose;
        public System.Windows.Forms.DataGrid dataGridEu;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
    }
}
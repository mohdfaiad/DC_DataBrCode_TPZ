namespace DataBarCode
{
    partial class EUSearch_UGP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EUSearch_UGP));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.labelMX = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxFOK = new System.Windows.Forms.TextBox();
            this.textBoxSAP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridEu = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.SuspendLayout();
            // 
            // labelMX
            // 
            this.labelMX.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelMX.ForeColor = System.Drawing.Color.White;
            this.labelMX.Location = new System.Drawing.Point(21, 1);
            this.labelMX.Name = "labelMX";
            this.labelMX.Size = new System.Drawing.Size(180, 21);
            this.labelMX.Text = "Поиск: пакеты";
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
            // textBoxFOK
            // 
            this.textBoxFOK.Location = new System.Drawing.Point(57, 25);
            this.textBoxFOK.Name = "textBoxFOK";
            this.textBoxFOK.Size = new System.Drawing.Size(144, 23);
            this.textBoxFOK.TabIndex = 36;
            // 
            // textBoxSAP
            // 
            this.textBoxSAP.Location = new System.Drawing.Point(57, 50);
            this.textBoxSAP.Name = "textBoxSAP";
            this.textBoxSAP.Size = new System.Drawing.Size(144, 23);
            this.textBoxSAP.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.Text = "ФОК";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 21);
            this.label2.Text = "SAP";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridEu
            // 
            this.dataGridEu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridEu.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.dataGridEu.GridLineColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridEu.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
            this.dataGridEu.Location = new System.Drawing.Point(3, 75);
            this.dataGridEu.Name = "dataGridEu";
            this.dataGridEu.RowHeadersVisible = false;
            this.dataGridEu.Size = new System.Drawing.Size(230, 217);
            this.dataGridEu.TabIndex = 39;
            this.dataGridEu.TableStyles.Add(this.dataGridTableStyle1);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            this.dataGridTableStyle1.MappingName = "EU";
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.HeaderText = "ФОК";
            this.dataGridTextBoxColumn1.MappingName = "RPRT_NOM";
            this.dataGridTextBoxColumn1.NullText = "-";
            this.dataGridTextBoxColumn1.Width = 90;
            // 
            // dataGridTextBoxColumn3
            // 
            this.dataGridTextBoxColumn3.Format = "";
            this.dataGridTextBoxColumn3.FormatInfo = null;
            this.dataGridTextBoxColumn3.HeaderText = "SAP";
            this.dataGridTextBoxColumn3.MappingName = "ORDER_SAP";
            this.dataGridTextBoxColumn3.NullText = "-";
            this.dataGridTextBoxColumn3.Width = 80;
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.Format = "";
            this.dataGridTextBoxColumn2.FormatInfo = null;
            this.dataGridTextBoxColumn2.HeaderText = "МХ";
            this.dataGridTextBoxColumn2.MappingName = "TEHUZ_NAZ";
            this.dataGridTextBoxColumn2.NullText = "-";
            this.dataGridTextBoxColumn2.Width = 90;
            // 
            // EUSearch_UGP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(238, 295);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridEu);
            this.Controls.Add(this.textBoxFOK);
            this.Controls.Add(this.textBoxSAP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelMX);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Name = "EUSearch_UGP";
            this.Text = "Поиск: пакеты";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EUSearch_UGP_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelMX;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxFOK;
        private System.Windows.Forms.TextBox textBoxSAP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGrid dataGridEu;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
    }
}
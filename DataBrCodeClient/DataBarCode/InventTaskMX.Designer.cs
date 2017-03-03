namespace DataBarCode
{
    partial class InventTaskMX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventTaskMX));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.labelBD = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.dataGridTask = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.labelData = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelDetalIN = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer();
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
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.Azure;
            this.buttonNext.Enabled = false;
            this.buttonNext.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.buttonNext.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.buttonNext.Location = new System.Drawing.Point(38, 249);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(160, 26);
            this.buttonNext.TabIndex = 65;
            this.buttonNext.Text = "Подтвердить";
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // dataGridTask
            // 
            this.dataGridTask.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridTask.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.dataGridTask.GridLineColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridTask.Location = new System.Drawing.Point(4, 49);
            this.dataGridTask.Name = "dataGridTask";
            this.dataGridTask.RowHeadersVisible = false;
            this.dataGridTask.Size = new System.Drawing.Size(230, 194);
            this.dataGridTask.TabIndex = 64;
            this.dataGridTask.TableStyles.Add(this.dataGridTableStyle1);
            this.dataGridTask.CurrentCellChanged += new System.EventHandler(this.dataGridTask_CurrentCellChanged);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
            this.dataGridTableStyle1.MappingName = "TASK";
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.HeaderText = "Склад";
            this.dataGridTextBoxColumn1.MappingName = "AGR";
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
            this.dataGridTextBoxColumn3.HeaderText = "MX_LABEL";
            this.dataGridTextBoxColumn3.MappingName = "MX_LABEL";
            this.dataGridTextBoxColumn3.NullText = "-";
            this.dataGridTextBoxColumn3.Width = 120;
            // 
            // labelData
            // 
            this.labelData.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.labelData.ForeColor = System.Drawing.Color.White;
            this.labelData.Location = new System.Drawing.Point(0, 2);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(209, 21);
            this.labelData.Text = "Дата документа";
            this.labelData.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(215, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // labelDetalIN
            // 
            this.labelDetalIN.ForeColor = System.Drawing.Color.White;
            this.labelDetalIN.Location = new System.Drawing.Point(3, 25);
            this.labelDetalIN.Name = "labelDetalIN";
            this.labelDetalIN.Size = new System.Drawing.Size(231, 21);
            this.labelDetalIN.Text = "Описание";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // InventTaskMX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(238, 295);
            this.ControlBox = false;
            this.Controls.Add(this.labelDetalIN);
            this.Controls.Add(this.labelBD);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.dataGridTask);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.pictureBox1);
            this.Name = "InventTaskMX";
            this.Text = "Инвентаризация";
            this.Closed += new System.EventHandler(this.InventTaskMX_Closed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InventTaskMX_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelBD;
        private System.Windows.Forms.Button buttonNext;
        public System.Windows.Forms.DataGrid dataGridTask;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelDetalIN;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
    }
}
namespace DataBarCode
{
    partial class WarehousePost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarehousePost));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelMX = new System.Windows.Forms.Label();
            this.labelMXMore = new System.Windows.Forms.Label();
            this.dataGridEu = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelBD = new System.Windows.Forms.Label();
            this.timerDich = new System.Windows.Forms.Timer();
            this.buttonEUSearch = new System.Windows.Forms.Button();
            this.labelCountScan = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            // labelMXMore
            // 
            this.labelMXMore.ForeColor = System.Drawing.Color.White;
            this.labelMXMore.Location = new System.Drawing.Point(3, 23);
            this.labelMXMore.Name = "labelMXMore";
            this.labelMXMore.Size = new System.Drawing.Size(232, 22);
            this.labelMXMore.Text = "MX_More";
            // 
            // dataGridEu
            // 
            this.dataGridEu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridEu.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.dataGridEu.GridLineColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridEu.Location = new System.Drawing.Point(4, 42);
            this.dataGridEu.Name = "dataGridEu";
            this.dataGridEu.RowHeadersVisible = false;
            this.dataGridEu.Size = new System.Drawing.Size(230, 201);
            this.dataGridEu.TabIndex = 8;
            this.dataGridEu.TableStyles.Add(this.dataGridTableStyle1);
            this.dataGridEu.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridEu_Paint);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.MappingName = "EU";
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.Azure;
            this.buttonNext.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.buttonNext.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.buttonNext.Location = new System.Drawing.Point(38, 249);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(160, 26);
            this.buttonNext.TabIndex = 50;
            this.buttonNext.Text = "Подтвердить";
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click_1);
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
            // timerDich
            // 
            this.timerDich.Enabled = true;
            this.timerDich.Tick += new System.EventHandler(this.timerDich_Tick);
            // 
            // buttonEUSearch
            // 
            this.buttonEUSearch.BackColor = System.Drawing.Color.Azure;
            this.buttonEUSearch.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.buttonEUSearch.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.buttonEUSearch.Location = new System.Drawing.Point(204, 249);
            this.buttonEUSearch.Name = "buttonEUSearch";
            this.buttonEUSearch.Size = new System.Drawing.Size(29, 26);
            this.buttonEUSearch.TabIndex = 54;
            this.buttonEUSearch.Text = "+";
            this.buttonEUSearch.Click += new System.EventHandler(this.buttonEUSearch_Click);
            // 
            // labelCountScan
            // 
            this.labelCountScan.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.labelCountScan.ForeColor = System.Drawing.Color.White;
            this.labelCountScan.Location = new System.Drawing.Point(1, 253);
            this.labelCountScan.Name = "labelCountScan";
            this.labelCountScan.Size = new System.Drawing.Size(32, 18);
            this.labelCountScan.Text = "999";
            this.labelCountScan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WarehousePost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(238, 295);
            this.ControlBox = false;
            this.Controls.Add(this.labelCountScan);
            this.Controls.Add(this.buttonEUSearch);
            this.Controls.Add(this.labelBD);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.dataGridEu);
            this.Controls.Add(this.labelMXMore);
            this.Controls.Add(this.labelMX);
            this.Controls.Add(this.pictureBox1);
            this.Name = "WarehousePost";
            this.Text = "Размещение ЕУ";
            this.Closed += new System.EventHandler(this.WarehousePost_Closed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WarehousePost_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelMX;
        private System.Windows.Forms.Label labelMXMore;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelBD;
        private System.Windows.Forms.Timer timerDich;
        public System.Windows.Forms.DataGrid dataGridEu;
        private System.Windows.Forms.Button buttonEUSearch;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.Label labelCountScan;
    }
}
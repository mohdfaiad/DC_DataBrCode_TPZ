using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace DataBarCode
{
    public partial class WareHouseView : Form
    {
        public string LabelMX;
        public DataTable _tblEU;
        public WareHouseView(string _LabelMX)
        {
            InitializeComponent();
            this.LabelMX = _LabelMX;
            labelMX.Text = _LabelMX;
            labelMXMore.Text = SqlLiteQuery.GetNameMX(_LabelMX);

            InitGrid();

            //Выводим инфушку
            try
            {
                string StatusBD = StatusBar.getSatus();

                labelBD.BeginInvoke(new Action(() =>
                {
                    labelBD.Text = StatusBD;
                    labelBD.ForeColor = StatusBar.GetColorLabel();
                }));
            }

            catch (Exception) { }
            this.KeyPreview = true;
        }


        public void InitGrid()
        {
            _tblEU = new DataTable();
      

            using (SQLiteConnection connection = new SQLiteConnection())
            {

                ;//(SQLiteConnection)factory.CreateConnection();
                connection.ConnectionString = "Data Source = " + SqLiteDB.pathDBFull_EU;
                SQLiteCommand command = new SQLiteCommand(connection);
                SQLiteCommand insert = new SQLiteCommand("select EU.RELMUCH_LABEL 'Label', EU.RPRT_NOM 'УЕ', EU.MARKA_NAME 'Марка',  printf('%sx%s', EU.RELMUCH_THICKNESS, EU.RELMUCH_WIDTH) 'Размер'  from EU WHERE EU.TEHUZ_KOD = (select TEHUZ.TEHUZ_KOD FROM TEHUZ WHERE TEHUZ.TEHUZ_LABEL = '" + this.LabelMX + "') AND  EU.INTRV_TMEND = '' AND EU.SIGN='1' LIMIT 50;", connection);
                connection.Open();
                SQLiteDataReader reader = insert.ExecuteReader();
                _tblEU.Load(reader);
                reader.Close();
                connection.Close();

                command.Dispose();
                insert.Dispose();
                reader.Dispose();
            }

            dataGridEu.BeginInvoke(new Action(() =>
            {
                dataGridEu.DataSource = _tblEU;
            }));


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Выводим инфушку
            try
            {
                string StatusBD = StatusBar.getSatus();

                labelBD.BeginInvoke(new Action(() =>
                {
                    labelBD.Text = StatusBD;
                    labelBD.ForeColor = StatusBar.GetColorLabel();
                }));
            }

            catch (Exception) { }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WareHouseView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

    }
}
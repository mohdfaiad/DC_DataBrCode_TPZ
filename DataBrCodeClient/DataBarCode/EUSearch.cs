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
    public partial class EUSearch : Form
    {
        public DataTable _tblEU;
        public string SelectLabel = "";
        public string SelectYE = "";
        public string SelectMarka = "";
        public string SelectRazmer = "";
        public Double SelectWeight= 0;

        public EUSearch()
        {
            InitializeComponent();
            InitTable();
            this.KeyPreview = true;
            dataGridEu.GridLineStyle = DataGridLineStyle.Solid;
            //dataGridEu.
        }


        public void InitTable()
        {

            _tblEU = new DataTable("EU");



            DataColumn colSource = new DataColumn("УЕ", typeof(String));
            _tblEU.Columns.Add(colSource);
            // colSource.Caption = "Партия";
            DataColumn colDate = new DataColumn("Марка", typeof(String));
            _tblEU.Columns.Add(colDate);
            // colDate.Caption = "Марка";

            DataColumn colNomer = new DataColumn("Размер", typeof(String));
            // 
            _tblEU.Columns.Add(colNomer);
            //colNomer.Caption = "Размер";

            //DataColumn colS = new DataColumn("S", typeof(String));
            //_tblEU.Columns.Add(colS);

            //DataColumn colSTATUS = new DataColumn("STATUS", typeof(String));
            //_tblEU.Columns.Add(colSTATUS);
            DataColumn colN = new DataColumn("Label", typeof(String));
            _tblEU.Columns.Add(colN);

            DataColumn colV = new DataColumn("Вес", typeof(String));
            colV.DefaultValue = "-";
            _tblEU.Columns.Add(colV);

            dataGridEu.DataSource = _tblEU;
        }

        private void Search()
        {
            string searchText = textBoxScan.Text;
            //Для поиска
            if (searchText.Length < 3)
            {
                MessageBox.Show("Введите более 3-х символов");
                return;
            }

            _tblEU.Clear();
            //Тут запилим поиск
            //select EU.RELMUCH_LABEL, EU.RPRT_NOM,  EU.MARKA_NAME, EU.RELMUCH_THICKNESS, EU.RELMUCH_WIDTH  FROM EU WHERE EU.RPRT_NOM  LIKE '%325%'LIMIT 100
         
            using (SQLiteConnection connection = new SQLiteConnection())
            {

                //Тут делаем таблицу и выводим инфу



                ;//(SQLiteConnection)factory.CreateConnection();
                connection.ConnectionString = "Data Source = " + SqLiteDB.pathDBFull_EU;
                SQLiteCommand command = new SQLiteCommand(connection);
                SQLiteCommand insert = new SQLiteCommand("select EU.RELMUCH_LABEL, EU.RPRT_NOM,  EU.MARKA_NAME, EU.RELMUCH_THICKNESS, EU.RELMUCH_WIDTH, EU.RELMUCH_VES  FROM EU WHERE EU.RPRT_NOM  LIKE '%" + searchText + "%' LIMIT 100;", connection);
                connection.Open();
                SQLiteDataReader reader = insert.ExecuteReader();
                while (reader.Read())
                {
                    DataRow row1 = _tblEU.NewRow();
                    //Запроск К БД
                    row1["Label"] = SqlLiteQuery.getReaderByName(reader, "RELMUCH_LABEL");
                    row1["УЕ"] = SqlLiteQuery.getReaderByName(reader, "RPRT_NOM");
                    row1["Марка"] = SqlLiteQuery.getReaderByName(reader, "MARKA_NAME");
                    row1["Размер"] = SqlLiteQuery.getReaderByName(reader, "RELMUCH_THICKNESS") + "х" + SqlLiteQuery.getReaderByName(reader, "RELMUCH_WIDTH");
                    row1["Вес"] = SqlLiteQuery.getReaderByName(reader, "RELMUCH_VES");

                    _tblEU.Rows.Add(row1);
                    //listEU.Add(EU);
                }
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

            if (_tblEU.Rows.Count > 0)
            {
                dataGridEu.BeginInvoke(new Action(() =>
                {
                    dataGridEu.Select(0);
                }));

                SelectLabel = dataGridEu[dataGridEu.CurrentRowIndex, 3].ToString();
                SelectYE = dataGridEu[dataGridEu.CurrentRowIndex, 0].ToString();
                SelectMarka = dataGridEu[dataGridEu.CurrentRowIndex, 1].ToString();
                SelectRazmer = dataGridEu[dataGridEu.CurrentRowIndex, 2].ToString();

                //
                try
                {
                    SelectWeight = Double.Parse(dataGridEu[dataGridEu.CurrentRowIndex, 4].ToString());
                }

                catch (Exception) { }

            }
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void EUSearch_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                Search();

            }
            else if (e.KeyCode == Keys.F9)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridEu_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridEu.Select(dataGridEu.CurrentRowIndex);
                //Установим нужные значения

                SelectLabel = dataGridEu[dataGridEu.CurrentRowIndex, 3].ToString();
                SelectYE = dataGridEu[dataGridEu.CurrentRowIndex, 0].ToString();
                SelectMarka = dataGridEu[dataGridEu.CurrentRowIndex, 1].ToString();
                SelectRazmer = dataGridEu[dataGridEu.CurrentRowIndex, 2].ToString();

                //
                try
                {
                    SelectWeight = Double.Parse(dataGridEu[dataGridEu.CurrentRowIndex, 4].ToString());
                }

                catch (Exception) { }


            }
            catch (Exception ex)
            {

            }
        }
    }
}
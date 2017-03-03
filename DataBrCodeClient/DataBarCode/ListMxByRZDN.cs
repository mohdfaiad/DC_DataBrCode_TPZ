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
    public partial class ListMxByRZDN : Form
    {
        string RZDN;
        ListScanOperation Oper;
        public DataTable _tblEU;

        public ListMxByRZDN(string _RZDN, ListScanOperation _oper)
        {
            InitializeComponent();
            RZDN = _RZDN;
            Oper = _oper;

            switch (Oper)
            {
                case ListScanOperation.TaskPGA:
                    {///Задание для ПГА
                        InitTable();
                        initRZDNForPGA();
                        break;
                    }
             
            }
        }


        public void InitTable()
        {

            _tblEU = new DataTable("EU");

            DataColumn colDate = new DataColumn("Склад", typeof(String));
            colDate.DefaultValue = "-";
            _tblEU.Columns.Add(colDate);
            DataColumn colNomer = new DataColumn("MX", typeof(String));
            colNomer.DefaultValue = "-";
            _tblEU.Columns.Add(colNomer);
            DataColumn colSource = new DataColumn("УЕ", typeof(String));
            colSource.DefaultValue = "-";
            _tblEU.Columns.Add(colSource);
            dataGridEu.DataSource = _tblEU;
        }

        private void initRZDNForPGA()
        {
            using (SQLiteConnection connection = new SQLiteConnection())
            {

                string SQL = "SELECT EU.TEHUZ_KOD, EU.RPRT_NOM FROM EU,  TaskList, RZDN_MARKA WHERE EU.MARKA_NAME = RZDN_MARKA.MARKA AND EU.RELMUCH_THICKNESS = TaskList.TASK_THICKNESS AND EU.RELMUCH_WIDTH= TaskList.TASK_WIDTH AND TaskList.RZDN_PRM = '" + RZDN + "' AND RZDN_MARKA.RZDN_PRM = TaskList.RZDN_PRM AND EU.SIGN <> '2'";
                // SQL += "AND TaskList.RZDN_PRM = '" + RZDN + "'";

                /*
                 * SELECT EU.TEHUZ_KOD, EU.RPRT_NOM FROM EU,  TaskList, RZDN_MARKA WHERE 
EU.MARKA_NAME = RZDN_MARKA.MARKA 
AND EU.RELMUCH_THICKNESS = TaskList.TASK_THICKNESS 
AND EU.RELMUCH_WIDTH= TaskList.TASK_WIDTH
AND TaskList.RZDN_PRM = "234557"
AND RZDN_MARKA.RZDN_PRM = TaskList.RZDN_PRM
AND EU.SIGN <> "2"
                 * */

                ;//(SQLiteConnection)factory.CreateConnection();
                connection.ConnectionString = "Data Source = " + SqLiteDB.pathDBFull_EU;
                SQLiteCommand command = new SQLiteCommand(connection);
                SQLiteCommand insert = new SQLiteCommand(SQL, connection);
                connection.Open();
                SQLiteDataReader reader = insert.ExecuteReader();
                while (reader.Read())
                {
                    DataRow row1 = _tblEU.NewRow();
                    //Запроск К БД
                    string TEHUZ = SqlLiteQuery.getReaderByName(reader, "TEHUZ_KOD");
                    row1["УЕ"] = SqlLiteQuery.getReaderByName(reader, "RPRT_NOM");
                    row1["MX"] = SqlLiteQuery.GetNameMXByKod(TEHUZ, false);
                    row1["Склад"] = SqlLiteQuery.GetNameAgrByMX(TEHUZ);
                    _tblEU.Rows.Add(row1);

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
        }


        private void ListMxByRZDN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

        }



        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
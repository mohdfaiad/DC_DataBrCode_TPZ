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
    public partial class EU_Action : Form
    {
        public Intermec.DataCollection.BarcodeReader bcr;
        public string EU;
        Settings set;
        public EU_Action(Intermec.DataCollection.BarcodeReader _bcr, string _EU)
        {
            InitializeComponent();
            this.bcr = _bcr;
            this.EU = _EU;

            //Тут правим лейбл
            string StatusBD = "БД: " + SqLiteDB.UpdateDateTime + ". Операции: " + BufferToBD.CountBuffer;

            labelBD.BeginInvoke(new Action(() =>
            {
                labelBD.Text = StatusBD;
            }));


            set = new Settings("DataBrCode.xml");
            CLog.WriteInfo("EU_Action.cs", "EU: " + _EU);

            //Выполняем ассинхронный запрос к БД
            labelLabel.Text += " " + _EU;

            ///GetDataEU(_EU);

            GetDataEUSqlLite(EU);

//            OpenNETCF.WindowsMobile.
            this.KeyPreview = true;
        }

        private void GetDataEUSqlLite(string EU)
        {
            //Загружаем по новому
       
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection())
                {

                    ;//(SQLiteConnection)factory.CreateConnection();
                    connection.ConnectionString = "Data Source = " + SqLiteDB.pathDBFull_EU;
                    SQLiteCommand command = new SQLiteCommand(connection);
                    SQLiteCommand insert = new SQLiteCommand("select * from EU e WHERE e.RELMUCH_LABEL = '"+ EU +"';", connection);
                    connection.Open();
                    SQLiteDataReader reader = insert.ExecuteReader();
                    while (reader.Read())
                    {
                        lblID.Text = "ID: " + _getReaderByName(reader, "RELMUCH_PRM");
                        labelMark.Text = "Марка: " + _getReaderByName(reader, "MARKA_NAME");
                        labelPart.Text = "Партия: " + _getReaderByName(reader, "RPRT_NOM");
                        labelplav.Text = "Плавка: " + _getReaderByName(reader, "RPRT_PLVNOM");
                        labelUnitWegth.Text = "Вес факт: " + _getReaderByName(reader, "RELMUCH_FVES");
                        labelUnitWegthASUP.Text = "Вес АСУП: " + _getReaderByName(reader, "RELMUCH_VES");

                        string Tehuzx_kod = _getReaderByName(reader, "TEHUZ_KOD");

                        if (_getReaderByName(reader, "SIGN") == "1")
                        {
                            //EU.SIGN='1' - Факт
                            //EU.SIGN='2' - План
                            labelFactMX.Text = "Факт МХ: " + SqlLiteQuery.GetNameMXByKod(Tehuzx_kod);
                            labelPlanMX.Text = "План МХ: -";
                        }
                        else
                        {
                            labelFactMX.Text = "Факт МХ: -"; 
                            labelPlanMX.Text = "План МХ: " + SqlLiteQuery.GetNameMXByKod(Tehuzx_kod);;
                        }
                        
 
                    }
                    reader.Close();
                    connection.Close();

                    command.Dispose();
                    insert.Dispose();
                    reader.Dispose();
                }

  
            }

            catch (Exception ex)
            {
                CLog.WriteException("EU_Action.cs", "GetDataEUSqlLite", ex.Message);
            }
        }



        private string _getReaderByName(SQLiteDataReader rd, string NameF)
        {
            string tmp = "Нет данных";
            tmp = rd.GetValue(rd.GetOrdinal(NameF)).ToString();
            return tmp;

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EU_Action_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
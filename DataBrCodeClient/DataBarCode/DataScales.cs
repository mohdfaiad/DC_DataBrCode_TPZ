using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using Intermec.DataCollection;
using System.Diagnostics;
using System.Data.SQLite;
using System.Net;


namespace DataBarCode
{
    public partial class DataScales : Form
    {
        class CTCPClient
        {
            string _ip;
            Int32 _port;

            public CTCPClient(String ip, Int32 port)
            {
                _port = port;
                _ip = ip;
            }


            public string[] getDevice()
            {
                //Спрашиваем у сервера какие подключены устройства
                try
                {

                    TcpClient client = new TcpClient(_ip, _port);
                    NetworkStream stream = client.GetStream();

                    //Посылаем массив из 10 строк
                    String SendStr = "get_device";
                    for (int i = 0; i < 10; i++)
                    {
                        SendStr += "&";
                    }

                    Byte[] dataSend = Encoding.UTF8.GetBytes(SendStr);

                    stream.Write(dataSend, 0, dataSend.Length);
                    Byte[] data = new Byte[256];
                    String responseData = String.Empty;
                    string[] ResMsg = new string[10];// = new List<String>(10);

                    Int32 bytes = stream.Read(data, 0, data.Length);
                    responseData = Encoding.UTF8.GetString(data, 0, bytes);
                    ResMsg = responseData.Split('&');


                    // Close everything.
                    client.Close();
                    return ResMsg;

                }


                catch (Exception ex)
                {
                    CLog.WriteException("DataScales.cs", "getDevice", ex.Message);
                    return null;
                }



            }

            public string[] getData(string deviceName)
            {
                //Спрашиваем у сервера какие подключены устройства
                //try
                //{

                    TcpClient client = new TcpClient(_ip, _port);
                    NetworkStream stream = client.GetStream();

                    //Посылаем массив из 10 строк
                    String SendStr = "get_data" + "&" + deviceName;
                    for (int i = 0; i < 9; i++)
                    {
                        SendStr += "&";
                    }

                    Byte[] dataSend = Encoding.UTF8.GetBytes(SendStr);

                    stream.Write(dataSend, 0, dataSend.Length);
                    Byte[] data = new Byte[256];
                    String responseData = String.Empty;
                    string[] ResMsg = new string[10];// = new List<String>(10);

                    Int32 bytes = stream.Read(data, 0, data.Length);
                    responseData = Encoding.UTF8.GetString(data, 0, bytes);
                    ResMsg = responseData.Split('&');


                    // Close everything.
                    client.Close();
                    return ResMsg;

              //  }


              //  catch (Exception ex)
               // {
               //     CLog.WriteException("DataScales.cs", "getData", ex.Message);
                   // return null;
               // }



            }

        }


        public Intermec.DataCollection.BarcodeReader bcr;

        DataTable _TblScales = null;

        Settings set;
        public string SelectedScales = null;
        //public CTCPClient _client = null;
        private bool GetDataScales = false;
        private Thread GetDataScalesThread = null;
        public string LabelEU;
        public string UnitWeght;
        // public delegate void GetDataDelegate();

        public DataScales(Intermec.DataCollection.BarcodeReader _bcr)
        {
            InitializeComponent();
            CLog.WriteInfo("DataScales.cs", "Start Ui");
            set = new Settings("DataBrCode.xml");

            bcr = _bcr;

            InitScaner();

            _TblScales = SqlLiteQuery.GetScales();

            if (_TblScales != null)
            {
                comboBoxScales.DataSource = _TblScales;
                comboBoxScales.DisplayMember = "VESY_NAME";
                comboBoxScales.ValueMember = "VESY_NOM";
                // comboBoxAgr.SelectedIndex = -1;
                if (comboBoxScales.Items.Count > 0)
                {
                    comboBoxScales.SelectedIndex = -1;
                   // buttonFix.Enabled = true;
                    comboBoxScales.DropDownStyle = ComboBoxStyle.DropDownList;
                }
                else
                {
                    buttonFix.Enabled = false;

                }
            }


            LabelEU = null;

            GetDataScales = true;
            GetDataScalesThread = new Thread(ThreadGetDataScales);
            GetDataScalesThread.Start();

            buttonFix.Enabled = false;

            //Тут правим лейбл
            string StatusBD = StatusBar.getSatus();

            labelBD.BeginInvoke(new Action(() =>
            {
                labelBD.Text = StatusBD;
            }));
            this.KeyPreview = true;
        }



        private void InitScaner()
        {

            if (bcr == null)
                bcr = new BarcodeReader();
            //set BarcodeRead event
            bcr.BarcodeRead += new BarcodeReadEventHandler(bcr_BarcodeRead);
            //sends the BarcodeRead event after each successful read
            bcr.ThreadedRead(true);
            bcr.symbology.Code128.Enable = false;
            //set Interleaved 2 of 5
            bcr.symbology.Interleaved2Of5.Enable = false;
            //set PDF417
            bcr.symbology.Pdf417.Enable = false;
            bcr.symbology.QrCode.Enable = false;
        }

        void bcr_BarcodeRead(object sender, BarcodeReadEventArgs bre)
        {

            try
            {
                string EU = bre.strDataBuffer;
                LabelEU = EU;
                ///Тут Алгоритм разбора что мы все-таки считали
                ///Для начала считаем по-умолчанию что считываем мы только ЕУ и пишем алгоритм
                ///Открытия формы

                labelLabel.BeginInvoke(new Action(() =>
                {
                    labelLabel.Text = "Label: " + EU;
                }));



                //GetDataEU(EU);
                GetDataEUSqlLite(EU);

            }
            catch (Exception exp)
            {
                CLog.WriteException("DataScales.cs", "bcr_BarcodeRead", exp.Message);
                //MessageBox.Show(exp.Message);
            }

        }

        void UpdateSqlLiteWeigth(string RELMUCH_LABEL, string weigth)
        {

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection())
                {

                    ;//(SQLiteConnection)factory.CreateConnection();
                    connection.ConnectionString = "Data Source = " + SqLiteDB.pathDBFull_EU;
                    SQLiteCommand command = new SQLiteCommand(connection);
                    SQLiteCommand insert = new SQLiteCommand("UPDATE EU SET RELMUCH_FVES = '" + weigth + "'  WHERE EU.RELMUCH_LABEL = '" + RELMUCH_LABEL + "';", connection);
                    connection.Open();
                    insert.ExecuteNonQuery();

                    connection.Close();
                }
            }

            catch (Exception ex)
            {


            }
        }

        private void GetDataEUSqlLite(string EU)
        {
            lblID.BeginInvoke(new Action(() =>
            {
                lblID.Text = "ID: ";
            }));

            labelMark.BeginInvoke(new Action(() =>
            {
                labelMark.Text = "Марка: ";
            }));

            labelPart.BeginInvoke(new Action(() =>
            {
                labelPart.Text = "Партия: ";
            }));

            labelplav.BeginInvoke(new Action(() =>
            {
                labelplav.Text = "Плавка: ";
            }));

            labelUnitWegth.BeginInvoke(new Action(() =>
            {
                labelUnitWegth.Text = "Вес: ";
            }));

            //Загружаем по новому
       
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection())
                {

                    ;//(SQLiteConnection)factory.CreateConnection();
                    connection.ConnectionString = "Data Source = " + SqLiteDB.pathDBFull_EU;
                    SQLiteCommand command = new SQLiteCommand(connection);
                    SQLiteCommand insert = new SQLiteCommand("select * from EU e WHERE e.RELMUCH_LABEL = '" + EU + "';", connection);
                    connection.Open();
                    SQLiteDataReader reader = insert.ExecuteReader();

                    while (reader.Read())
                    {
                        /*
                         * CREATE TABLE [EU] (
                                    [RELMUCH_LABEL] char(20) NOT NULL,
                                    [RELMUCH_PRM] char(20),
                                    [RELMUCH_VES] char(20),
                                    [RELMUCH_FVES] char(20),
                                    [RELMUCH_WIDTH] char(20),
                                    [RELMUCH_THICKNESS] char(20),
                                    [RPRT_NOM] char(20),
                                    [RPRTTYP_NAME] char(20),
                                    [RPRT_TOL] char(20),
                                    [RPRT_SHRN] char(20),
                                    [RPRT_PLVNOM] char(20),
                                    [MARKA_NAME] char(20),
                                    [MARKA_GOST] char(20),
                                    [FACT_STORAGE_CODE] char(20),
                                    [TEHUZ_LABEL] char(20),
                                    [FACT_PLACE_NAME] char(20),
                                    [INTRV_TMBEG] char(20))
                         * */
                        //lblID.Text = "ID: " + _getReaderByName(reader, "RELMUCH_PRM");
                        //labelMark.Text = "Марка: " + _getReaderByName(reader, "MARKA_NAME");
                        //labelPart.Text = "Партия: " + _getReaderByName(reader, "RPRT_NOM");
                        //labelplav.Text = "Плавка: " + _getReaderByName(reader, "RPRT_PLVNOM");
                        //labelUnitWegth.Text = "Вес: " + _getReaderByName(reader, "RELMUCH_FVES");
                        string id = _getReaderByName(reader, "RELMUCH_PRM");
                        string MARKA_NAME = _getReaderByName(reader, "MARKA_NAME");
                        string RPRT_NOM = _getReaderByName(reader, "RPRT_NOM");
                        string RPRT_PLVNOM = _getReaderByName(reader, "RPRT_PLVNOM");
                        string RELMUCH_FVES = _getReaderByName(reader, "RELMUCH_FVES");

                        lblID.BeginInvoke(new Action(() =>
                        {
                            lblID.Text = "ID: " + id;
                        }));

                        labelMark.BeginInvoke(new Action(() =>
                        {
                            labelMark.Text = "Марка: " + MARKA_NAME;
                        }));

                        labelPart.BeginInvoke(new Action(() =>
                        {
                            labelPart.Text = "Партия: " + RPRT_NOM;
                        }));

                        labelplav.BeginInvoke(new Action(() =>
                        {
                            labelplav.Text = "Плавка: " + RPRT_PLVNOM;
                        }));

                        labelUnitWegth.BeginInvoke(new Action(() =>
                        {
                            labelUnitWegth.Text = "Вес: " + RELMUCH_FVES;
                        }));
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
                CLog.WriteException("DataScales.cs", "GetDataEUSqlLite", ex.Message);
            }
        }

        public string _getReaderByName(SQLiteDataReader rd, string NameF)
        {
            string tmp = "Нет данных";
            tmp = rd.GetValue(rd.GetOrdinal(NameF)).ToString();
            return tmp;

        }

        private void ThreadGetDataScales()
        {
            DataBarCode.CLog.WriteInfo("DataScales.cs", "Start Thread Get DataScales");
            CTCPClient _client = new CTCPClient(set.DataScalesServerIp, set.DataScalesServerPort);

            while (GetDataScales)
            {
                try
                {
                    if (SelectedScales != null)
                    {



                        string[] data = _client.getData(SelectedScales);

                        buttonFix.BeginInvoke(new Action(() =>
                        {
                            buttonFix.Enabled = true;
                        }));


                        if (data != null)
                        {
                            string Weigth = data[2];
                            bool Stabl = bool.Parse(data[4]);
                            //CLog.WriteInfo("DataScales.cs", "Пришел вес: " + Weigth + " ;Стаб: " + Stabl.ToString());

                            labelWeigth.BeginInvoke(new Action(() =>
                            {
                                labelWeigth.Text = Weigth;
                                if (Stabl)
                                {
                                    labelWeigth.ForeColor = Color.White;
                                }
                                else
                                {
                                    labelWeigth.ForeColor = Color.Tomato;
                                }
                            }));

                        }
                    }
                }

                catch (SocketException exp)
                {
                    CLog.WriteException("DataScales.cs", "ThreadGetDataScales_SocketException", exp.Message);

                    labelWeigth.BeginInvoke(new Action(() =>
                    {
                        labelWeigth.Text = "Нет связи";
                        labelWeigth.ForeColor = Color.Tomato;
                    }));

                    buttonFix.BeginInvoke(new Action(() =>
                    {
                        buttonFix.Enabled = false;
                    }));
                    Thread.Sleep(set.DataScalesServerTime * 5);
                }

                catch (Exception exp)
                {
                    CLog.WriteException("DataScales.cs", "ThreadGetDataScales", exp.Message);

                    labelWeigth.BeginInvoke(new Action(() =>
                    {
                        labelWeigth.Text = "Ошибка";
                        labelWeigth.ForeColor = Color.Tomato;
                    }));

                    buttonFix.BeginInvoke(new Action(() =>
                    {
                        buttonFix.Enabled = false;
                    }));

                }
                Thread.Sleep(set.DataScalesServerTime);
            }
            CLog.WriteInfo("DataScales.cs", "Stop Thread Get DataScales");
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {


        }

        private void comboBoxScales_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxScales.SelectedIndex != -1)
                SelectedScales = comboBoxScales.SelectedValue.ToString();
            else SelectedScales = null;

            ///?????
        }



        public string getValueDataTableColumn(DataTable tbl, string NameCol)
        {
            if (tbl.Rows.Count > 0)
                return tbl.Rows[0][NameCol].ToString();
            else return "Нет данных";
        }

        private void buttonFix_Click(object sender, EventArgs e)
        {//Фиксируем вес.

            //  LabelEU = labelLabel.Text;

            //Логика, отправляем в БД, и снвоа запрашиваем ЛБЛ
            labelStatus.BeginInvoke(new Action(() =>
            {
                labelStatus.Text = "Фиксация веса. Ожидание ответа от БД";
            }));


            FixedWigthUnit(LabelEU, SelectedScales, labelWeigth.Text);
            //Запускаем процесс обновления как то так
            // GetDataEU(labelLabel.Text);
        }


        public void FixedWigthUnit(string Label, string UnitScales, string UnitWeght)
        {

            try
            {
                UnitWeght = (Double.Parse(UnitWeght) / 1000).ToString();
            }
            catch (Exception)
            {
            }

            this.UnitWeght = UnitWeght;
            WebReference.WebSDataBrCode BrServer = new WebReference.WebSDataBrCode();
            BrServer.SoapVersion = System.Web.Services.Protocols.SoapProtocolVersion.Soap12;
            BrServer.Url = set.AdressAppServer;
            BrServer.BrHeaderValue = CBrHeader.GetHeader();
            BrServer.Credentials = new NetworkCredential(CBrHeader.Login, CBrHeader.Password);
            BrServer.BeginFixedWeight(Label, UnitScales, UnitWeght, AsyncCallFixedWeight, BrServer);
        }

        public void AsyncCallFixedWeight(IAsyncResult res)
        {

            try
            {
                WebReference.WebSDataBrCode BrServer = res.AsyncState as WebReference.WebSDataBrCode;
                String result = BrServer.EndFixedWeight(res);
                if (result == "1")
                {
                    labelStatus.BeginInvoke(new Action(() =>
                    {
                        labelStatus.Text = "Фиксация веса произведена успешно";
                    }));
                    CLog.WriteInfo("DataScales.cs", "Fixed: " + result);
                    //GetDataEU(LabelEU);
                    //тут апдейтнем локальную БД
                    UpdateSqlLiteWeigth(LabelEU, this.UnitWeght);

                    //Делаем перезапрос
                    GetDataEUSqlLite(LabelEU);

                    //Вывести сообщение что вес успешно обновлен
                }
                else
                {
                    labelStatus.BeginInvoke(new Action(() =>
                    {
                        labelStatus.Text = "Ошибка фиксации: " + result;
                    }));
                    CLog.WriteInfo("DataScales.cs", "Fixed: " + result);

                }

            }

            catch (Exception ex)
            {
                CLog.WriteException("DataScales.cs", "AsyncCallFixedWeight", ex.Message);
            }

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GetDataScales = false;
            GetDataScalesThread.Abort();

            bcr.BarcodeRead -= new BarcodeReadEventHandler(bcr_BarcodeRead);

            CLog.WriteInfo("DataScales.cs", "Close UI Form");
            this.Close();
        }

        private void DataScales_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                try
                {
                    GetDataScales = false;
                    GetDataScalesThread.Abort();

                }
                catch (Exception ex) { }
                bcr.BarcodeRead -= new BarcodeReadEventHandler(bcr_BarcodeRead);

                CLog.WriteInfo("DataScales.cs", "Close UI Form");
                this.Close();
            }
            else if (e.KeyCode == Keys.F16)
            {
                bool rezult = ScreenShot.MakeShot("DataScales");
                if (rezult)
                    MessageBox.Show("Снимок успешно сохранен", "ScreenShot", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                else
                    MessageBox.Show("Ошибка сохранения", "ScreenShot", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);

            }
        }
    }
}
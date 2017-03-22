﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Intermec.DataCollection;
using System.Data.SQLite;
using System.Threading;
using System.Net;
using GridSample;

namespace DataBarCode
{
    public partial class WarehousePost : Form
    {
        public string LoginUser;
        public Intermec.DataCollection.BarcodeReader bcr;
        public string LabelEU;
        public string labelPlace;
        public DataTable _tblEU;
        Settings set;
        public bool FormActive;
        public List<string> listEU = null;
        public ListScanOperation ScanOperation;
        public string SETRZDN { get; set; }
        // public BarcodeReadEventHandler _returnFunc;


        public WarehousePost(Intermec.DataCollection.BarcodeReader _bcr, string LabelPlace, ListScanOperation _ScanOperation)
        {
            InitializeComponent();
            InitForms(_bcr, LabelPlace, _ScanOperation);
        }

        public WarehousePost(Intermec.DataCollection.BarcodeReader _bcr, string LabelPlace, ListScanOperation _ScanOperation, string FixWeigth)
        {
            InitializeComponent();
           // InitForms(_bcr, LabelPlace, _ScanOperation);
            FormActive = true;
            labelMXMore.Text = "Ст-1";
            labelMX.Text = "Фикс. вес: " + FixWeigth;
            InitTable();
            this.KeyPreview = true;
            labelCountScan.Text = "0";
            listEU = new List<string>();
        }
        public void InitForms(Intermec.DataCollection.BarcodeReader _bcr, string LabelPlace, ListScanOperation _ScanOperation)
        {

            FormActive = true;
            set = new Settings("DataBrCode.xml");

            ScanOperation = _ScanOperation;
            listEU = new List<string>();

            bcr = _bcr;

            this.labelPlace = LabelPlace;
            InitTable();
            InitScaner();

            labelMX.Text = LabelPlace;

            //Выгрузим подробную инфу по месту хранения 
            //labelMXMore.Text = getValueDataTableColumnRow(_TblWarehouse, "TEHUZ_LABEL", LabelPlace, "TEHUZ_NAME");
            if (LabelPlace == "MX0000")
                labelMXMore.Text = "ТЭСА";
            else
                labelMXMore.Text = SqlLiteQuery.GetNameMX(LabelPlace);




            //Тут правим лейбл
            string StatusBD = "БД: " + SqLiteDB.UpdateDateTime + ". Операции: " + BufferToBD.CountBuffer;

            labelBD.BeginInvoke(new Action(() =>
            {
                labelBD.Text = StatusBD;
            }));
            this.KeyPreview = true;



            switch (ScanOperation)
            {
                case ListScanOperation.MXSet:
                    {
                        this.Text = "Размещение ЕУ";
                        break;
                    }


                case ListScanOperation.EUTaskMove:
                    {
                        this.Text = "Перемещение ЕУ";
                        break;
                    }

                case ListScanOperation.EuInAgr:
                    {
                        this.Text = "ЕУ в агрегат";
                        break;
                    }

                case ListScanOperation.InventoryTask:
                    {
                        this.Text = "Инвентаризация МХ: " + labelMXMore.Text;
                        break;
                    }

            }
            labelCountScan.Text = "0";
        }

        public void InitTable()
        {

            _tblEU = new DataTable("EU");



            DataColumn colSource = new DataColumn("УЕ", typeof(String));
            colSource.DefaultValue = "-";
            _tblEU.Columns.Add(colSource);
            // colSource.Caption = "Партия";
            DataColumn colDate = new DataColumn("Марка", typeof(String));
            colDate.DefaultValue = "-";
            _tblEU.Columns.Add(colDate);
            // colDate.Caption = "Марка";


            DataColumn colV = new DataColumn("Вес", typeof(String));
            colV.DefaultValue = "-";
            _tblEU.Columns.Add(colV);

            DataColumn colNomer = new DataColumn("Размер", typeof(String));
            colNomer.DefaultValue = "-";
            // 
            _tblEU.Columns.Add(colNomer);

            DataColumn colN = new DataColumn("Label", typeof(String));
            colN.DefaultValue = "-";
            _tblEU.Columns.Add(colN);

            DataColumn colCommit = new DataColumn("Commit", typeof(String));
            colCommit.DefaultValue = "-1";
            _tblEU.Columns.Add(colCommit);
            //colNomer.Caption = "Размер";

            //DataColumn colS = new DataColumn("S", typeof(String));
            //_tblEU.Columns.Add(colS);


            //DataColumn colSTATUS = new DataColumn("STATUS", typeof(String));
            //_tblEU.Columns.Add(colSTATUS);

            

            /*
             * 
             * */
            CreateColumn("УЕ", "УЕ", 180, 0);
            CreateColumn("Марка", "Марка", 120, 1);
            CreateColumn("Вес", "Вес", 100, 2);
            CreateColumn("Размер", "Размер", 140, 3);
            CreateColumn("Label", "Label", 400, 4);

            dataGridEu.DataSource = _tblEU;
        }

        public void CreateColumn(string HeaderText, string MappingName, int Width, int Pos)
        {

            ColumnStyle GridSelectCoulmn;
            GridSelectCoulmn = new ColumnStyle(Pos);
            GridSelectCoulmn.NullText = "-";
            GridSelectCoulmn.HeaderText = HeaderText;
            GridSelectCoulmn.MappingName = MappingName;
            GridSelectCoulmn.Width = Width;
            GridSelectCoulmn.CheckCellEven += new CheckCellEventHandler(AnalizColorTable);

            dataGridTableStyle1.GridColumnStyles.Add(GridSelectCoulmn);

        }

        //}
        public void AnalizColorTable(object sender, DataGridEnableEventArgs e)
        {
            try
            {
                //Внедрим новое условие проверки
                string Label = (string)dataGridEu[e.Row, 4];
                //Для этой НУ найдем в таблице соответсвие и выделим как стоит
                e.PaintColor = false;

                for (int i = 0; i < _tblEU.Rows.Count; i++)
                {

                    if (Label == _tblEU.Rows[i]["Label"].ToString())
                    {
                        //Если это нужная
                        if (_tblEU.Rows[i]["Commit"].ToString() == "1")
                        {
                            e.PaintColor = true;
                            e.ColorRows = new SolidBrush(Color.MediumAquamarine);
                            break;
                        }

                        else if (_tblEU.Rows[i]["Commit"].ToString() == "2")
                        {
                            e.PaintColor = true;
                            e.ColorRows = new SolidBrush(Color.LightBlue);
                            break;
                        }

                        else if (_tblEU.Rows[i]["Commit"].ToString() == "0")
                        {
                            e.PaintColor = true;
                            e.ColorRows = new SolidBrush(Color.Tomato);
                            break;
                        }

                        else if (_tblEU.Rows[i]["Commit"].ToString() == "-1")
                        {
                            e.PaintColor = true;
                            e.ColorRows = new SolidBrush(Color.WhiteSmoke);
                            break;
                        }

                        else if (_tblEU.Rows[i]["Commit"].ToString() == "3")
                        {
                            e.PaintColor = true;
                            e.ColorRows = new SolidBrush(Color.LemonChiffon);
                            break;
                        }
                    }

                }

            }

            catch (Exception)
            {
                e.MeetsCriteria = false;
            }
        }

        public string getValueDataTableColumnRow(DataTable tbl, string NameCol, string ValueRow, string ReturnCol)
        {
            if (tbl.Rows.Count > 0)
            {
                for (int i = 0; i < tbl.Rows.Count; i++)
                {
                    if (tbl.Rows[i][NameCol].ToString() == ValueRow)
                        return tbl.Rows[i][ReturnCol].ToString();
                }

                return "Нет данных";
            }

            else return "Нет данных";
        }


        private void InitScaner()
        {

            if (bcr == null)
                bcr = new BarcodeReader();
            //set BarcodeRead event
            bcr.BarcodeRead += new BarcodeReadEventHandler(bcr_BarcodeReadWarehousePost);
            //sends the BarcodeRead event after each successful read
            bcr.ThreadedRead(true);
            bcr.symbology.Code128.Enable = false;
            //set Interleaved 2 of 5
            bcr.symbology.Interleaved2Of5.Enable = false;
            //set PDF417
            bcr.symbology.Pdf417.Enable = false;
            bcr.symbology.QrCode.Enable = false;
        }


        //public void TestAdd(string EU)
        //{


        //    try
        //    {
        //        LabelEU = EU;
        //        ///Тут Алгоритм разбора что мы все-таки считали
        //        ///Для начала считаем по-умолчанию что считываем мы только ЕУ и пишем алгоритм
        //        ///Открытия формы

        //        if (EU.IndexOf("MX") == 0)
        //        {//
        //            //labelStatus.BeginInvoke(new Action(() =>
        //            //{
        //            //    labelStatus.Text = "Считано место хранения: " + EU;
        //            //}));
        //            return;
        //        }

        //        //labelStatus.BeginInvoke(new Action(() =>
        //        //{
        //        //    labelStatus.Text = "Label: " + EU;
        //        //}));

        //        //MessageBox.Show(EU);

        //        // GetDataEU(EU);


        //        dataGridEu.BeginInvoke(new Action(() =>
        //        {
        //            dataGridEu.BackColor = Color.White;
        //        }));

        //        //Тут делаем таблицу и выводим инфу
        //        DataRow row1 = _tblEU.NewRow();
        //        row1["Label"] = EU;


        //        //WebReference.WebSDataBrCode BrServer = new WebReference.WebSDataBrCode();
        //        //BrServer.SoapVersion = System.Web.Services.Protocols.SoapProtocolVersion.Soap12;
        //        //BrServer.Url = set.AdressAppServer;
        //        //DataTable result = BrServer.EU_GetData(EU);
            

        //        using (SQLiteConnection connection = new SQLiteConnection())
        //        {

        //            ;//(SQLiteConnection)factory.CreateConnection();
        //            connection.ConnectionString = "Data Source = " + SqLiteDB.pathDBFull_EU;
        //            SQLiteCommand command = new SQLiteCommand(connection);
        //            SQLiteCommand insert = new SQLiteCommand("select e.RPRT_NOM, e.MARKA_NAME, e.RELMUCH_THICKNESS, e.RELMUCH_WIDTH from EU e WHERE e.RELMUCH_LABEL = '" + EU + "';", connection);
        //            connection.Open();
        //            SQLiteDataReader reader = insert.ExecuteReader();
        //            while (reader.Read())
        //            {
        //                //Запроск К БД
        //                row1["УЕ"] = _getReaderByName(reader, "RPRT_NOM");
        //                row1["Марка"] = _getReaderByName(reader, "MARKA_NAME");
        //                row1["Размер"] = _getReaderByName(reader, "RELMUCH_THICKNESS") + "х" + _getReaderByName(reader, "RELMUCH_WIDTH");
        //                // row1["S"] = "";
        //                /*
        //                 * CREATE TABLE [EU] (
        //                            [RELMUCH_LABEL] char(20) NOT NULL,
        //                            [RELMUCH_PRM] char(20),
        //                            [RELMUCH_VES] char(20),
        //                            [RELMUCH_FVES] char(20),
        //                            [RELMUCH_WIDTH] char(20),
        //                            [RELMUCH_THICKNESS] char(20),
        //                            [RPRT_NOM] char(20),
        //                            [RPRTTYP_NAME] char(20),
        //                            [RPRT_TOL] char(20),
        //                            [RPRT_SHRN] char(20),
        //                            [RPRT_PLVNOM] char(20),
        //                            [MARKA_NAME] char(20),
        //                            [MARKA_GOST] char(20),
        //                            [FACT_STORAGE_CODE] char(20),
        //                            [TEHUZ_LABEL] char(20),
        //                            [FACT_PLACE_NAME] char(20),
        //                            [INTRV_TMBEG] char(20))
        //                 * */
        //            }
        //            reader.Close();
        //            connection.Close();
        //            command.Dispose();
        //            insert.Dispose();
        //            reader.Dispose();
        //        }




        //        _tblEU.Rows.Add(row1);

        //        listEU.Add(EU);

        //        labelCountScan.Text = listEU.Count.ToString();

        //        dataGridEu.BeginInvoke(new Action(() =>
        //        {
        //            dataGridEu.DataSource = _tblEU;
        //        }));


        //    }
        //    catch (Exception exp)
        //    {
        //        CLog.WriteException("WarehousePost.cs", "TestAdd", exp.Message);
        //        MessageBox.Show(exp.Message);
        //    }
        //}

        void bcr_BarcodeReadWarehousePost(object sender, BarcodeReadEventArgs bre)
        {

            try
            {
                string EU = bre.strDataBuffer;
                LabelEU = EU;
                ///Тут Алгоритм разбора что мы все-таки считали
                ///Для начала считаем по-умолчанию что считываем мы только ЕУ и пишем алгоритм
                ///Открытия формы

                if (EU.IndexOf("MX") == 0)
                {//
                    //labelStatus.BeginInvoke(new Action(() =>
                    //{
                    //    labelStatus.Text = "Считано место хранения: " + EU;
                    //}));
                    return;
                }

                //Проверим есть ли данная ЕУ в списке
                if (ValidateList.CheckEUByList(listEU, LabelEU))
                {
                    //ЕУ уже в списке
                    Sound.PlaySoundWarning();
                    //Vibration.PlayVibration(2000);
                    return;
                }



                dataGridEu.BeginInvoke(new Action(() =>
                {
                    dataGridEu.BackColor = Color.White;
                }));

                //Тут делаем таблицу и выводим инфу
                DataRow row1 = _tblEU.NewRow();
                row1["Label"] = EU;


                //WebReference.WebSDataBrCode BrServer = new WebReference.WebSDataBrCode();
                //BrServer.SoapVersion = System.Web.Services.Protocols.SoapProtocolVersion.Soap12;
                //BrServer.Url = set.AdressAppServer;
                //DataTable result = BrServer.EU_GetData(EU);
     

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
                        //Запроск К БД
                        row1["УЕ"] = _getReaderByName(reader, "RPRT_NOM");
                        row1["Марка"] = _getReaderByName(reader, "MARKA_NAME");
                        row1["Размер"] = _getReaderByName(reader, "RELMUCH_THICKNESS") + "х" + _getReaderByName(reader, "RELMUCH_WIDTH");
                        row1["Вес"] = SqlLiteQuery.getReaderByName(reader, "RELMUCH_VES");
                        // row1["S"] = "";
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
                    }
                    reader.Close();
                    connection.Close();

                    command.Dispose();
                    insert.Dispose();
                    reader.Dispose();
                }
                _tblEU.Rows.InsertAt(row1, 0);

                listEU.Add(EU);
                labelCountScan.BeginInvoke(new Action(() =>
                {
                    labelCountScan.Text = listEU.Count.ToString();
                }));

                dataGridEu.BeginInvoke(new Action(() =>
                {
                    dataGridEu.DataSource = _tblEU;
                }));


            }
            catch (Exception exp)
            {
                CLog.WriteException("WarehousePost.cs", "bcr_BarcodeReadWarehousePost", exp.Message);
                //MessageBox.Show(exp.Message);
            }

        }

        public string getValueDataTableColumn(DataTable tbl, string NameCol)
        {
            if (tbl.Rows.Count > 0)
                return tbl.Rows[0][NameCol].ToString();
            else return "Нет данных";
        }



        public string _getReaderByName(SQLiteDataReader rd, string NameF)
        {
            string tmp = "Нет данных";
            try
            {
                tmp = rd.GetValue(rd.GetOrdinal(NameF)).ToString();
                return tmp;
            }

            catch (Exception)
            {
                return tmp;
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void SetMXSet()
        {
            DateTime NowTime = DateTime.Now;

            WebReference.WebSDataBrCode BrServer = new WebReference.WebSDataBrCode();
            BrServer.SoapVersion = System.Web.Services.Protocols.SoapProtocolVersion.Soap12;
            BrServer.Url = set.AdressAppServer;
            BrServer.BrHeaderValue = CBrHeader.GetHeader();
            BrServer.Credentials = new NetworkCredential(CBrHeader.Login, CBrHeader.Password);
            if (BufferToBD.ModeNetTerminalB)
            {//Если мы в Онлайне
                try
                {
                    //Перед запросом сбросим все
                    for (int ii = 0; ii < _tblEU.Rows.Count; ii++)
                    {
                        _tblEU.Rows[ii]["Commit"] = "-1";
                    }

                    DataTable result = BrServer.POST_EU_LIST_Warehouse(listEU.ToArray(), labelPlace, null);

                   // dataGridEu.BackColor = Color.MediumAquamarine;
                    OpenNETCF.Media.SystemSounds.Beep.Play();

                    ////Далее нужен алгоритм обработки ответа
                    //Парсим ответ, и выставляем биты..
                    for (int i = 0; i < result.Rows.Count; i++)
                    {
                        string Label = result.Rows[i]["Label"].ToString();
                        string RCode = result.Rows[i]["resultCode"].ToString();
                        for (int ii = 0; ii < _tblEU.Rows.Count; ii++)
                            {
                                string LabelScan = _tblEU.Rows[ii]["Label"].ToString();
                                string RCodeScan = _tblEU.Rows[ii]["Commit"].ToString();
                                if (RCodeScan == "-1") 
                                {//Не смотрим уже измененные
                                    if (LabelScan == Label) //Поиск по лейблу
                                        _tblEU.Rows[ii]["Commit"] = RCode;
                                }

                            }

                        if (RCode == "0") 
                        {
                            string RCodeEx = result.Rows[i]["result"].ToString();
                            //Запишем все в логи...
                            CLog.WriteException("WarehousePost.cs", "SetMXSet", "Label: " + Label + " resultCode: " + RCode + " result: " + RCodeEx);
                        }
                    }

                    dataGridEu.BeginInvoke(new Action(() =>
                    {
                        dataGridEu.DataSource = _tblEU;
                    }));

                }

                catch (System.Net.WebException ex)
                {
                    dataGridEu.BackColor = Color.LemonChiffon;

                    BufferToBD.ModeNetTerminalB = false;
                    CLog.WriteException("WarehousePost.cs", "buttonNext_Click_1", ex.ToString());
                    //Отправляем в буфер
                    BufferOper_POST_EU_LIST_Warehouse Oper = new BufferOper_POST_EU_LIST_Warehouse(labelPlace, listEU.ToArray());
                    BufferToBD.BufferAdd(new BufferOperation(TypeClassBuffer.POST_EU_LIST_Warehouse, Oper));
                    OpenNETCF.Media.SystemSounds.Beep.Play();
                    Thread.Sleep(100);
                    OpenNETCF.Media.SystemSounds.Beep.Play();

                    //Меняем статус на желтый 
                    for (int ii = 0; ii < _tblEU.Rows.Count; ii++)
                    {
                        _tblEU.Rows[ii]["Commit"] = "3";
                    }

                    dataGridEu.BeginInvoke(new Action(() =>
                    {
                        dataGridEu.DataSource = _tblEU;
                    }));
                }

                catch (System.Net.Sockets.SocketException ex)
                {//На случай если во время выполнения сломается связть 

                    dataGridEu.BackColor = Color.LemonChiffon;

                    BufferToBD.ModeNetTerminalB = false;
                    CLog.WriteException("WarehousePost.cs", "buttonNext_Click_1", ex.ToString());
                    //Отправляем в буфер
                    BufferOper_POST_EU_LIST_Warehouse Oper = new BufferOper_POST_EU_LIST_Warehouse(labelPlace, listEU.ToArray());
                    BufferToBD.BufferAdd(new BufferOperation(TypeClassBuffer.POST_EU_LIST_Warehouse, Oper));
                    OpenNETCF.Media.SystemSounds.Beep.Play();
                    Thread.Sleep(100);
                    OpenNETCF.Media.SystemSounds.Beep.Play();

                    //Меняем статус на желтый 
                    for (int ii = 0; ii < _tblEU.Rows.Count; ii++)
                    {
                        _tblEU.Rows[ii]["Commit"] = "3";
                    }

                    dataGridEu.BeginInvoke(new Action(() =>
                    {
                        dataGridEu.DataSource = _tblEU;
                    }));
                }
            }
            else
            {//Если мы в Офлайне
                BufferOper_POST_EU_LIST_Warehouse Oper = new BufferOper_POST_EU_LIST_Warehouse(labelPlace, listEU.ToArray());
                BufferToBD.BufferAdd(new BufferOperation(TypeClassBuffer.POST_EU_LIST_Warehouse, Oper));

                dataGridEu.BackColor = Color.LemonChiffon;
                OpenNETCF.Media.SystemSounds.Beep.Play();
                Thread.Sleep(100);
                OpenNETCF.Media.SystemSounds.Beep.Play();

                //Меняем статус на желтый 
                for (int ii = 0; ii < _tblEU.Rows.Count; ii++)
                {
                    _tblEU.Rows[ii]["Commit"] = "3";
                }

                dataGridEu.BeginInvoke(new Action(() =>
                {
                    dataGridEu.DataSource = _tblEU;
                }));

            }
            //Анализируем результат, и подсветку делаем строк
        }

        private void TaskMove()
        {

            WebReference.WebSDataBrCode BrServer = new WebReference.WebSDataBrCode();
            BrServer.SoapVersion = System.Web.Services.Protocols.SoapProtocolVersion.Soap12;
            BrServer.Url = set.AdressAppServer;
            BrServer.Credentials = new NetworkCredential(CBrHeader.Login, CBrHeader.Password);
            BrServer.BrHeaderValue = CBrHeader.GetHeader();
            if (BufferToBD.ModeNetTerminalB)
            {//Если мы в Онлайне
                try
                {
                    DataTable result = BrServer.POST_EU_TASK_MOVE(listEU.ToArray(), labelPlace, null);

                    dataGridEu.BackColor = Color.MediumAquamarine;
                    OpenNETCF.Media.SystemSounds.Beep.Play();

                    //Меняем статус на нужный 
                    for (int ii = 0; ii < _tblEU.Rows.Count; ii++)
                    {
                        _tblEU.Rows[ii]["Commit"] = "1";
                    }

                    dataGridEu.BeginInvoke(new Action(() =>
                    {
                        dataGridEu.DataSource = _tblEU;
                    }));
                }

                catch (System.Net.WebException ex)
                {
                    dataGridEu.BackColor = Color.LemonChiffon;

                    BufferToBD.ModeNetTerminalB = false;
                    CLog.WriteException("WarehousePost.cs", "TaskMove", ex.ToString());
                    //Отправляем в буфер
                    BufferOper_POST_EU_LIST_TASKMOVE Oper = new BufferOper_POST_EU_LIST_TASKMOVE(labelPlace, listEU.ToArray());
                    BufferToBD.BufferAdd(new BufferOperation(TypeClassBuffer.POST_EU_LIST_TASKMOVE, Oper));
                    OpenNETCF.Media.SystemSounds.Beep.Play();
                    Thread.Sleep(100);
                    OpenNETCF.Media.SystemSounds.Beep.Play();


                    //Меняем статус на нужный 
                    for (int ii = 0; ii < _tblEU.Rows.Count; ii++)
                    {
                        _tblEU.Rows[ii]["Commit"] = "3";
                    }

                    dataGridEu.BeginInvoke(new Action(() =>
                    {
                        dataGridEu.DataSource = _tblEU;
                    }));
                }

                catch (System.Net.Sockets.SocketException ex)
                {//На случай если во время выполнения сломается связть 

                    dataGridEu.BackColor = Color.LemonChiffon;

                    BufferToBD.ModeNetTerminalB = false;
                    CLog.WriteException("WarehousePost.cs", "TaskMove", ex.ToString());
                    //Отправляем в буфер
                    BufferOper_POST_EU_LIST_TASKMOVE Oper = new BufferOper_POST_EU_LIST_TASKMOVE(labelPlace, listEU.ToArray());
                    BufferToBD.BufferAdd(new BufferOperation(TypeClassBuffer.POST_EU_LIST_TASKMOVE, Oper));
                    OpenNETCF.Media.SystemSounds.Beep.Play();
                    Thread.Sleep(100);
                    OpenNETCF.Media.SystemSounds.Beep.Play();


                    //Меняем статус на нужный 
                    for (int ii = 0; ii < _tblEU.Rows.Count; ii++)
                    {
                        _tblEU.Rows[ii]["Commit"] = "3";
                    }

                    dataGridEu.BeginInvoke(new Action(() =>
                    {
                        dataGridEu.DataSource = _tblEU;
                    }));

                }
            }
            else
            {//Если мы в Офлайне
                BufferOper_POST_EU_LIST_TASKMOVE Oper = new BufferOper_POST_EU_LIST_TASKMOVE(labelPlace, listEU.ToArray());
                BufferToBD.BufferAdd(new BufferOperation(TypeClassBuffer.POST_EU_LIST_TASKMOVE, Oper));

                dataGridEu.BackColor = Color.LemonChiffon;
                OpenNETCF.Media.SystemSounds.Beep.Play();
                Thread.Sleep(100);
                OpenNETCF.Media.SystemSounds.Beep.Play();


                //Меняем статус на нужный 
                for (int ii = 0; ii < _tblEU.Rows.Count; ii++)
                {
                    _tblEU.Rows[ii]["Commit"] = "3";
                }

                dataGridEu.BeginInvoke(new Action(() =>
                {
                    dataGridEu.DataSource = _tblEU;
                }));

            }

        }


        private void EUInAgr()
        {

            WebReference.WebSDataBrCode BrServer = new WebReference.WebSDataBrCode();
            BrServer.SoapVersion = System.Web.Services.Protocols.SoapProtocolVersion.Soap12;
            BrServer.Url = set.AdressAppServer;
            BrServer.BrHeaderValue = CBrHeader.GetHeader();
            BrServer.Credentials = new NetworkCredential(CBrHeader.Login, CBrHeader.Password);
            if (BufferToBD.ModeNetTerminalB)
            {//Если мы в Онлайне
                try
                {
                    DataTable result = BrServer.POST_EU_IN_AGR(listEU.ToArray(), labelPlace, null);

                    dataGridEu.BackColor = Color.MediumAquamarine;
                    OpenNETCF.Media.SystemSounds.Beep.Play();


                    //Меняем статус на нужный 
                    for (int ii = 0; ii < _tblEU.Rows.Count; ii++)
                    {
                        _tblEU.Rows[ii]["Commit"] = "1";
                    }

                    dataGridEu.BeginInvoke(new Action(() =>
                    {
                        dataGridEu.DataSource = _tblEU;
                    }));
                }

                catch (System.Net.WebException ex)
                {
                    dataGridEu.BackColor = Color.LemonChiffon;

                    BufferToBD.ModeNetTerminalB = false;
                    CLog.WriteException("WarehousePost.cs", "EUInAgr", ex.ToString());
                    //Отправляем в буфер
                    BufferOper_POST_EU_IN_AGR Oper = new BufferOper_POST_EU_IN_AGR(labelPlace, listEU.ToArray());
                    BufferToBD.BufferAdd(new BufferOperation(TypeClassBuffer.POST_EU_IN_AGR, Oper));
                    OpenNETCF.Media.SystemSounds.Beep.Play();
                    Thread.Sleep(100);
                    OpenNETCF.Media.SystemSounds.Beep.Play();


                    //Меняем статус на нужный 
                    for (int ii = 0; ii < _tblEU.Rows.Count; ii++)
                    {
                        _tblEU.Rows[ii]["Commit"] = "3";
                    }

                    dataGridEu.BeginInvoke(new Action(() =>
                    {
                        dataGridEu.DataSource = _tblEU;
                    }));
                }

                catch (System.Net.Sockets.SocketException ex)
                {//На случай если во время выполнения сломается связть 

                    dataGridEu.BackColor = Color.LemonChiffon;

                    BufferToBD.ModeNetTerminalB = false;
                    CLog.WriteException("WarehousePost.cs", "TaskMove", ex.ToString());
                    //Отправляем в буфер
                    BufferOper_POST_EU_IN_AGR Oper = new BufferOper_POST_EU_IN_AGR(labelPlace, listEU.ToArray());
                    BufferToBD.BufferAdd(new BufferOperation(TypeClassBuffer.POST_EU_IN_AGR, Oper));
                    OpenNETCF.Media.SystemSounds.Beep.Play();
                    Thread.Sleep(100);
                    OpenNETCF.Media.SystemSounds.Beep.Play();


                    //Меняем статус на нужный 
                    for (int ii = 0; ii < _tblEU.Rows.Count; ii++)
                    {
                        _tblEU.Rows[ii]["Commit"] = "3";
                    }

                    dataGridEu.BeginInvoke(new Action(() =>
                    {
                        dataGridEu.DataSource = _tblEU;
                    }));

                }
            }
            else
            {//Если мы в Офлайне
                BufferOper_POST_EU_IN_AGR Oper = new BufferOper_POST_EU_IN_AGR(labelPlace, listEU.ToArray());
                BufferToBD.BufferAdd(new BufferOperation(TypeClassBuffer.POST_EU_IN_AGR, Oper));

                dataGridEu.BackColor = Color.LemonChiffon;
                OpenNETCF.Media.SystemSounds.Beep.Play();
                Thread.Sleep(100);
                OpenNETCF.Media.SystemSounds.Beep.Play();


                //Меняем статус на нужный 
                for (int ii = 0; ii < _tblEU.Rows.Count; ii++)
                {
                    _tblEU.Rows[ii]["Commit"] = "3";
                }

                dataGridEu.BeginInvoke(new Action(() =>
                {
                    dataGridEu.DataSource = _tblEU;
                }));

            }

        }

        private void InventorySet()
        {
            WebReference.WebSDataBrCode BrServer = new WebReference.WebSDataBrCode();
            BrServer.SoapVersion = System.Web.Services.Protocols.SoapProtocolVersion.Soap12;
            BrServer.Url = set.AdressAppServer;
            BrServer.BrHeaderValue = CBrHeader.GetHeader();
            BrServer.Credentials = new NetworkCredential(CBrHeader.Login, CBrHeader.Password);
            if (BufferToBD.ModeNetTerminalB)
            {//Если мы в Онлайне
                try
                {
                    DataTable result = BrServer.POST_EU_LIST_INVERT_MX(listEU.ToArray(), this.SETRZDN, labelPlace, null);

                    dataGridEu.BackColor = Color.MediumAquamarine;
                    OpenNETCF.Media.SystemSounds.Beep.Play();
                }

                catch (System.Net.WebException ex)
                {
                    dataGridEu.BackColor = Color.LemonChiffon;

                    BufferToBD.ModeNetTerminalB = false;
                    CLog.WriteException("WarehousePost.cs", "InventorySet", ex.ToString());
                    //Отправляем в буфер
                    BufferOper_POST_EU_LIST_INVERT_MX Oper = new BufferOper_POST_EU_LIST_INVERT_MX(labelPlace, this.SETRZDN, listEU.ToArray());
                    BufferToBD.BufferAdd(new BufferOperation(TypeClassBuffer.POST_EU_LIST_INVERT_MX, Oper));
                    OpenNETCF.Media.SystemSounds.Beep.Play();
                    Thread.Sleep(100);
                    OpenNETCF.Media.SystemSounds.Beep.Play();
                }

                catch (System.Net.Sockets.SocketException ex)
                {//На случай если во время выполнения сломается связть 

                    dataGridEu.BackColor = Color.LemonChiffon;

                    BufferToBD.ModeNetTerminalB = false;
                    CLog.WriteException("WarehousePost.cs", "TaskMove", ex.ToString());
                    //Отправляем в буфер
                    BufferOper_POST_EU_LIST_INVERT_MX Oper = new BufferOper_POST_EU_LIST_INVERT_MX(labelPlace, this.SETRZDN, listEU.ToArray());
                    BufferToBD.BufferAdd(new BufferOperation(TypeClassBuffer.POST_EU_LIST_INVERT_MX, Oper));
                    OpenNETCF.Media.SystemSounds.Beep.Play();
                    Thread.Sleep(100);
                    OpenNETCF.Media.SystemSounds.Beep.Play();

                }
            }
            else
            {//Если мы в Офлайне
                BufferOper_POST_EU_LIST_INVERT_MX Oper = new BufferOper_POST_EU_LIST_INVERT_MX(labelPlace, this.SETRZDN, listEU.ToArray());
                BufferToBD.BufferAdd(new BufferOperation(TypeClassBuffer.POST_EU_LIST_INVERT_MX, Oper));

                dataGridEu.BackColor = Color.LemonChiffon;
                OpenNETCF.Media.SystemSounds.Beep.Play();
                Thread.Sleep(100);
                OpenNETCF.Media.SystemSounds.Beep.Play();

            }
        }

        private void OperationNext()
        {
            dataGridEu.BackColor = Color.White;
            //Операция размещения
            try
            {
                switch (ScanOperation)
                {
                    case ListScanOperation.MXSet:
                        {
                            SetMXSet();
                            break;
                        }


                    case ListScanOperation.EUTaskMove:
                        {
                            TaskMove();
                            break;
                        }

                    case ListScanOperation.EuInAgr:
                        {
                            EUInAgr();
                            break;
                        }

                    case ListScanOperation.InventoryTask:
                        {
                            InventorySet();
                            break;
                        }
                }


            }

            catch (Exception ex)
            {
                //labelStatus.BeginInvoke(new Action(() =>
                //{
                //    labelStatus.Text = "Place: " + ex.Message;
                //}));

                CLog.WriteException("WarehousePost.cs", "buttonNext_Click_1", ex.ToString());
            }


            //Тут правим лейбл
            string StatusBD = "БД: " + SqLiteDB.UpdateDateTime + ". Операции: " + BufferToBD.CountBuffer;

            labelBD.BeginInvoke(new Action(() =>
            {
                labelBD.Text = StatusBD;
            }));

        }



        private void buttonNext_Click_1(object sender, EventArgs e)
        {
            OperationNext();
        }

        private void dataGridEu_Paint(object sender, PaintEventArgs e)
        {
            // e.Graphics.Clip.
        }

        private void timerDich_Tick(object sender, EventArgs e)
        {
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

        private void WarehousePost_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.F12)
            {

                //Запускаем интерефейс поиска ЕУ
                EUSearch search = new EUSearch();
                DialogResult DL = search.ShowDialog();
                if (DL == DialogResult.OK)
                {
                    if (search._tblEU.Rows.Count > 0)
                    {
                        //Значит что то выбрали и есть что вставить
                        DataRow row1 = _tblEU.NewRow();
                        row1["Label"] = search.SelectLabel;
                        row1["УЕ"] = search.SelectYE;
                        row1["Вес"] = search.SelectWeight.ToString();
                        row1["Марка"] = search.SelectMarka;
                        row1["Размер"] = search.SelectRazmer;
                        row1["Commit"] = "-1";
                        _tblEU.Rows.InsertAt(row1, 0);

                        listEU.Add(search.SelectLabel);

                        labelCountScan.BeginInvoke(new Action(() =>
                        {
                            labelCountScan.Text = listEU.Count.ToString();
                        }));

                        dataGridEu.BeginInvoke(new Action(() =>
                        {
                            dataGridEu.DataSource = _tblEU;
                        }));
                        OpenNETCF.Media.SystemSounds.Beep.Play();
                    }
                }
            }

            else if (e.KeyCode == Keys.F9)
            {
                OperationNext();
            }

            else if (e.KeyCode == Keys.F14)
            {
               // TestAdd("754577007N6");
            }

            else if (e.KeyCode == Keys.F16)
            {
                bool rezult = ScreenShot.MakeShot("WarehousePost");
                if (rezult)
                    MessageBox.Show("Снимок успешно сохранен", "ScreenShot", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                else
                    MessageBox.Show("Ошибка сохранения", "ScreenShot", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);

            }
        }

        private void WarehousePost_Closed(object sender, EventArgs e)
        {
            bcr.BarcodeRead -= new BarcodeReadEventHandler(bcr_BarcodeReadWarehousePost);

            // bcr.BarcodeRead += new BarcodeReadEventHandler(_returnFunc);

            CLog.WriteInfo("WarehousePost.cs", "Close UI Form");
            FormActive = false;
        }

        private void buttonEUSearch_Click(object sender, EventArgs e)
        {//Запускаем интерефейс поиска ЕУ
            EUSearch search = new EUSearch();
            DialogResult DL = search.ShowDialog();
            if (DL == DialogResult.OK)
            {
                if (search._tblEU.Rows.Count > 0)
                {
                    //Значит что то выбрали и есть что вставить
                    DataRow row1 = _tblEU.NewRow();
                    row1["Label"] = search.SelectLabel;
                    row1["УЕ"] = search.SelectYE;
                    row1["Вес"] = search.SelectWeight.ToString();
                    row1["Марка"] = search.SelectMarka;
                    row1["Размер"] = search.SelectRazmer;
                    row1["Commit"] = "-1";
                   // _tblEU.Rows.Add(row1);
                    _tblEU.Rows.InsertAt(row1, 0);
                    listEU.Add(search.SelectLabel);


                    labelCountScan.BeginInvoke(new Action(() =>
                    {
                        labelCountScan.Text = listEU.Count.ToString();
                    }));


                    dataGridEu.BeginInvoke(new Action(() =>
                    {
                        dataGridEu.DataSource = _tblEU;
                    }));
                    OpenNETCF.Media.SystemSounds.Beep.Play();
                }
            }
        }



    }
}
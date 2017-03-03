using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Intermec.DataCollection;

namespace DataBarCode
{
    public partial class ScanWareHouse : Form
    {
        public ListScanOperation ScanOperation;
        private WareHouseView _view = null;
        private EUShip _ship = null;

        public Intermec.DataCollection.BarcodeReader bcr;
        public ScanWareHouse(Intermec.DataCollection.BarcodeReader _bcr, ListScanOperation _ScanOperation)
        {
            InitializeComponent();
            ScanOperation = _ScanOperation;
            bcr = _bcr;
            initUi();
            InitScaner();
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

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void initUi()
        {


            switch (ScanOperation)
            {
                case ListScanOperation.MXView:
                    {
                        labelCaption.Text = "Место хранения";
                        labelGo.Text = "Для просмотра места хранения";
                        labelCode.Text = "Сканируйте код МХ";
                        break;
                    }

                case ListScanOperation.EUShip:
                    {
                        labelCaption.Text = "Отгрузка";
                        labelGo.Text = "Для начала отгрузки";
                        labelCode.Text = "Сканируйте код документа";
                        break;
                    }

                case ListScanOperation.EUTaskMove:
                    {
                        labelCaption.Text = "Задание на перемещение";
                        labelGo.Text = "Для создания задания на перемещение";
                        labelCode.Text = "Сканируйте код ЕУ";
                        break;
                    }

            }
        }

        private void InitScaner()
        {

            if (bcr == null)
                bcr = new BarcodeReader();
            //set BarcodeRead event
            bcr.BarcodeRead += new BarcodeReadEventHandler(bcr_BarcodeReadScanWareHouse);
            //sends the BarcodeRead event after each successful read
            bcr.ThreadedRead(true);
            bcr.symbology.Code128.Enable = true;
            //set Interleaved 2 of 5
            bcr.symbology.Interleaved2Of5.Enable = false;
            //set PDF417
            bcr.symbology.Pdf417.Enable = false;
            bcr.symbology.QrCode.Enable = false;
        }



        void bcr_BarcodeReadScanWareHouse(object sender, BarcodeReadEventArgs bre)
        {

            try
            {
                string EU = bre.strDataBuffer;
                //заюзаем новую дичь, в зависимости от кода операции будем использовать ту или иную дичь

                switch (ScanOperation)
                {
                    case ListScanOperation.MXView:
                        {

                            if (EU.IndexOf("MX") == 0)
                            {//
                                if (_view == null)
                                {
                                    _view = new WareHouseView(EU);
                                    _view.Show();
                                }
                                else
                                {
                                    _view.Close();
                                    // _scan.Dispose();
                                    _view = new WareHouseView(EU);
                                    _view.Show();
                                }
                            }
                            break;
                        }

                    case ListScanOperation.EUShip:
                        {
                            if (EU.IndexOf("S") == 0)
                            {//Это вагонная карта 
                                ///TN = "S0001500000106002016";
                                if (_ship == null)
                                {
                                    _ship = new EUShip(bcr, EU);
                                    _ship.Show();
                                }
                                else
                                {
                                    if (_ship.FormActive)
                                        return;

                                    _ship.Close();
                                    // _scan.Dispose();
                                    _ship = new EUShip(bcr, EU);
                                    _ship.Show();
                                }

                            }
                            break;
                        }

                }


            }
            catch (Exception exp)
            {
                CLog.WriteException("ScanWareHouse.cs", "bcr_BarcodeReadScanWareHouse", exp.Message);
                //MessageBox.Show(exp.Message);
            }

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

        private void ScanWareHouse_Closed(object sender, EventArgs e)
        {
            bcr.BarcodeRead -= new BarcodeReadEventHandler(bcr_BarcodeReadScanWareHouse);
        }

        private void ScanWareHouse_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.F1)
            {


                switch (ScanOperation)
                {
                    case ListScanOperation.MXView:
                        {

                            break;
                        }

                    case ListScanOperation.EUShip:
                        {//Для теста

                            ///TN = "S0001500000106002016";
                            if (_ship == null)
                            {
                                _ship = new EUShip(bcr, "S0001502548249652017");
                                _ship.Show();
                            }
                            else
                            {
                                if (_ship.FormActive)
                                    return;

                                _ship.Close();
                                // _scan.Dispose();
                                _ship = new EUShip(bcr, "S0001502548249652017");
                                _ship.Show();
                            }

                        }
                        break;
                }
            }
        }
    }
}
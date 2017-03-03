using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataBarCode
{
    public partial class MenuWereHouse : Form
    {
        public Intermec.DataCollection.BarcodeReader bcr;
        private ScanWareHouse _scan = null;
        private WarehouseSel _WareHouseSel = null;
        private InventTaskList _InventTaskList = null;
        private EUSearch_SRZ _euSearchSRZ = null;
        private EUSearch_UGP _euSearchUGP = null;
        private EUSearch_Rulon _euSearchRulon = null;

        public MenuWereHouse(Intermec.DataCollection.BarcodeReader _bcr)
        {
            InitializeComponent();
            bcr = _bcr;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void buttonFactPlace_Click(object sender, EventArgs e)
        {
            if (_scan == null) {
                _scan = new ScanWareHouse(bcr, ListScanOperation.MXView);
                _scan.Show();
            }

            else {
                _scan.Close();
               // _scan.Dispose();
                _scan = new ScanWareHouse(bcr, ListScanOperation.MXView);
                _scan.Show();

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

        private void MenuWereHouse_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void buttonTaskMove_Click(object sender, EventArgs e)
        {
            //if (_scan == null)
            //{
            //    _scan = new ScanWareHouse(bcr, ListScanOperation.EUTaskMove);
            //    _scan.Show();
            //}

            //else
            //{
            //    _scan.Close();
            //    _scan.Dispose();
            //    _scan = new ScanWareHouse(bcr, ListScanOperation.EUTaskMove);
            //    _scan.Show();

            //}

            if (_scan == null)
            {
                _WareHouseSel = new WarehouseSel(bcr, "", "", "", ListScanOperation.EUTaskMove);
                _WareHouseSel.Show();
            }

            else
            {
                _WareHouseSel.Close();
               // _WareHouseSel.Dispose();
                _WareHouseSel = new WarehouseSel(bcr, "", "", "", ListScanOperation.EUTaskMove);
                _WareHouseSel.Show();

            }
        }

        private void buttonIntrovert_Click(object sender, EventArgs e)
        {
            if (_InventTaskList == null)
            {
                _InventTaskList = new InventTaskList(bcr, ListScanOperation.InventoryTask);
                _InventTaskList.Show();
            }

            else
            {
                if (_InventTaskList.FormActive) { }
                else
                {
                    _InventTaskList.Close();
                    // UIEU.DisposeInventTaskList
                    _InventTaskList = new InventTaskList(bcr, ListScanOperation.InventoryTask);
                    _InventTaskList.Show();
                }
            }
        }

        private void buttonSearchSRZ_Click(object sender, EventArgs e)
        {
            if (_euSearchSRZ == null)
            {
                _euSearchSRZ = new EUSearch_SRZ();
                _euSearchSRZ.Show();
            }

            else
            {
                _euSearchSRZ.Close();
                // _WareHouseSel.Dispose();
                _euSearchSRZ = new EUSearch_SRZ();
                _euSearchSRZ.Show();

            }
        }

        private void buttonSearchYEUGP_Click(object sender, EventArgs e)
        {
            if (_euSearchUGP == null)
            {
                _euSearchUGP = new EUSearch_UGP();
                _euSearchUGP.Show();
            }

            else
            {
                _euSearchUGP.Close();
                // _WareHouseSel.Dispose();
                _euSearchUGP = new EUSearch_UGP();
                _euSearchUGP.Show();

            }
        }

        private void buttonSearchRulon_Click(object sender, EventArgs e)
        {
            if (_euSearchRulon == null)
            {
                _euSearchRulon = new EUSearch_Rulon();
                _euSearchRulon.Show();
            }

            else
            {
                _euSearchRulon.Close();
                // _WareHouseSel.Dispose();
                _euSearchRulon = new EUSearch_Rulon();
                _euSearchRulon.Show();

            }
        }
    }
}
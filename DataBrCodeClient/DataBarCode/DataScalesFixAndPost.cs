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
    public partial class DataScalesFixAndPost : Form
    {
        DataTable _TblAgr = null;
        DataTable _TblSelectWareHouse = null;
        WarehousePost _WareHousePost = null;
        public DataScalesFixAndPost()
        {
            InitializeComponent();

            try
            {
                _TblAgr = SqlLiteQuery.GetWareHouse();
            }

            catch (Exception exe)
            {
                CLog.WriteException("WarehouseSel.cs", "WarehouseSel", exe.Message);
            }
            InitUi();

        }


        public void InitUi()
        {
            if (_TblAgr != null)
            {
                comboBoxAgr.DataSource = _TblAgr;
                comboBoxAgr.DisplayMember = "AGR_NAZ";
                comboBoxAgr.ValueMember = "AGR_KOD";
                // comboBoxAgr.SelectedIndex = -1;

            }


        }

        private void DataScalesFixAndPost_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.F16)
            {
                bool rezult = ScreenShot.MakeShot("DataScalesFixAndPost");
                if (rezult)
                    MessageBox.Show("Снимок успешно сохранен", "ScreenShot", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                else
                    MessageBox.Show("Ошибка сохранения", "ScreenShot", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);

            }
        }


        private void buttonFix_Click_1(object sender, EventArgs e)
        {
            buttonNext.Enabled = true;

        }

        private void comboBoxAgr_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if ((comboBoxAgr.SelectedIndex != -1) && (comboBoxAgr.Items.Count > 0))
            {
                //labelStatus.BeginInvoke(new Action(() =>
                //{
                //    labelStatus.Text = "";
                //}));

                //comboBoxWareHouse.BeginUpdate();
                string SelectedAgr = "";
                SelectedAgr = comboBoxAgr.SelectedValue.ToString();
                try
                {
                    comboBoxWareHouse.Enabled = true;
                    if (SelectedAgr != null)
                    {
                        _TblSelectWareHouse = SqlLiteQuery.GetPlace(SelectedAgr, true);
                        comboBoxWareHouse.DataSource = _TblSelectWareHouse;
                        comboBoxWareHouse.DisplayMember = "TEHUZ_NAZ";
                        comboBoxWareHouse.ValueMember = "TEHUZ_LABEL";
                    }
                }
                catch (Exception ex)
                {
                    //labelStatus.BeginInvoke(new Action(() =>
                    //{
                    //    labelStatus.Text = ex.Message + SelectedAgr;
                    //}));
                    CLog.WriteException("WarehouseSel.cs", "comboBoxAgr_SelectedIndexChanged", ex.Message);
                }
                finally
                {
                    comboBoxWareHouse.EndUpdate();
                }
            }
            else
            {
                try
                {

                }
                catch (Exception) { }

            }
        }

        private void buttonNext_Click_1(object sender, EventArgs e)
        {
            //Если операция размещение то нужно что то сделать...!!!!
            if (comboBoxWareHouse.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите место размещения");
                return;

            }
            try
            {
                string SelectedPlace = comboBoxWareHouse.SelectedValue.ToString();

                if (_WareHousePost == null)
                {
                    _WareHousePost = new WarehousePost(null, SelectedPlace, ListScanOperation.MXSet, "5842");
                    _WareHousePost.Show();
                }

                else
                {
                    if (_WareHousePost.FormActive) { }
                    else
                    {
                        _WareHousePost.Close();
                        // UIEU.Dispose();
                        _WareHousePost = new WarehousePost(null, SelectedPlace, ListScanOperation.MXSet, "5842");
                        _WareHousePost.Show();
                    }
                }

            }

            catch (Exception ex)
            {
                //labelStatus.BeginInvoke(new Action(() =>
                //{
                //    labelStatus.Text = "Ex: " + ex.Message;
                //}));

            }
        }
    }
}
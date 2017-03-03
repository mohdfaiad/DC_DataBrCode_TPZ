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
    public partial class ScanTest : Form
    {
        public Intermec.DataCollection.BarcodeReader bcr;

        public ScanTest()
        {
            InitializeComponent();
          
            InitScaner();
            txtText.Focus();
        }

        public void InitScaner()
        {
            try
            {
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

            }

            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        void bcr_BarcodeRead(object sender, BarcodeReadEventArgs bre)
        {

            try
            {
                string EU = bre.strDataBuffer;
               // this.txtText.Text += Environment.NewLine +  EU;
                this.txtLength.Text = EU;//bre.SymbologyDetail.ToString();

                //А вот тут вот напишем код который будет высылать все в БД
                //SendScanEU(EU);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }

        //public void SendScanEU(string EU)
        //{
        //    WebReference.WebSDataBrCode test = new WebReference.WebSDataBrCode();
        //    test.SoapVersion = System.Web.Services.Protocols.SoapProtocolVersion.Soap12;
        //    test.BeginScanEU(EU, MyAsyncCallbackMethod, test);

        //}
        //// Целевые методы AsyncCallback должны иметь следующую сигнатуру
        //void MyAsyncCallbackMethod(IAsyncResult res)
        //{
        //    try
        //    {
        //        WebReference.WebSDataBrCode test = res.AsyncState as WebReference.WebSDataBrCode;
        //        // Trace.Assert(test != null, "Неверный тип объекта");
        //        string result = test.EndScanEU(res);
        //        //txtText.Text += Environment.NewLine + result;
        //        //MessageBox.Show(result);

        //        txtText.BeginInvoke(new Action(() =>
        //        {
        //            txtText.Text += Environment.NewLine + result;
        //        }));

        //    }

        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
       // }



        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (bcr != null)
                {
                    bcr.Dispose();
                    bcr = null;
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

            this.Close();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            txtText.Text = "";
          //  SendScanEU("Test");
        }
    }
}
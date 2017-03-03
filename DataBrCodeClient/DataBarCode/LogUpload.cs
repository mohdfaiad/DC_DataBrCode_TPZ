using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Net;
using Ionic.Zip;
using Ionic.Zlib;

namespace DataBarCode
{
    public partial class LogUpload : Form
    {
        public LogUpload()
        {
            InitializeComponent();

            //Версия ПО
            labelVersion.Text = "Версия ПО: " + CBrHeader.ClientVersion; 
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {//
            Thread InitTh = new Thread(UploadLog);
            InitTh.Start();
        }

        private void UploadLog()
        {
            try
            {
                labelLog.BeginInvoke(new Action(() =>
                {
                    labelLog.Text = "Архивируем";
                }));

                //Выгрузка логов
                string LogDir = "Log\\";
                string ZipFile = "LogArchive.zip";
                Compression(ZipFile, LogDir);

                //Посылаем данные
                labelLog.BeginInvoke(new Action(() =>
                {
                    labelLog.Text = "Архивация - ок";
                }));

                Settings set;
                set = new Settings("DataBrCode.xml");
                WebReference.WebSDataBrCode BrServer = new WebReference.WebSDataBrCode();
                BrServer.SoapVersion = System.Web.Services.Protocols.SoapProtocolVersion.Soap12;
                BrServer.Url = set.AdressAppServer;
                BrServer.BrHeaderValue = CBrHeader.GetHeader();
                BrServer.Timeout = 1000 * 180;
                BrServer.Credentials = new NetworkCredential(CBrHeader.Login, CBrHeader.Password);

                using (FileStream fstream = File.OpenRead(ZipFile))
                {
                    // преобразуем строку в байты
                    byte[] array = new byte[fstream.Length];
                    // считываем данные
                    fstream.Read(array, 0, array.Length);
                    BrServer.SAVE_LOG_TSD_ZIP(array);
                }

            
                
                //Посылаем данные
                labelLog.BeginInvoke(new Action(() =>
                {
                    labelLog.Text = "Данные отправлены";
                }));
            }

            catch (Exception exe)
            {
                labelLog.BeginInvoke(new Action(() =>
                {
                    labelLog.Text = exe.Message;
                }));
            }
        }


        public void Compression(string FileZip, string pathDir)
        {
            try
            {
                File.Delete(FileZip);
            }
            catch (Exception) { }

            using (var zipFile = new ZipFile(FileZip))
            {
                zipFile.CompressionLevel = CompressionLevel.BestSpeed;
                foreach (var em in Directory.GetFiles(pathDir))
                    zipFile.AddFile(em, "\\");
                zipFile.Save();

            }
        }

        private void LogUpload_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                 this.Close();
            }
            else if (e.KeyCode == Keys.F9)
            {
                Thread InitTh = new Thread(UploadLog);
                InitTh.Start();
            }
        }
    }
}
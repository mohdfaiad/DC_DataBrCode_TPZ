using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestingService
{

    class PostService
    {
        Thread thr;
        private int _SleepThread;
        private int _uid;
        public PostService(int uid, int SleepThread)
        {
            _SleepThread = SleepThread;
            _uid = uid;
            thr = new Thread(DataBase_Clone_SQLiteZipFile);
            thr.Start();
        }

        public void Worker()
        {
            while (true)
            {
                Console.WriteLine(_uid + ": ThreadSleep");
                Thread.Sleep(_SleepThread);
            }

        }

        public string GetWebServiceURL
        {
            get
            {
                if (Dns.GetHostName().ToUpper() == "IVPAKHOLKOV-PC")
                    return "http://192.168.80.15:4607/WebSDataBrCode.asmx";
                else return "http://10.96.9.3:8081/WebSDataBrCode.asmx";

            }

        }

        public void DataBase_Clone_SQLiteZipFile()
        {
            Console.WriteLine(_uid + ": Starting Thread: " + DateTime.Now.ToString());
            ServiceReference1.BrHeader header = new ServiceReference1.BrHeader();
            header.DnsAdress = Dns.GetHostName() + _uid;
            header.MacAdress = "00:00:00:00:" + _uid;
            Thread.Sleep(100);

            while (true)
            {
                DateTime dBegin = DateTime.Now;
                ServiceReference1.WebSDataBrCodeSoapClient BrServer = new ServiceReference1.WebSDataBrCodeSoapClient();
                //BrServer.S = System.Web.Services.Protocols.SoapProtocolVersion.Soap12;
                //MaxReceivedMessageSize 
                //
                
                BrServer.Endpoint.Address = new System.ServiceModel.EndpointAddress(GetWebServiceURL);
                byte[] test = BrServer.DataBase_Clone_SQLiteZipFile(header);
               // BrServer.GetLogTSD();
                DateTime dEnd = DateTime.Now;
                Console.WriteLine(_uid + ": DataBase_Clone_SQLiteZipFile - Completed: " + (dEnd - dBegin).ToString());
                Thread.Sleep(_SleepThread);
            }

        }


        public void StopThread()
        {
            try
            {
                thr.Abort();
            }

            catch (Exception) { }
        }
    }
}

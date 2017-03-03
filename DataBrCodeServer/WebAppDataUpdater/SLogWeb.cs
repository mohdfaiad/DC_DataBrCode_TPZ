using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebAppDataBrCode
{
    public static class SLogWeb
    {
        private static List<LogElem> Buffer = null;
        public static void Add(LogElem elem)
        {
            if (Buffer == null)
                Buffer = new List<LogElem>();

            while (Buffer.Count > 40)
            {
                Buffer.RemoveAt(0);

            }
            //Тут допишем код для удаления
            Buffer.Add(elem);
        }

        public static DataTable GetDataTable()
        {
            if (Buffer == null)
                return null;
            DataTable R = new DataTable();
            R.TableName = "LogWebS";
            //Создаем столбцы
            DataColumn colNN = new DataColumn("N", typeof(String));
            R.Columns.Add(colNN);

            DataColumn colN = new DataColumn("DATETIME", typeof(DateTime));
            R.Columns.Add(colN);
            DataColumn colSource = new DataColumn("Login", typeof(String));
            R.Columns.Add(colSource);

            DataColumn colMac= new DataColumn("Mac", typeof(String));
            R.Columns.Add(colMac);

            DataColumn colIp = new DataColumn("IPAdress", typeof(String));
            R.Columns.Add(colIp);
            
            DataColumn colD = new DataColumn("DNS", typeof(String));
            R.Columns.Add(colD);

            colSource = new DataColumn("SERVICE", typeof(String));
            R.Columns.Add(colSource);

            colSource = new DataColumn("MESSAGE", typeof(String));
            R.Columns.Add(colSource);

            colSource = new DataColumn("Version", typeof(String));
            R.Columns.Add(colSource);

            int i = 0;
            //Теперь обойдем лист
            foreach (var e in Buffer)
            {
                i++;
                DataRow row1 = R.NewRow();
                row1["N"] = i.ToString();
                row1["DATETIME"] = e.Time;
                row1["Login"] = e.Login;
                row1["Mac"] = e.MacAdress;
                row1["IPAdress"] = e.IPAdress;
                row1["DNS"] = e.DnsNames;
                row1["SERVICE"] = e.PService;
                row1["MESSAGE"] = e.Message;
                row1["Version"] = e.ClientVersion;
                R.Rows.Add(row1);

            }

            return R;


        }
    }

    public class LogElem
    {
        public DateTime Time { get; set; }

        public string PService { get; set; }
        public string Message { get; set; }
        public string IPAdress { get; set; }
        public string DnsNames { get; set; }
        public string MacAdress { get; set; }
        public string Login { get; set; }
        public string Pass { get; set; }
        public string ClientVersion { get; set; }
        public LogElem(string _Login, string _Pass, string _ClientVersion, string _MacAdress, string _IpAdress, string _DnsNames, string _service, string _message)
        {
            Time = DateTime.Now;
            IPAdress = _IpAdress;
            Message = _message;
            PService = _service;
            DnsNames = _DnsNames;
            MacAdress = _MacAdress;
            Login = _Login;
            Pass = _Pass;
            ClientVersion = _ClientVersion;
        }

        public LogElem(string _service, string _message)
        {
            Time = DateTime.Now;
            IPAdress = "-";
            DnsNames = "-";
            Login = "-";
            Pass = "-";
            MacAdress = "-";
            ClientVersion = "-";
            Message = _message;
            PService = _service;
        }

    }
}
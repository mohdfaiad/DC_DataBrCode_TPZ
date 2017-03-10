using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace DataBarCode
{
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
    static class CLog
    {
        public static string FileName { get; set; }
        public static Int32 DayToSave { get; set; }
        public static string PathDir { get; set; }
        public static void InitCLog()
        {
            String AppData = AppDomain.CurrentDomain.GetData("DataDirectory").ToString();
            try
            {
                
                //Создадим папку для логов
                Directory.CreateDirectory(AppData + "\\WebServiceLog");
            }
            catch (Exception ex)
            {

            }
            PathDir = AppData + "\\WebServiceLog\\";
            DayToSave = 100;
            CleanLog();
            
        }

        private static void ActualFile()
        {
            string _file = PathDir;
            _file += DateTime.Now.ToString("yyyy_MM_dd");
            _file += ".txt";
            CLog.FileName = _file;
        }
        private static void CleanLog()
        {
            List<string> Elems = new List<string>();
            for (int i=0; i <= DayToSave; i++) {
                   string _file;
                    _file = DateTime.Now.AddDays(-i).ToString("yyyy_MM_dd");
                    _file += ".txt";
                    //Debug.WriteLine(_file);
                    Elems.Add(_file);
            }
            //Тут будет чистка логов
            foreach (var elem in Directory.GetFiles(PathDir))
            {
                Debug.WriteLine(elem);
                bool del = true;
                foreach (var e in Elems) {
                    if (elem.IndexOf(e) != -1)
                    {
                        del = false;
                        break;
                    }
                }

                if (del)
                {
                    //Debug.WriteLine("Delete: " + elem);
                    File.Delete(elem);
                }
            }

        }

        public static void WriteInfo(LogElem t)
        {
            InitCLog();
            ///Определяем дату и время
            ///
            string dtM = DateTime.Now.ToString();
            string WriteMessage = dtM + ";" + "INFO;" + "DNS:" +  t.DnsNames + ";MAC:" + t.MacAdress + ";Login:" + t.Login + ";Ver:" + t.ClientVersion + ";"; 
            WriteMessage += t.PService + ";" + t.Message + ";";
            WriteFile(WriteMessage);

        }

        public static void WriteInfo(string Module, string Message)
        {
            InitCLog();
            ///Определяем дату и время
            ///
            string dtM = DateTime.Now.ToString();
            string WriteMessage = dtM + ";" + "INFO;" + Module + ";" + Message + ";";
            WriteFile(WriteMessage);

        }


        public static void WriteException(LogElem t)
        {
            InitCLog();
            ///Определяем дату и время
            ///
            string dtM = DateTime.Now.ToString();
            string WriteMessage = dtM + ";" + "EXCEPTION;" + "Func:" + t.PService + ";" + t.Message + ";";
            WriteFile(WriteMessage);

        }

        private static void WriteFile(string Out)
        {
            //Пишем в файл
            //Проверяем актуальность файла
            CLog.ActualFile();

            try
            {
                StreamWriter writer = new StreamWriter(FileName, true, Encoding.UTF8);
                writer.WriteLine(Out);
                writer.Close();
            }

            catch (Exception ex)
            {

            }

        }
    }
}

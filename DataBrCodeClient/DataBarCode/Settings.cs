using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Xml;


namespace DataBarCode
{
    class Settings
    {
        private string FileName { get; set; }

        public bool Emulator { get; set; }
        public string AdressAppServer { get; set; }
        public Int32 DayToSaveLog { get; set; }
        public string DataScalesServerIp { get; set; }
        public Int32 DataScalesServerPort { get; set; }
        public Int32 DataScalesServerTime { get; set; }

        public Settings(string FileName)
        {
            this.FileName = FileName;
            ReadSettings();


        }

        private void ReadSettings()
        {
            XmlReaderSettings set = new XmlReaderSettings();
            try
            {
                using (XmlReader reader = XmlReader.Create(FileName, set))
                {
                    reader.ReadStartElement("DataBrCode");
                    Emulator = bool.Parse(reader.ReadElementString("Emulator"));
                    AdressAppServer = reader.ReadElementString("AdressAppServer");
                    string test = reader.ReadElementString("AdressAppServerUpdate");
                    DayToSaveLog = Int32.Parse(reader.ReadElementString("DayToSaveLog"));
                    DataScalesServerIp = reader.ReadElementString("DataScalesServerIp");
                    DataScalesServerPort = Int32.Parse(reader.ReadElementString("DataScalesServerPort"));
                    DataScalesServerTime = Int32.Parse(reader.ReadElementString("DataScalesServerTime"));

                    reader.ReadEndElement();
                    reader.Close();
                }

            }

            catch (Exception ex)
            {
                CreateXML();
                ReadSettings();
            }

        }

        private void CreateXML()
        {
            XmlWriterSettings set = new XmlWriterSettings();
            set.Indent = true;

            using (XmlWriter writer = XmlWriter.Create(FileName, set))
            {
                writer.WriteStartElement("DataBrCode");
                writer.WriteElementString("Emulator", false.ToString());
                writer.WriteElementString("AdressAppServer", "http://10.96.9.3:8081/WebSDataBrCode.asmx");
                writer.WriteElementString("AdressAppServerUpdate", "http://10.96.9.3:8082/WebSDataBrUpdater.asmx");
                //writer.WriteElementString("AdressAppServer", "http://192.168.80.15:4607/WebSDataBrCode.asmx");
                //writer.WriteElementString("AdressAppServerUpdate", "http://192.168.80.15:27078/websdatabrupdater.asmx");
                writer.WriteElementString("DayToSaveLog", "10");
                writer.WriteElementString("DataScalesServerIp", "10.96.9.2");
                writer.WriteElementString("DataScalesServerPort", "13000");
                writer.WriteElementString("DataScalesServerTime", "400");


                writer.WriteEndElement();

                writer.Flush();

            }
        }



    }

    static class SettingsTsd
    {
        static public string USEROLD
        {
            get;
            set;
        }
        static private string FileName = "DataBrCodePersonal.xml";

        static public void SaveSettings() { CreateXML(); }
        static public void ReadSettings() 
        {
            XmlReaderSettings set = new XmlReaderSettings();
            try
            {
                using (XmlReader reader = XmlReader.Create(FileName, set))
                {
                    reader.ReadStartElement("DataBrCodePersonal");
                    USEROLD = reader.ReadElementString("USEROLD");

                    reader.ReadEndElement();
                    reader.Close();
                }

            }

            catch (Exception ex)
            {
                USEROLD = "SEVERSTAL\\USER";
                CreateXML();
               
            }
        
        }

        static private void CreateXML()
        {
            XmlWriterSettings set = new XmlWriterSettings();
            set.Indent = true;

            using (XmlWriter writer = XmlWriter.Create(FileName, set))
            {
                writer.WriteStartElement("DataBrCodePersonal");
                writer.WriteElementString("USEROLD", USEROLD);
                writer.WriteEndElement();
                writer.Flush();
            }
        }

    }
}

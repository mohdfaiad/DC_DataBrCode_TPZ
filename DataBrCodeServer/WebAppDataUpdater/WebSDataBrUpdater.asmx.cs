using DataBarCode;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebAppDataBrCode;

namespace WebAppDataUpdater
{
    /// <summary>
    /// Сводное описание для WebSDataBrUpdater
    /// </summary>
    [WebService(Namespace = "WebSDataBrUpdater")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class WebSDataBrUpdater : System.Web.Services.WebService
    {
        public void AddAllLog(string _service, string _message)
        {
            SLogWeb.Add(new LogElem(_service, _message));
            CLog.WriteInfo(_service, _message);
        }

        [WebMethod(Description = "Обновление ПО DataBarCode")]
        public Byte[] System_Get_Release()
        {
            AddAllLog("System_Get_Release", "ТСД получает обновление");
            return File.ReadAllBytes("C:\\TSD_Release\\Current\\DataBrCode.zip");
        }

        [WebMethod(Description = "Получение логов web service")]
        public DataTable GetLogTSD()
        {
            //   SLogWeb.Add( new LogElem("Получаем ЛОГ"));
            return SLogWeb.GetDataTable();
        }


    }
}

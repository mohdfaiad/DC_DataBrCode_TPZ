using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DataBarCode
{
    static class ValidateList
    {

        public static bool CheckEUByList(List<String> EUInTAble, string EUScan)
        {//Проверяем есть ли данная ЕУ в списке
            if (EUInTAble == null) 
                return false;

            if (EUInTAble.IndexOf(EUScan) == -1) return false;
            else return true;
           
        }
    }
}

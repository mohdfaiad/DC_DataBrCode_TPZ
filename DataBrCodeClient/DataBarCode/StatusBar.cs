using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace DataBarCode
{
    static class StatusBar
    {
        static public string getSatus()
        {
            string Out;
            if (!SqLiteDB.RunUpdateBd)
            {//Если БД не обновляется
                Out = "БД: " + SqLiteDB.UpdateDateTime + ". " + BufferToBD.ModeNetTerminalS + ". О: " + BufferToBD.CountBuffer;
            }
            else
            {
                Out = "Обновление БД" + ". " + BufferToBD.ModeNetTerminalS + ". О: " + BufferToBD.CountBuffer;
            }
            return Out;

        }
        static public Color GetColorLabel()
        {
            if ((BufferToBD.CountBufferI == 0) && (BufferToBD.ModeNetTerminalB))
            {
                return Color.White;
            }

            if ((BufferToBD.CountBufferI == 0) && (!BufferToBD.ModeNetTerminalB))
            {
                return Color.LemonChiffon;
            }
            else if (BufferToBD.CountBufferI == 0) {
                return Color.White;
            }
            else if ((BufferToBD.CountBufferI > 0) && (BufferToBD.CountBufferI < 6))
                return Color.Yellow;
            else if (BufferToBD.CountBufferI >= 6)
                return Color.Tomato;
            else
                return Color.Red;

        }

    }
}

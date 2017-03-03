using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;


namespace DataBarCode
{
    class Notification
    {
    }

    public static class Sound
    {
        private static string soundWarning = "\\sound\\soundWarning.wav";
        public static void PlaySoundWarning()
        {
            OpenNETCF.Media.SystemSounds.Beep.Play();
        }
    }

    public static class LedIndicator
    {
        public static void LedRedOn(int mmm)
        {
             
        }
    }

    public static class Vibration
    {

        public static void PlayVibrationWindows(int mmm)
        {

            OpenNETCF.WindowsCE.Notification.Led vib = new OpenNETCF.WindowsCE.Notification.Led();

            //---start vibration---

            vib.SetLedStatus(1, OpenNETCF.WindowsCE.Notification.Led.LedState.On);

            System.Threading.Thread.Sleep(mmm);

            //---stop vibration---

            vib.SetLedStatus(1, OpenNETCF.WindowsCE.Notification.Led.LedState.Off);
        }

        public static void PlayVibration(int mmm)
        {

            OpenNETCF.WindowsCE.Notification.Led vib = new OpenNETCF.WindowsCE.Notification.Led();

            //---start vibration---

            vib.SetLedStatus(1, OpenNETCF.WindowsCE.Notification.Led.LedState.On);

            System.Threading.Thread.Sleep(mmm);

            //---stop vibration---

            vib.SetLedStatus(1, OpenNETCF.WindowsCE.Notification.Led.LedState.Off);
        }
    }
}

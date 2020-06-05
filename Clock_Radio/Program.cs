using System;


namespace Clock_Radio
{
    class Program
    {
        static void Main(string[] args)
        {
            string defaultTime = "0:00";
            string defaultStation = "000.0";
            bool defaultAlarmStatus = false;
            string defaultAlarmTime = "0:00";

            ClockRadio ClockRadio1 = new ClockRadio(defaultTime, defaultStation, defaultAlarmStatus, defaultAlarmTime);
            ClockRadio1.PrintClockSettings();
            ClockRadio1.AdjClockRadio();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorsOverloading
{
    class Clock
    {

        public int Hour;
        public int Minute;
        public int Second;

        public Clock(int hour, int min, int sec)
        
        {
            if (sec > 60) { min += sec / 60; sec = sec % 60; }
            if (min > 60) { hour += min / 60; min = min % 60; }
            if (hour > 24) hour = hour % 24; if (hour == 24) hour = 0;

            Hour = hour;
            Minute = min;
            Second = sec;
        }

        public static Clock operator -(Clock cl, Timer time)
        {
            int hour = cl.Hour;
            int min = cl.Minute - time.Minute;
            int sec = cl.Second - time.Second;
            if (time.Milliseconds > 500) sec++;

            Clock newClock = new Clock(hour, min, sec);
            return newClock;
        }

        public static Clock operator +(Clock cl, Timer time)
        {
            int hour = cl.Hour;
            int min = cl.Minute + time.Minute;
            int sec = cl.Second + time.Second;
            if (time.Milliseconds > 500) sec++;

            Clock newClock = new Clock(hour, min, sec);
            return newClock;
        }

        public static bool operator <(Clock a, Clock b)
        {
            if (a.Hour < b.Hour) return true;
            if (a.Hour > b.Hour) return false;
            if (a.Hour == b.Hour)
            {
                if (a.Minute < b.Minute) return true;
                if (a.Minute > b.Minute) return false;
                if (a.Minute == b.Minute)
                {
                    if (a.Second < b.Second) return true;
                    if (a.Second >= b.Second) return false;
                }
            }
            return false;
        }

        public static bool operator >(Clock a, Clock b)
        {
            return b < a;
        }

        public static bool operator <=(Clock a, Clock b)
        {
            return a < b || a == b;
        }

        public static bool operator >=(Clock a, Clock b)
        {
            return b < a || a == b;
        }

        public static bool operator ==(Clock a, Clock b)
        {
            if (a.Hour == b.Hour && a.Minute == b.Minute && a.Second == b.Second) return true;
            return false;
        }

        public static bool operator !=(Clock a, Clock b)
        {
            if (a.Hour != b.Hour || a.Minute != b.Minute || a.Second != b.Second) return true;
            return false;
        }
    }
}

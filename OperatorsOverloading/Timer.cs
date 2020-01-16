using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorsOverloading
{
    class Timer
    {
        public int Minute;
        public int Second;
        public int Milliseconds;

        public Timer(int min, int sec, int millsec)
        {
            if (millsec > 1000) { sec += millsec / 60; millsec = millsec % 60; }
            if (sec > 60) { min += sec / 60; sec = sec % 60; };

            Minute = min;
            Second = sec;
            Milliseconds = millsec;

        }

        public static bool operator <(Timer a, Timer b)
        {
            if (a.Minute < b.Minute) return true;
            if (a.Minute > b.Minute) return false;
            if (a.Minute == b.Minute)
            {
                if (a.Second < b.Second) return true;
                if (a.Second > b.Second) return false;
                if (a.Second == b.Second)
                {
                    if (a.Milliseconds < b.Milliseconds) return true;
                    if (a.Milliseconds >= b.Milliseconds) return false;
                }
            }
            return false;
        }

        public static bool operator >(Timer a, Timer b)
        {
            return b < a;
        }

        public static bool operator >=(Timer a, Timer b)
        {
            return b < a || a == b;
        }

        public static bool operator <=(Timer a, Timer b)
        {
            return a < b || a == b;
        }

        public static bool operator ==(Timer a, Timer b)
        {
            {
                if (a.Minute == b.Minute && a.Second == b.Second && a.Milliseconds == b.Milliseconds) return true;
                return false;
            }
        }

        public static bool operator !=(Timer a, Timer b)
        {
            {
                if (a.Minute != b.Minute && a.Second != b.Second && a.Milliseconds != b.Milliseconds) return true;
                return false;
            }
        }
    }
}

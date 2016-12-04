using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_TIME
{
    public struct Time
    {
        const  int MAX_MINUTE = 60;
        public int hours;
        public int minutes;

        public Time(int pHour, int pMinute)
        {
            if (pMinute < 0)
            {
                pMinute += MAX_MINUTE;
                pHour--;
            }
            if (pMinute >= MAX_MINUTE)
            {
                pHour += (pMinute / MAX_MINUTE);
                pMinute = pMinute % MAX_MINUTE;
                
            }
            this.hours = pHour;
            this.minutes = pMinute;
        }

        public static Time operator+(Time pTime1, Time pTime2)
        {
            return new Time(pTime1.hours + pTime2.hours, pTime1.minutes + pTime2.minutes);
        }


        public static Time operator-(Time pTime1, Time pTime2)
        { 
            return new Time(pTime1.hours - pTime2.hours, pTime1.minutes - pTime2.minutes);
        }


        public static Time operator*(Time pTime1, int k)
        {
            return new Time(pTime1.hours * k, pTime1.minutes * k);
        }
        
        public static Time operator* (Time pTime1, Time pTime2)
        {
            int allMinute = (pTime1.hours * MAX_MINUTE + pTime1.minutes) * (pTime2.hours * MAX_MINUTE + pTime2.minutes);
            return (new Time(allMinute / MAX_MINUTE, allMinute % MAX_MINUTE));
        }

        public static Time operator/(Time pTime1, int k)
        {
            if(k <= 0)
            {
                throw new DivideByZeroException("pas de diviseur égal ou inférieur à 0");
            }
            int totalMinutes = pTime1.hours * 60 + pTime1.minutes;
            totalMinutes = totalMinutes / k;

            return new Time(totalMinutes / 60, totalMinutes % 60);
        }

        public static Time operator /(Time pTime1, Time pTime2)
        {
            int allMinute = (pTime1.hours * MAX_MINUTE + pTime1.minutes) / (pTime2.hours * MAX_MINUTE + pTime2.minutes);
            return (new Time(allMinute / MAX_MINUTE, allMinute % MAX_MINUTE));
        }

        public static bool operator>(Time pTime1, Time pTime2)
        {
            return (pTime1.hours == pTime2.hours) ? pTime1.minutes > pTime2.minutes : pTime1.hours > pTime2.hours;
        } 

        public static bool operator<(Time pTime1, Time pTime2)
        {
            return (pTime1.hours == pTime2.hours) ? pTime1.minutes < pTime2.minutes : pTime1.hours < pTime2.hours;
        }


        public static bool operator==(Time pTime1, Time pTime2)
        {
            return (pTime1.hours == pTime2.hours && pTime1.minutes == pTime2.minutes);
        }


        public static bool operator!=(Time pTime1, Time pTime2)
        {
            return !(pTime1 == pTime2);
        }

        public override bool Equals(object other)
        {
            if (other == null || this.GetType() != other.GetType()) return false;
            return (this == (Time)other);
        }

        public override int GetHashCode()
        {
            return this.hours * 60 + this.minutes;
        }

        public static explicit operator float(Time pTime)
        {
           
            return (pTime.hours + (pTime.minutes * 1.00f / MAX_MINUTE));
        }

        public static explicit operator Time(float hours)
        {
            return new Time((int)Math.Floor(hours), (int)((hours - Math.Floor(hours))*MAX_MINUTE));
        }

        public static explicit operator string (Time pTime)
        {
            return pTime.ToString();
        }

        public override string ToString()
        {
            return $"{hours}:{minutes}'"; 
        }

        public static explicit operator Time(string time)
        {
            time = time.TrimEnd('\'');
            string format = "g";
            CultureInfo culture = CultureInfo.CurrentCulture;
            TimeSpan ts = TimeSpan.ParseExact(time, format,culture);

            return (new Time(ts.Hours, ts.Minutes));
            
               
        }

    }
}

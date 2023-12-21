using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab_2_vol_2
{
    class Time
    {
        private int hour, minute, second;

        public Time(int h, int m, int s)
        {
            hour = h;
            minute = m;
            second = s;
        }

        public override string ToString()
        {
            return $"{hour:D2}:{minute:D2}:{second:D2}";
        }

        public int GetTimeInSeconds()
        {
            return hour * 3600 + minute * 60 + second;
        }

        public void SetTimeFromSeconds(int seconds)
        {
            seconds %= 86400;
            if (seconds < 0)
                seconds += 86400;

            hour = seconds / 3600;
            minute = (seconds / 60) % 60;
            second = seconds % 60;
        }

        public void AddOneSecond()
        {
            AddSeconds(1);
        }

        public void AddOneMinute()
        {
            AddMinutes(1);
        }

        public void AddOneHour()
        {
            AddHours(1);
        }

        public void AddSeconds(int s)
        {
            int totalSeconds = GetTimeInSeconds() + s;
            SetTimeFromSeconds(totalSeconds);
        }

        public void AddMinutes(int m)
        {
            AddSeconds(m * 60);
        }

        public void AddHours(int h)
        {
            AddMinutes(h * 60);
        }

        public static int Difference(Time t1, Time t2)
        {
            int seconds1 = t1.GetTimeInSeconds();
            int seconds2 = t2.GetTimeInSeconds();
            return seconds1 - seconds2;
        }

        public string WhatLesson()
        {
            Time lessonStartTimes = new Time(8, 0, 0); 
            Time breakTimes = new Time(0, 20, 0);     
            Time endOfDay = new Time(16, 0, 0);       

            int lessonNumber = 0;

            while (GetTimeInSeconds() > lessonStartTimes.GetTimeInSeconds())
            {
                lessonStartTimes.AddHours(1);
                lessonNumber++;
                if (lessonNumber == 6) 
                    return "Пари вже скінчилися";
                if (GetTimeInSeconds() < lessonStartTimes.GetTimeInSeconds())
                    return $"Перерва між {lessonNumber - 1}-ю та {lessonNumber}-ю парами";
            }

            return $"{lessonNumber}-а пара";
        }
    }
}

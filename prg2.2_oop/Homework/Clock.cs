using System;
namespace prg2._2_oop
{
    public class Clock
    {
        int hour;
        int minute;
        int second;
        bool AM;
        string MorningOrNight;
        string time;
        public void Tick(int HourChange,int MinuteChange,int SecondChange)
        {
            hour += HourChange;
            minute += MinuteChange;
            second += SecondChange;
            if(second >= 60)
            {
                minute += 1;
                second -= 60;
            }
            if(minute >= 60)
            {
                hour += 1;
                minute -= 60;
            }
            if(hour >=13)
            {
                hour -= 12;
                AM = !AM;
            }
        }
        public void SetTime(int hours, int minutes, int seconds,bool AMs)
        {
            if(hours >= 13)
            {
                throw new Exception("Invalid Hour");
            }
            else if(minutes >=60)
            {
                throw new Exception("Invalid Minute");
            }
            else if(seconds >=60)
            {
                throw new Exception("Invalid Second");
            }
            else
            {
                hour = hours;
                minute = minutes;
                second = seconds;
                AM = AMs;
            }

        }
        public void DisplayTime()
        {
            if(AM == true)
            {
                MorningOrNight = "A.M.";
            }
            else{
                MorningOrNight = "P.M.";
            }
            time = (hour + ":" + minute + ":" + second + " " + MorningOrNight);
            Console.WriteLine(time);
        }
    }
}

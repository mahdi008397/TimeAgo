using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Time;

public static class TimeAgo
{
    /// <summary>
    /// /// The task of this method is to receive the present tense and the desired time to return a string as output. Like: "4 days ago"
    /// </summary>
    /// <param name="now">Solve input time</param>
    /// <param name="compare">Input the desired time</param>
    /// <returns></returns>
    public static string GetTimeAgo(DateTime now, DateTime compare)
    {
        int year = now.Year - compare.Year;
        int month = now.Month - compare.Month;
        int days = now.Day - compare.Day;
        int hours = now.Hour - compare.Hour;
        int minutes = now.Minute - compare.Minute;
        int seconds = now.Second - compare.Second;

        if (year > 0)
            return $"{year} سال پیش";
        
        if (month > 0)
            return $"{month} ماه پیش";

        if (days > 0)
           return $"{days} روز پیش";
        
        if (hours > 0)
           return $"{hours} ساعت پیش";
        
        if (minutes > 0)
            return $"{minutes} دقیقه پیش";
        
        if (seconds > 0)
            return $"{seconds} ثانیه پیش";
        

        return "لحضاتی پیش";
    }
}
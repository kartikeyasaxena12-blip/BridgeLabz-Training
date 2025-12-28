using System;
class TimeZones
{
    static void Main()
    {
        DateTimeOffset utcTime = DateTimeOffset.UtcNow;

        TimeZoneInfo gmt = TimeZoneInfo.Utc;
        TimeZoneInfo ist = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        TimeZoneInfo pst = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
        
        DateTimeOffset gmtTime = TimeZoneInfo.ConvertTime(utcTime, gmt);
        DateTimeOffset istTime = TimeZoneInfo.ConvertTime(utcTime, ist);
        DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(utcTime, pst);

        Console.WriteLine("GMT Time: " + gmtTime);
        Console.WriteLine("IST Time: " + istTime);
        Console.WriteLine("PST Time: " + pstTime);
    }
}

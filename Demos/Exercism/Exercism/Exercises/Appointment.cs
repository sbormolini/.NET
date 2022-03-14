using System.Globalization;

namespace Exercism;

public enum Location
{
    NewYork,
    London,
    Paris
}

public enum AlertLevel
{
    Early,
    Standard,
    Late
}

public static class Appointment
{
    private static readonly bool isWindows = OperatingSystem.IsWindows();

    private static string GetTimeZoneID(Location location) => location switch
    {
        Location.NewYork => isWindows ? "Eastern Standard Time" : "America/New_York",
        Location.London => isWindows ? "GMT Standard Time" : "Europe/London",
        Location.Paris => isWindows ? "W. Europe Standard Time" : "Europe/Paris",
        _ => throw new ArgumentOutOfRangeException($"Location: {location}"),
    };

    private static TimeZoneInfo GetTimeZoneInfo(Location location)
    {
        var timeZoneID = GetTimeZoneID(location);
        return TimeZoneInfo.FindSystemTimeZoneById(timeZoneID);
    }

    public static DateTime ShowLocalTime(DateTime dtUtc) => dtUtc.ToLocalTime();

    public static DateTime Schedule(string appointmentDateDescription, Location location)
    {
        var date = Convert.ToDateTime(appointmentDateDescription, CultureInfo.GetCultureInfo("en-US"));
        var timeZoneInfo = GetTimeZoneInfo(location);
        return TimeZoneInfo.ConvertTimeToUtc(date, timeZoneInfo);
    }

    public static DateTime GetAlertTime(DateTime appointment, AlertLevel alertLevel) => alertLevel switch
    {
        AlertLevel.Early => appointment.AddDays(-1),
        AlertLevel.Standard => appointment.AddMinutes(-105),
        AlertLevel.Late => appointment.AddMinutes(-30),
        _ => throw new ArgumentOutOfRangeException($"Alertlevel: {alertLevel}"),
    };

    public static bool HasDaylightSavingChanged(DateTime dt, Location location)
    {
        var timeZoneInfo = GetTimeZoneInfo(location);
        return (timeZoneInfo.IsDaylightSavingTime(dt) != timeZoneInfo.IsDaylightSavingTime(dt.AddDays(-7)));
    }

    public static DateTime NormalizeDateTime(string dtStr, Location location)
    {
        try
        {
            var culture = location switch
            {
                Location.NewYork => "en-US",
                Location.London => "en-GB",
                Location.Paris => "fr-FR",
                _ => throw new ArgumentOutOfRangeException($"Location: {location}"),
            };

            return Convert.ToDateTime(dtStr, CultureInfo.GetCultureInfo(culture));
        }
        catch (Exception)
        {
            return new DateTime(1, 1, 1, 0, 0, 0);
        }
    }
}
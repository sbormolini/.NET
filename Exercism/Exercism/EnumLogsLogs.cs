using System;
using System.Text.RegularExpressions;


namespace Exercism;

enum LogLevel
{
    Unknown = 0,
    Trace = 1,
    Debug = 2,
    Info = 4,
    Warning = 5,
    Error = 6,
    Fatal = 42
}

static class LogLine
{
    public static LogLevel ParseLogLevel(string logLine) => logLine switch
    {
        string s when Regex.IsMatch(s, @"^\[TRC\]:") => LogLevel.Trace,
        string s when Regex.IsMatch(s, @"^\[DBG\]:") => LogLevel.Debug,
        string s when Regex.IsMatch(s, @"^\[INF\]:") => LogLevel.Info,
        string s when Regex.IsMatch(s, @"^\[WRN\]:") => LogLevel.Warning,
        string s when Regex.IsMatch(s, @"^\[ERR\]:") => LogLevel.Error,
        string s when Regex.IsMatch(s, @"^\[FTL\]:") => LogLevel.Fatal,
        _ => LogLevel.Unknown,
    };

    public static string OutputForShortLog(LogLevel logLevel, string message) => $"{(int)logLevel}:{message}";
}
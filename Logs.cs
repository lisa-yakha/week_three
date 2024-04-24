//https://exercism.org/tracks/csharp/exercises/logs-logs-logs
using System;

    enum LogLevel
{
    Trace = 1,
    Debug = 2,
    Info = 4,
    Warning = 5,
    Error = 6,
    Fatal = 42,
    Unknown = 0
}

static class LogLine
{

    public static LogLevel ParseLogLevel(string logLine)
    {
        switch(logLine.Substring(0, 5))
        {
            case "[INF]":
                return LogLevel.Info;   
            case "[DBG]":
                return LogLevel.Debug;
            case "[TRC]":
                return LogLevel.Trace;
            case "[WRN]":
                return LogLevel.Warning;
            case "[ERR]":
                return LogLevel.Error;
            case "[FTL]":
                return LogLevel.Fatal;
            default:
                return LogLevel.Unknown;
        }
        
        //throw new NotImplementedException("Please implement the (static) LogLine.ParseLogLevel() method");
    }

    public static string OutputForShortLog(LogLevel logLevel, string message)
    {
        return $"{(int)logLevel}:{message}";
    }
}
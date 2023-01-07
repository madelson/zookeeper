using org.apache.utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ZooKeeperNetEx;

/// <summary>
/// Temporary class to debug connection issues
/// </summary>
public sealed class DebugLog : ILogConsumer
{
    /// <summary>
    /// Controls the log level for built-in ZooKeeper logs
    /// </summary>
    public static TraceLevel LogLevel { get => ZooKeeperLogger.Instance.LogLevel; set => ZooKeeperLogger.Instance.LogLevel = value; }

    /// <summary>
    /// Event that fires whenever a log is available. The argument is the log message
    /// </summary>
    public static event Action<string> LogMessageEmitted;

    internal static void Log(string message) => LogMessageEmitted?.Invoke(message);

    void ILogConsumer.Log(TraceLevel severity, string className, string message, Exception exception) =>
        Log($"{severity} {className} {message}{(exception != null ? " " + exception : "")}");
}

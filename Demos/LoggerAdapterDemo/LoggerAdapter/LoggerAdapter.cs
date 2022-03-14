using Microsoft.Extensions.Logging;

namespace LoggerAdapter;

public class LoggerAdapter<T> : ILoggerAdapter<T>
{
    private readonly ILogger<T> _logger;

    public LoggerAdapter(ILogger<T> logger) => _logger = logger;

    public void LogInformation(string message)
    {
        if (_logger.IsEnabled(LogLevel.Information))
            _logger.LogInformation(message);
    }

    public void LogInformation<T0>(string message, T0 args0)
    {
        if (_logger.IsEnabled(LogLevel.Information))
            _logger.LogInformation(message + " (from adapter with <3)", args0);
    }

    public void LogInformation<T0, T1>(string message, T0 args0, T1 args1)
    {
        if (_logger.IsEnabled(LogLevel.Information))
            _logger.LogInformation(message, args0, args1);
    }

    public void LogInformation<T0, T1, T2>(string message, T0 args0, T1 args1, T2 args2)
    {
        if (_logger.IsEnabled(LogLevel.Information))
            _logger.LogInformation(message, args0, args1, args2);
    }
}

public interface ILoggerAdapter<T>
{
    void LogInformation(string message);

    void LogInformation<T0>(string message, T0 args0);

    void LogInformation<T0, T1>(string message, T0 args0, T1 args1);

    void LogInformation<T0, T1, T2>(string message, T0 args0, T1 args1, T2 args2);
}

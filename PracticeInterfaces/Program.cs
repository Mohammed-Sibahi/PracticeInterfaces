using System;

public interface ILogger
{
     void Log(string message);
}

public class FileLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"File Logger: {message}");
    }
}

public class ConsoleLogger ILogger
{
    public void Log( string message )
    {
        Console.WriteLine ($"Console Logger: {message}");
    }
}

public class Report 
{
    private readonly ILogger _logger;

    public Report( ILogger logger )
    {
        _logger = logger;
    }

    public void GenerateReport( string message )
    {
        _logger.Log("Report generated: " + content);
    }

}
   
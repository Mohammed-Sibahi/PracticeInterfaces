using System;
using System.Runtime.CompilerServices;

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

public class ConsoleLogger : ILogger
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

    public void GenerateReport( string content )
    {
        _logger.Log("Report generated: " + content);
    }

}

public class Program
{
    public static void Main(string[] args )
    {
        // get user email and phone number 
        Console.Write("Enter your email: ");
        string userEmail = Console.ReadLine();

        Console.Write("Enter your phone number: ");
        string userPhoneNumber = Console.ReadLine();

        // simulate a successful login 
        if(IsLoginSuccessful(userEmail, userPhoneNumber))
        {
            ILogger consoleLogger = new ConsoleLogger();
            Report report = new Report(consoleLogger);
            report.GenerateReport("Some report content.");

            Console.WriteLine("Logged in successfully!");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Login failed. Incorrect email or phone number.");
        }
    }
    private static bool IsLoginSuccessful(string email, string phoneNumber)
    {
        return !string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(phoneNumber);
    }
}
   
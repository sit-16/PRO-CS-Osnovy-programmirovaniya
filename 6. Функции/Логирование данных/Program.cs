// See https://aka.ms/new-console-template for more information
string timestamp = Console.ReadLine();
string logLevel = Console.ReadLine();
string message = Console.ReadLine();
LogMessage(message, logLevel, timestamp);

static void LogMessage(string message, string logLevel, string timestamp)
{
    string logFilePath = "log.txt";
    Console.WriteLine($"{timestamp}: {logLevel} {message}.");
    Console.WriteLine($"{logFilePath} обновлен {timestamp}.");
}
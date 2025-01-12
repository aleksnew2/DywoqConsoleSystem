namespace DywoqConsoleSystem;

public class ConsoleInstance
{
  public ConsoleProperties Properties { get; set; } = new();

  public void Info(string message) =>
    Console.WriteLine($"{ConsoleFormatter.FormatTimeStamp(Properties)} {ConsoleFormatter.FormatPrefix(Properties)} {ConsoleFormatter.FormatStyle(ConsoleMessageType.INFO, Properties)}: {message}");

  public void Warning(string message) =>
    Console.WriteLine($"{ConsoleFormatter.FormatTimeStamp(Properties)} {ConsoleFormatter.FormatPrefix(Properties)} {ConsoleFormatter.FormatStyle(ConsoleMessageType.WARNING, Properties)}: {message}");

  public void Error(ConsoleError error)
  {
    Console.WriteLine($"{ConsoleFormatter.FormatTimeStamp(Properties)} {ConsoleFormatter.FormatPrefix(Properties)} {ConsoleFormatter.FormatStyle(ConsoleMessageType.ERROR, Properties)}: {error.Message} ({error.Code})");
    if (Properties.TerminateOnError) Environment.Exit(error.Code);
  }
}

namespace DywoqConsoleSystem;

/// <summary>
/// Represents an instance for handling console output with various message types.
/// </summary>
public class ConsoleInstance
{
  /// <summary>
  /// Gets or sets the properties for configuring the console output.
  /// </summary>
  public ConsoleProperties Properties { get; set; } = new();

  /// <summary>
  /// Prints an informational message to the console.
  /// </summary>
  /// <param name="message">The message to display.</param>
  public void Info(string message) =>
      Console.WriteLine($"{ConsoleFormatter.FormatTimeStamp(Properties)} {ConsoleFormatter.FormatPrefix(Properties)} {ConsoleFormatter.FormatStyle(ConsoleMessageType.INFO, Properties)}: {message}");

  /// <summary>
  /// Prints a warning message to the console.
  /// </summary>
  /// <param name="message">The message to display.</param>
  public void Warning(string message) =>
      Console.WriteLine($"{ConsoleFormatter.FormatTimeStamp(Properties)} {ConsoleFormatter.FormatPrefix(Properties)} {ConsoleFormatter.FormatStyle(ConsoleMessageType.WARNING, Properties)}: {message}");

  /// <summary>
  /// Prints an error message and terminates the program if configured to do so.
  /// </summary>
  /// <param name="error">The error to display.</param>
  public void Error(ConsoleError error)
  {
    Console.WriteLine($"{ConsoleFormatter.FormatTimeStamp(Properties)} {ConsoleFormatter.FormatPrefix(Properties)} {ConsoleFormatter.FormatStyle(ConsoleMessageType.ERROR, Properties)}: {error.Message} ({error.Code})");
    if (Properties.TerminateOnError) Environment.Exit(error.Code);
  }
}

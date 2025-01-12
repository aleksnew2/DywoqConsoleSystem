using Pastel;

namespace DywoqConsoleSystem;

/// <summary>
/// Provides methods for formatting console output, including styles, timestamps, and prefixes.
/// </summary>
public class ConsoleFormatter
{
  /// <summary>
  /// Formats the style of the message based on its type and console properties.
  /// </summary>
  /// <param name="type">The type of the message.</param>
  /// <param name="properties">The console properties to use for formatting.</param>
  /// <returns>A formatted style string for the message.</returns>
  public static string FormatStyle(ConsoleMessageType type, ConsoleProperties properties) =>
      properties.IsWithStyle
          ? $"[{type switch
          {
            ConsoleMessageType.ERROR => $"{type.ToString().Pastel(ConsoleColor.Red)}",
            ConsoleMessageType.INFO => $"{type.ToString().Pastel(ConsoleColor.Green)}",
            ConsoleMessageType.WARNING => $"{type.ToString().Pastel(ConsoleColor.Yellow)}",
            ConsoleMessageType.DEBUG => $"{type.ToString().Pastel(ConsoleColor.Gray)}",
            _ => "empty"
          }}]"
          : $"[{type}]";

  /// <summary>
  /// Formats the timestamp for the message if enabled in the console properties.
  /// </summary>
  /// <param name="properties">The console properties to use for formatting.</param>
  /// <returns>A formatted timestamp string, or an empty string if timestamps are disabled.</returns>
  public static string FormatTimeStamp(ConsoleProperties properties) =>
      properties.IsWithTimeStamp
          ? $"| {DateTime.Now:HH:mm} |"
          : "";

  /// <summary>
  /// Formats the prefix for the message if enabled in the console properties.
  /// </summary>
  /// <param name="properties">The console properties to use for formatting.</param>
  /// <returns>The prefix string, or an empty string if prefixes are disabled.</returns>
  public static string FormatPrefix(ConsoleProperties properties) =>
      properties.IsWithPrefix
          ? $"{properties.Prefix}"
          : "";
}

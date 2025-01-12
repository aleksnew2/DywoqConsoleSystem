using Pastel;

namespace DywoqConsoleSystem;

public class ConsoleFormatter
{
  public static string FormatStyle(ConsoleMessageType type, ConsoleProperties properties)
    => properties.IsWithStyle
      ? $"[{type switch
      {
        ConsoleMessageType.ERROR => $"{type.ToString().Pastel(ConsoleColor.Red)}",
        ConsoleMessageType.INFO => $"{type.ToString().Pastel(ConsoleColor.Green)}",
        ConsoleMessageType.WARNING => $"{type.ToString().Pastel(ConsoleColor.Yellow)}",
        ConsoleMessageType.DEBUG => $"{type.ToString().Pastel(ConsoleColor.Gray)}",
        _ => "empty"
      }}]"
      : $"[{type}]";

  public static string FormatTimeStamp(ConsoleProperties properties) =>
    properties.IsWithTimeStamp
      ? $"| {DateTime.Now:HH:mm} |"
      : "";

  public static string FormatPrefix(ConsoleProperties properties) =>
    properties.IsWithPrefix
      ? $"{properties.Prefix}"
      : "";
}

namespace DywoqConsoleSystem;

public class ConsoleProperties
{
  public string? Prefix { get; set; }
  public bool IsWithPrefix { get; set; }
  public bool IsWithStyle { get; set; } = true;
  public bool IsWithTimeStamp { get; set; } = false;
  public bool TerminateOnError { get; set; } = false;
}

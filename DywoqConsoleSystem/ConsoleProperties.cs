namespace DywoqConsoleSystem;

public class ConsoleProperties
{
  public bool IsWithStyle { get; set; } = true;
  public bool IsWithTimeStamp { get; set; } = false;
  public bool TerminateOnError { get; set; } = false;
  public ICausable<short>[] ErrorExceptions { get; set; } = [];
}

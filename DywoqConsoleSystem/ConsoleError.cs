namespace DywoqConsoleSystem;

public struct ConsoleError : ICausable<short>
{
  public short Code { get; set; }
  public string Message { get; set; }
}

namespace DywoqConsoleSystem;

/// <summary>
/// Represents an error with a short code and a message.
/// </summary>
public struct ConsoleError : ICausable<short>
{
  /// <summary>
  /// Gets or sets the error code.
  /// </summary>
  public short Code { get; set; }

  /// <summary>
  /// Gets or sets the error message.
  /// </summary>
  public string Message { get; set; }
}

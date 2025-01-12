namespace DywoqConsoleSystem;

/// <summary>
/// Represents properties for configuring the console output.
/// </summary>
public class ConsoleProperties
{
  /// <summary>
  /// Gets or sets the prefix that can be added to the console output.
  /// </summary>
  public string? Prefix { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether to include the prefix in the console output.
  /// </summary>
  public bool IsWithPrefix { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether to include a style in the console output.
  /// </summary>
  public bool IsWithStyle { get; set; } = true;

  /// <summary>
  /// Gets or sets a value indicating whether to include a timestamp in the console output.
  /// </summary>
  public bool IsWithTimeStamp { get; set; } = false;

  /// <summary>
  /// Gets or sets a value indicating whether to terminate the program on error.
  /// </summary>
  public bool TerminateOnError { get; set; } = false;
}

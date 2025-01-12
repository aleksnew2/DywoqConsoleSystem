using System.Numerics;

namespace DywoqConsoleSystem;

/// <summary>
/// Represents an object that can be caused with a numeric code and a message.
/// </summary>
/// <typeparam name="T">The type of the numeric code, which must implement INumber.</typeparam>
public interface ICausable<T> where T : INumber<T>
{
  /// <summary>
  /// Gets or sets the numeric code associated with the cause.
  /// </summary>
  public T Code { get; set; }

  /// <summary>
  /// Gets or sets the message associated with the cause.
  /// </summary>
  public string Message { get; set; }
}

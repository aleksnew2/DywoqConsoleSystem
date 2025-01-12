using System.Numerics;

namespace DywoqConsoleSystem;

public interface ICausable<T> where T : INumber<T>
{
  public T Code { get; set; }
  public string Message { get; set; }
}

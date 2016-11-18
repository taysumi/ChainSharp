using System;

namespace ChainSharp.Core
{
  public static class ExceptionExtensions
  {
    public static void Throw<T>(this object @object, string message) where T : Exception
    {
      throw (T)Activator.CreateInstance(typeof(T), message);
    }

    public static void ThrowIfNull(this object @object, string name)
    {
      if (@object == null) { throw new ArgumentNullException(name + "is not allowed to be null"); }
    }

    public static void ThrowIfNull(this object @object)
    {
      if (@object == null) { throw new ArgumentNullException(); }
    }
  }
}
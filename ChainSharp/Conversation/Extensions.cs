using System;

namespace ChainSharp.Conversation
{
  public static class Extensions
  {
    public static T ChangeTo<T>(this IConvertible convertible)
    {
      return (T)Convert.ChangeType(convertible, typeof(T));
    }
  }
}
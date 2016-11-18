using System;
using System.Collections.Generic;

namespace ChainSharp.Linq
{
  public static class Extensions
  {
    public static void ForEach<T>(IEnumerable<T> enumerable, Action<T> action)
    {
      foreach (T item in enumerable) { action(item); }
    }
  }
}
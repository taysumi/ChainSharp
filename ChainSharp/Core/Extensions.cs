namespace ChainSharp.Core
{
  public static class Extensions
  {
    public static T As<T>(this object @object) where T : class
    {
      return @object as T;
    }

    public static bool Is<T>(this object @object)
    {
      return @object is T;
    }

    public static T CastTo<T>(this object @object)
    {
      return (T)@object;
    }
  }
}
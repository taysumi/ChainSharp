namespace ChainSharp.Primitives
{
  public static class StringExtensions
  {
    public static bool IsNullOrWhitespace(this string @string)
    {
      return string.IsNullOrWhiteSpace(@string);
    }

    public static bool IsNullOrEmpty(this string @string)
    {
      return string.IsNullOrEmpty(@string);
    }
  }
}
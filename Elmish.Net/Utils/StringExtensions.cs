namespace Elmish.Net.Utils
{
    internal static class StringExtensions
    {
        public static string FirstToUpper(this string text)
        {
            if (text.Length == 0)
            {
                return text;
            }

            return text.Substring(0, 1).ToUpper() + text.Substring(1);
        }
    }
}

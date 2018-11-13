using System;

namespace Elmish.Net.Utils
{
    internal static class StringExtensions
    {
        public static string FirstToUpper(this string text)
        {
            if (String.IsNullOrEmpty(text))
            {
                return text;
            }

            return text.Substring(0, 1).ToUpper() + text.Substring(1);
        }
    }
}

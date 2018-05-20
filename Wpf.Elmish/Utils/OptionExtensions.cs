using LanguageExt;
using static LanguageExt.Prelude;

namespace Wpf.Elmish.Utils
{
    internal static class OptionExtensions
    {
        public static Option<T> TryCast<T>(this IOptional o)
        {
            return o.MatchUntyped(
                p => p is T q ? Some(q) : None,
                () => None);
        }
    }
}
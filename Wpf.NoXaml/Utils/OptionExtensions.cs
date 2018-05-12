using LanguageExt;
using static LanguageExt.Prelude;

namespace Wpf.NoXaml.Utils
{
    public static class OptionExtensions
    {
        public static Option<TOut> OfType<TOut>(this Option<object> o)
        {
            return o.Bind(p => p is TOut q ? Some(q) : None);
        }
    }
}
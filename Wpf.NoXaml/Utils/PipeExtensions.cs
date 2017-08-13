using System;

namespace Wpf.NoXaml.Utils
{
    public static class PipeExtensions
    {
        public static TOut Then<TIn, TOut>(this TIn input, Func<TIn, TOut> fn)
        {
            return fn(input);
        }

        public static void Then<TIn>(this TIn input, Action<TIn> fn)
        {
            fn(input);
        }
    }
}

using System.Collections.Immutable;
using Elmish.Net.VDom;

namespace Elmish.Net
{
    public static class ElmishApp<TMessage>
    {
        public static IVDomNode<T, TMessage> VDomNode<T>()
            where T : new()
        {
            return new VDomNode<T, TMessage>(
                () => new T(),
                ImmutableList<IVDomNodeProperty<T, TMessage>>.Empty,
                _ => Sub.None<TMessage>());
        }
    }
}
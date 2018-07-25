using System.Windows;
using Elmish.Net;
using Elmish.Net.VDom;

namespace Wpf.Elmish.Net
{
    public static class WpfElmishApp<TMessage>
    {
        public static IVDomNode<T, TMessage> VWpfNode<T>()
            where T : DependencyObject, new()
        {
            return ElmishApp<TMessage>.VDomNode<T>();
        }
    }
}
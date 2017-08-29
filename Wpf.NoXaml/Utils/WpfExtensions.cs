using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;

namespace Wpf.NoXaml.Utils
{
    public static class WpfExtensions
    {
        public static T FindParent<T>(this DependencyObject o)
            where T : DependencyObject
        {
            return o.GetParents().OfType<T>().FirstOrDefault();
        }

        public static IEnumerable<DependencyObject> GetParents(this DependencyObject o)
        {
            var parent = o;
            while ((parent = VisualTreeHelper.GetParent(parent)) != null)
            {
                yield return parent;
            }
        }

        public static IEnumerable<DependencyObject> GetSelfAndDescendants(this DependencyObject o)
        {
            return Enumerable
                .Range(0, VisualTreeHelper.GetChildrenCount(o))
                .Select(i => VisualTreeHelper.GetChild(o, i))
                .SelectMany(GetSelfAndDescendants)
                .StartWith(o);
        }

        public static IEnumerable<T> GetSelfAndDescendants<T>(this DependencyObject o)
            where T : DependencyObject
        {
            return o.GetSelfAndDescendants().OfType<T>();
        }
    }
}

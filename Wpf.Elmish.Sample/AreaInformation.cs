namespace Wpf.Elmish.Sample
{
    [Equals]
    public class AreaInformation
    {
        public AreaInformation(string title, int index)
        {
            Title = title;
            Index = index;
        }

        public string Title { get; }
        public int Index { get; }
    }
}

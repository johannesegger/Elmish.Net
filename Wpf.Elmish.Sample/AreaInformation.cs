namespace Wpf.Elmish.Sample
{
    [Equals]
    public class AreaInformation
    {
        public AreaInformation()
        {
            Index = -1;
        }

        public AreaInformation(string title, int edgeCount, int index)
        {
            Title = title;
            EdgeCount = edgeCount;
            Index = index;
        }

        [IgnoreDuringEquals]
        public bool IsNewArea => Index == -1;

        public string Title { get; set; }
        public int EdgeCount { get; }
        public int Index { get; }
    }
}

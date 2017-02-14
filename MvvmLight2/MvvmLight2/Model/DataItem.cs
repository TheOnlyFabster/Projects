namespace MvvmLight2.Model
{
    public class DataItem
    {
        public string Title
        {
            get;
            set;
        }

        public string Unit { get; set; }

        public string xCu { get; set; }

        public string serviceName { get; set; }

        public DataItem()
        { }

        public DataItem(string title)
        {
            Title = title;
        }
    }
}
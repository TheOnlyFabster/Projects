using System.Windows;
using System.Windows.Controls;

namespace WpfApplication17
{
    partial class Window1
    {
        GridLength[] starHeight;

        public Window1()
        {
            InitializeComponent();

            starHeight = new GridLength[expanderGrid.RowDefinitions.Count];
            starHeight[0] = expanderGrid.RowDefinitions[0].Height;
            starHeight[2] = expanderGrid.RowDefinitions[2].Height;
            ExpandedOrCollapsed(topExpander);
            ExpandedOrCollapsed(bottomExpander);

            // InitializeComponent calls topExpander.Expanded
            // while bottomExpander is null, if we hook this up in the xaml
            topExpander.Expanded += ExpandedOrCollapsed;
            topExpander.Collapsed += ExpandedOrCollapsed;
            bottomExpander.Expanded += ExpandedOrCollapsed;
            bottomExpander.Collapsed += ExpandedOrCollapsed;
        }

        void ExpandedOrCollapsed(object sender, RoutedEventArgs e)
        {
            ExpandedOrCollapsed(sender as Expander);
        }

        void ExpandedOrCollapsed(Expander expander)
        {
            var rowIndex = Grid.GetRow(expander);
            var row = expanderGrid.RowDefinitions[rowIndex];
            if (expander.IsExpanded)
            {
                row.Height = starHeight[rowIndex];
                row.MinHeight = 50;
            }
            else
            {
                starHeight[rowIndex] = row.Height;
                row.Height = GridLength.Auto;
                row.MinHeight = 0;
            }

            var bothExpanded = topExpander.IsExpanded && bottomExpander.IsExpanded;
            splitter.Visibility = bothExpanded ?
                Visibility.Visible : Visibility.Collapsed;
        }
    }
}

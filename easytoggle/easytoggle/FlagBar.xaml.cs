using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace easytoggle
{
  /// <summary>
  /// Interaction logic for FlagBar.xaml
  /// </summary>
  public partial class FlagBar : UserControl
  {
    private List<double> _internallist;

    public FlagBar()
    {
      InitializeComponent();
     
    }

    private void DrawFlags()
    {
      _internallist.ForEach(i =>
         mycanvas.Children.Add(new Line { X1 = i, Y1 = 0, X2 = i, Y2 = mycanvas.ActualHeight, Stroke = new SolidColorBrush(Colors.Red), StrokeThickness = 1.0 })
         );  
    }

    private void Calculate()
    {
      double factor = (this.MaxValue - MinValue) / this.ActualWidth;

      if (FlagList.Count < _internallist.Count)
        _internallist = _internallist.GetRange(0, FlagList.Count);
      

      for (int i = 0; i < FlagList.Count() - 1; i++)
      {
        if (_internallist.Count()  - 1 < i)
          _internallist[i] = FlagList[i] * factor;  
        else
          _internallist.Add(FlagList[i] * factor);
      };

    }

    private void Value_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
    {
      Calculate();
      DrawFlags();
    }

    public double MaxValue
    {
      get { return (double)GetValue(MaxValueProperty); }
      set { SetValue(MaxValueProperty, value); }
    }

    // Using a DependencyProperty as the backing store for MaxValue.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty MaxValueProperty =
        DependencyProperty.Register("MaxValue", typeof(double), typeof(FlagBar), new PropertyMetadata(0));


    public double MinValue
    {
      get { return (double)GetValue(MinValueProperty); }
      set { SetValue(MinValueProperty, value); }
    }

    // Using a DependencyProperty as the backing store for MinValue.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty MinValueProperty =
        DependencyProperty.Register("MinValue", typeof(double), typeof(FlagBar), new PropertyMetadata(0));

  
    public ObservableCollection<int> FlagList
    {
      get { return (ObservableCollection<int>)GetValue(FlagListProperty); }
      set { 
        value.CollectionChanged += Value_CollectionChanged;
        SetValue(FlagListProperty, value);
      }
    }

    // Using a DependencyProperty as the backing store for FlagList.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty FlagListProperty =
        DependencyProperty.Register("FlagList", typeof(ObservableCollection<int>), typeof(FlagBar), new PropertyMetadata(new ObservableCollection<int>()));


  }
}

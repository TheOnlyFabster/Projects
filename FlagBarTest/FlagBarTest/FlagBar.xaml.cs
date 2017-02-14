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

namespace FlagBarTest
{
  /// <summary>
  /// Interaction logic for FlagBar.xaml
  /// </summary>
  public partial class FlagBar : UserControl
  {
    private List<double> _internallist = new  List<double>();
    
    public FlagBar()
    {
      InitializeComponent();

      mycanvas.SizeChanged += Mycanvas_SizeChanged;
    }

    private void Mycanvas_SizeChanged(object sender, SizeChangedEventArgs e)
    {
      Calculate();
      DrawFlags();
    }

    private void DrawFlags()
    {
      List<Line> LineCollection = mycanvas.Children.OfType<Line>().ToList();
      int ToMuch = Math.Max(0, LineCollection.Count() - _internallist.Count());

      for (int i = 0; i < _internallist.Count() ; i++)
      {
        if (LineCollection.Count() > i)
        {
          LineCollection[i].X1 = _internallist[i];
          LineCollection[i].X2 = _internallist[i];
        }
        else
          mycanvas.Children.Add(
            new Line
            {
              X1 = _internallist[i],
              Y1 = 0,
              X2 = _internallist[i],
              Y2 = mycanvas.ActualHeight,
              Stroke = new SolidColorBrush(Colors.Red),
              StrokeThickness = 1.0
            });
      }

      for (int i = LineCollection.Count() - 1; i >= LineCollection.Count() - ToMuch; i--)
        mycanvas.Children.Remove(LineCollection[i]);
    }

    private void Calculate()
    {
      double factor = this.ActualWidth / (this.MaxValue - MinValue);
     _internallist = FlagList.ToList().ConvertAll(x => x * factor);
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
        DependencyProperty.Register("MaxValue", typeof(double), typeof(FlagBar), new PropertyMetadata((double)0));


    public double MinValue
    {
      get { return (double)GetValue(MinValueProperty); }
      set { SetValue(MinValueProperty, value); }
    }

    // Using a DependencyProperty as the backing store for MinValue.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty MinValueProperty =
        DependencyProperty.Register("MinValue", typeof(double), typeof(FlagBar), new PropertyMetadata((double)0));

  
    public ObservableCollection<double> FlagList
    {
      get { return (ObservableCollection<double>)GetValue(FlagListProperty); }
      set { 
        //value.CollectionChanged += Value_CollectionChanged;
        SetValue(FlagListProperty, value);
      }
    }

    // Using a DependencyProperty as the backing store for FlagList.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty FlagListProperty =
        DependencyProperty.Register("FlagList", typeof(ObservableCollection<double>), typeof(FlagBar), new PropertyMetadata(new ObservableCollection<double>()));


  }
}

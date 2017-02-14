using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace easytoggle
{
  public class EasyToggle : ToggleButton
  {

    private object CheckedContent { get; set; }

    protected override void OnInitialized(EventArgs e)
    {
      base.OnInitialized(e);
      CheckedContent = this.Content;

      if (this.IsChecked == null)
        this.Content = UnDeterminedContent;
      else if (this.IsChecked == false)
        this.Content = UnCheckedContent;
      else
        this.Content = CheckedContent;
    }

    protected override void OnChecked(RoutedEventArgs e)
    {
      this.Content = CheckedContent;

      base.OnChecked(e);
    }

    protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
    {
      base.OnPropertyChanged(e);
    }

    protected override void OnUnchecked(RoutedEventArgs e)
    {
      this.Content = UnCheckedContent;
      base.OnUnchecked(e);
    }

    public object UnCheckedContent
    {
      get { return (object)GetValue(UncheckedContentProperty); }
      set { SetValue(UncheckedContentProperty, value); }
    }

    // Using a DependencyProperty as the backing store for UncheckedContent.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty UncheckedContentProperty =
        DependencyProperty.Register("UnCheckedContent", typeof(object), typeof(EasyToggle), new PropertyMetadata(string.Empty));


    public object UnDeterminedContent
    {
      get { return (object)GetValue(UnDeterminedContentProperty); }
      set { SetValue(UnDeterminedContentProperty, value); }
    }

    // Using a DependencyProperty as the backing store for UnDeterminedContent.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty UnDeterminedContentProperty =
        DependencyProperty.Register("UnDeterminedContent", typeof(object), typeof(EasyToggle), new PropertyMetadata(string.Empty));



  }
}

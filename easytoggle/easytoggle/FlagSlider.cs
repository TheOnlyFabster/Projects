using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace easytoggle
{
  public class FlagSlider : System.Windows.Controls.Slider
  {

    protected override void OnInitialized(EventArgs e)
    {
      base.OnInitialized(e);

      
   
    }


    protected override void OnValueChanged(double oldValue, double newValue)
    {
      base.OnValueChanged(oldValue, newValue);

    
    }
    public override void OnApplyTemplate()
    {
      base.OnApplyTemplate();

    
    }

    

  }
}

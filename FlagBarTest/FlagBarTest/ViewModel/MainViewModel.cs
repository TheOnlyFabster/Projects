using GalaSoft.MvvmLight;
using FlagBarTest.Model;
using System.Collections.ObjectModel;

namespace FlagBarTest.ViewModel
{
  /// <summary>
  /// This class contains properties that the main View can data bind to.
  /// <para>
  /// See http://www.mvvmlight.net
  /// </para>
  /// </summary>
  public class MainViewModel : ViewModelBase
  {
    private readonly IDataService _dataService;

    /// <summary>
    /// The <see cref="WelcomeTitle" /> property's name.
    /// </summary>
    public const string WelcomeTitlePropertyName = "WelcomeTitle";

    private string _welcomeTitle = string.Empty;

    private ObservableCollection<double> _flaglist = new ObservableCollection<double>();
    public ObservableCollection<double> Flaglist
    {
      get
      {
        return _flaglist;
      }
      set
      {
        Set(ref _flaglist, value);
      }
    }

    private double _maxvalue = 100;

    public double MaxValue
    {
      get { return _maxvalue; }
      set { _maxvalue = value; }
    }

    private double _minvalue = 0;

    public double MinValue
    {
      get { return _minvalue; }
      set { _minvalue = value; }
    }



    /// <summary>
    /// Gets the WelcomeTitle property.
    /// Changes to that property's value raise the PropertyChanged event. 
    /// </summary>
    public string WelcomeTitle
    {
      get
      {
        return _welcomeTitle;
      }
      set
      {
        Set(ref _welcomeTitle, value);
      }
    }

    /// <summary>
    /// Initializes a new instance of the MainViewModel class.
    /// </summary>
    public MainViewModel(IDataService dataService)
    {
      _dataService = dataService;
      _dataService.GetData(
          (item, error) =>
          {
            if (error != null)
            {
                    // Report error here
                    return;
            }

            WelcomeTitle = item.Title;
          });

      this.Flaglist.Add(10);
      this.Flaglist.Add(50);

    }

    ////public override void Cleanup()
    ////{
    ////    // Clean up if needed

    ////    base.Cleanup();
    ////}
  }
}
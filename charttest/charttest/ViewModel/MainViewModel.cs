using GalaSoft.MvvmLight;
using charttest.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;

namespace charttest.ViewModel
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


        public ObservableCollection<KeyValuePair<string, int>> ChartData { get; set; } 

        private void FillChartData()
        {

            this.ChartData = new ObservableCollection<KeyValuePair<string, int>>();

            ChartData.Add(new KeyValuePair<string, int>("Administration", 20));
            ChartData.Add(new KeyValuePair<string, int>("Management", 36));
            ChartData.Add(new KeyValuePair<string, int>("Development", 89));
            ChartData.Add(new KeyValuePair<string, int>("Support", 270));
            ChartData.Add(new KeyValuePair<string, int>("Sales", 140));
        }


        
        /// <summary>
        /// The <see cref="WelcomeTitle" /> property's name.
        /// </summary>
        public const string WelcomeTitlePropertyName = "WelcomeTitle";

        private string _welcomeTitle = string.Empty;

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

            FillChartData();

            StartTimer(1000);
        }

        public void StartTimer(int dueTime)
        {
            Timer t = new Timer(new TimerCallback(TimerProc));
            t.Change(dueTime, 0);
        }

        private void TimerProc(object state)
        {
            //// The state object is the Timer object.
            //Timer t = (Timer)state;
            //t.Dispose();

            this.ChartData.Add(new KeyValuePair<string, int>("bla", 100));

        }


        private int count = 0;
        
        ////public override void Cleanup()
        ////{
        ////    // Clean up if needed

        ////    base.Cleanup();
        ////}


        //class CustomTimer : System.Timers.Timer
        //{
        //    public string Data;
        //}

        //private void StartTimer()
        //{
        //    var timer = new CustomTimer
        //    {
        //        Interval = 3000,
        //        Data = "Foo Bar"
        //    };

        //    timer.Elapsed += timer_Elapsed;
        //    timer.Start();
        //}

        //void timer_Elapsed(object sender, ElapsedEventArgs e)
        //{
         
        //    this.ChartData.Add(new KeyValuePair<string, int>("bla", 100));

            
        //}

    }
}
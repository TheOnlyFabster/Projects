using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Windows;

using System.Windows.Controls;

using System.Windows.Data;

using System.Windows.Documents;

using System.Windows.Input;

using System.Windows.Media;

using System.Windows.Media.Imaging;

using System.Windows.Navigation;

using System.Windows.Shapes;



namespace UIElement

{

    /// <summary>

    /// Interaction logic for Window1.xaml

    /// </summary>

    public partial class Window1 : Window

    {

        public Window1()

        {

            InitializeComponent();



            List<StateInfo> statesList = new List<StateInfo>();


            

            statesList.Add(new StateInfo("Maryland", "Annapolis", "Old Line State", "Eastern"));

            statesList.Add(new StateInfo("California", "Sacramento", "Golden State", "Pacific"));

            statesList.Add(new StateInfo("Washington", "Olympia", "Ever Green State", "Pacific"));

            statesList.Add(new StateInfo("Taxes", "Austin", "Lone Star State", "Central"));

            statesList.Add(new StateInfo("New York", "Albany", "Empire State", "Eastern"));



            list.ItemsSource = statesList;

        }

    }


    public class subitem
    {
        public string fieldname { get; set; }

        public string fieldvalue { get; set; }

    }


    public class StateInfo

    {

        public StateInfo()

        {
            subitems = new List<subitem>();
        }



        public StateInfo(String name, String capital, String nickName, String timeZone)
        {
            Name = name;
            Capital = capital;
            NickName = nickName;
            TimeZone = timeZone;

            subitems = new List<subitem>();
        }


        public String Name

        { get; set; }



        public String Capital

        { get; set; }



        public String NickName

        { get; set; }



        public String TimeZone

        { get; set; }


        public List<subitem> subitems { get; set; }
    }

}
using System;
using System.Collections.Generic;
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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<subitem> subitemlist1 = new List<subitem>() { new subitem { field1 = "1", field2 = "test2" } };
            List<subitem> subitemlist2 = new List<subitem>() { new subitem { field1 = "3", field2 = "test4" } };
            List<subitem> subitemlist3 = new List<subitem>() { new subitem { field1 = "5", field2 = "test6" } };

            List<User> items = new List<User>();
            items.Add(new User() { Name = "John Doe", Age = 42, Mail = "john@doe-family.com" , SubItems = subitemlist1});
            items.Add(new User() { Name = "Jane Doe", Age = 39, Mail = "jane@doe-family.com", SubItems = subitemlist2 });
            items.Add(new User() { Name = "Sammy Doe", Age = 7, Mail = "sammy.doe@gmail.com" , SubItems = subitemlist3});
            lvUsers.ItemsSource = items;
        }
    }

    public class User
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Mail { get; set; }

        public List<subitem> SubItems { get; set; }
    }

    public class subitem
    {
        public string field1 { get; set; }

        public string field2 { get; set; }
    }
}

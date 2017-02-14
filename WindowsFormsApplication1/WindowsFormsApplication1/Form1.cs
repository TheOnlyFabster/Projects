using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ItemsList = new BindingList<Item>();
        }


        public class Item
        {
            public string Name { get; set; }

            public bool selected { get; set; }
        }

        public BindingList<Item> ItemsList { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Item> list = new List<Item>();
            list.Add(new Item { Name = "een", selected = false });
            list.Add(new Item { Name = "twee", selected = false });
            list.Add(new Item { Name = "drie", selected = false });


            //BindingSource listbox1bindingsource = new BindingSource();
            //this.ItemsList = new BindingList<Item>(list);

            //BindingList<Item> bindinglist = new BindingList<Item>(this.ItemsList);
            //listbox1bindingsource.DataSource = bindinglist;
            this.listBox1.DataSource = list; // this.ItemsList;
            this.listBox1.DisplayMember = "Name";
            

            //SetDataSource();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Item selecteditem = this.listBox1.SelectedItem as Item;

            if (selecteditem != null)
                selecteditem.selected = true;


        
            ((List<Item>)this.listBox1.DataSource).Add(new Item { Name = "vier", selected = false });

           // this.ItemsList.Add(new Item { Name = "vier", selected = false });
            //this.ItemsList.First().selected = true;

            //SetDataSource();


        }

        private void SetDataSource()
        {
            this.listBox1.DataSource = null;
            this.listBox1.DataSource = this.ItemsList.Where(i => i.selected == false).ToList();
            this.listBox1.DisplayMember = "Name";

           

            this.listBox2.DataSource = null;
            this.listBox2.DataSource = this.ItemsList.Where(i => i.selected == true).ToList();
            this.listBox2.DisplayMember = "Name";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Item selecteditem = this.listBox2.SelectedItem as Item;
            if (selecteditem != null)
                selecteditem.selected = false;

            //this.ItemsList.Add(new Item { Name = "vier", selected = false });
            //this.ItemsList.First().selected = true;

            //SetDataSource();
        }
    }
}

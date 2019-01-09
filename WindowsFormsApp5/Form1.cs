using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        List<Phone> phones = new List<Phone>();
        public Form1()
        {
            InitializeComponent();
            Phone phone = new Phone("phone", 1, 1);
            Phone phone2 = new Phone("phone2", 2, 1);
            Phone phone3 = new Phone("phone3", 3, 1);
            phones.Add(phone); phones.Add(phone2); phones.Add(phone3);
            listBox1.DataSource = phones;
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "ID";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in phones)
            {
                MessageBox.Show($"Item {item.ID} - {item.Name} ");
            }

        }
    }
    class Phone
    {
        public Phone(string name, int ıD, int year)
        {
            Name = name;
            ID = ıD;
            Year = year;
        }
        public string Name { get; set; }
        public int ID { get; set; }
        public int Year { get; set; }
    }
}

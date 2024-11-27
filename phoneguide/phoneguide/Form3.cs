using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phoneguide
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private string FillSpace(string s,int n)
            {
            for (int i=s.Length;i<n;i++)
            {
                s = s + " ";
            }
            return s;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text + " " + textBox2.Text + " " + textBox3.Text;
            string PhoneNumber, Address, Name;
            PhoneNumber = FillSpace(textBox1.Text, 11);
            Name=FillSpace(textBox2.Text, 30);
            Address = textBox3.Text;
            
            listBox1.Items.Add(PhoneNumber+" "+Name+" "+Address);

        }
    }
}

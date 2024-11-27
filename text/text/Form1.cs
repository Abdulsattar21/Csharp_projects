using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace text
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int midterm, final;
            double averege, midterm_percent, final_percent;
            midterm = Convert.ToInt16(textBox1.Text);
            final = Convert.ToInt16(textBox2.Text);
            midterm_percent = Convert.ToDouble(textBox3.Text);
            final_percent = Convert.ToDouble(textBox3.Text) ;
            averege = midterm * midterm_percent /100 + final * final_percent /100;
            label4.Text = Convert.ToString(averege);
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

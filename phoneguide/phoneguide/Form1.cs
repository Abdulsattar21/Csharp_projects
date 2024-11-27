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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new phoneguide.Form2();
            form2.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void guidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new phoneguide.Form3();
            form3.ShowDialog();
        }
    }
}

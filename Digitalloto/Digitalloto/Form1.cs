using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digitalloto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //generate 6 differen numbers between 1 and 49
            int[] numbers = new int[6];
            int number, rwocount;
                string s = "";

            Random rnd = new Random();


            listBox1.Items.Clear();

            rwocount = Convert.ToInt16(textBox1.Text);

            for(int j=0;j<rwocount;j++)
            {
            
                for (int i = 0; i < 6; i++)
                {

                    do
                    {
                        number = rnd.Next(1, 50);
                    
                    } while (numbers.Contains(number));

                    numbers[i] = number;

                 }

                Array.Sort(numbers);

                for(int k=0;k<6;k++)
                {
                    string s1 = Convert.ToString(numbers[k]);
                    if (s1.Length == 1)
                        s1 = "0" + s1;
                    s = s + " " + s1;

                }
                listBox1.Items.Add(s);
                s = "";
               // string s1 = Convert.ToString(number);

                    }
               
            }
        }
    }


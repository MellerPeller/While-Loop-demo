using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While_Loop
{
    public partial class Form1 : Form
    {
        int number1 = 0;
        int number2 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out number1);
            int.TryParse(textBox2.Text, out number2);



            while (number1 < number2) 
            {
                
                number1++;
                textBox3.Text = textBox3.Text + number1.ToString() + " ";

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out number1);
            int.TryParse(textBox2.Text, out number2);



            while (number1 < number2)
            {

                number2--;
                textBox3.Text = textBox3.Text + number2.ToString() + " ";

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out number1);
            int.TryParse(textBox2.Text, out number2);



            while (number1 < number2)
            {

                number1++;

                if (number1 % 2 == 1)
                {
                    textBox3.Text = textBox3.Text + number1.ToString() + " ";
                }
     
            }
        }
    }
}

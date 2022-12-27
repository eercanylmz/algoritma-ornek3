using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace algoritma_ornek3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int total = 0;
            int number = Convert.ToInt32(textBox1.Text);
            for (int i = 1; i <= number/2;i++)
            {
                if (number % i == 0)
                {
                    total = total + i;

                }
                if (number == total)
                {
                    label3.Text = "NUMBER IS THE PERFECT NUMBER";
                }
                else
                {
                    label3.Text = "THE NUMBER IS NOT PERFECT";
                }
            }
        }
    }
}

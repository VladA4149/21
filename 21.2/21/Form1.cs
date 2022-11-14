using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21
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
            int size = 11;
            int[] myArray = new int[size];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = (int)Math.Pow(2, i);
                textBox2.Text = textBox2.Text + myArray[i] + " ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int size = 11;
            int[] myArray = new int[size];
            for (int i = myArray.Length - 1; i >= 0; i--)
            {
                myArray[i] = (int)Math.Pow(2, i);
                textBox3.Text = textBox3.Text + myArray[i] + " ";
            }
        }
    }
}

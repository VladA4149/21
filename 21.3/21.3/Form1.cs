using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _21._3
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
            char[] symbs = new char[10];
            Random random = new Random();
            for (int k = 0; k < symbs.Length; k++)
            {
                symbs[k] = (char)('A' + random.Next(26));
            }
            for (int k = 0; k < symbs.Length; k++)
            {
                textBox2.Text = textBox2.Text + symbs[k] + " ";
            }
            textBox2.Text += " /// ";
            for (int k = symbs.Length-1; k >= 0; k--)
            {
                textBox2.Text = textBox2.Text + symbs[k] + " ";
            }
        }
    }
}

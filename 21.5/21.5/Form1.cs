using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int[,] myArray = new int[5, 5];

            int height = myArray.GetLength(0);
            int width = myArray.GetLength(1);

            textBox1.Text += "Начальный массив" + "\r\n";
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    myArray[i, j] = random.Next(25);
                    textBox1.Text += myArray[i, j] + " ";
                }
                textBox1.Text += "\r\n";
            }

            int column = random.Next(5);
            int line = random.Next(5);
            textBox3.Text += "Удаляемая строка и столбец: " + (line + 1) + " " + (column + 1);

            int[,] newArray = new int[4, 4];

            int newHeight = newArray.GetLength(0);
            int newWidth = newArray.GetLength(1);

            int x = 0, y = 0;

            textBox2.Text += "Изменённый массив" + "\r\n";
            for (int i = 0; i < height; i++)
            {
                if (i == line) continue;
                y = 0;
                for (int j = 0; j < width; j++)
                {
                    if (j == column) continue;
                    newArray[x, y] = myArray[i, j];
                    y++;
                }
                x++;
            }
            for (int i = 0; i < newHeight; i++)
            {
                for (int j = 0; j < newWidth; j++)
                {
                    textBox2.Text += newArray[i, j] + " ";
                }
                textBox2.Text += "\r\n";
            }
        }
    }
}

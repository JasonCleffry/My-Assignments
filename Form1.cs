using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] num = new int[6] { 1, 2, 3, 4, 5, 6 };

            Random rnd1 = new Random();
            int index1 = rnd1.Next(num.Length);
            int i = num[index1];
            Console.WriteLine($"Value #1: {num[index1]}");

            System.Threading.Thread.Sleep(200);
            Random rnd2 = new Random();
            int index2 = rnd2.Next(num.Length);
            int j = num[index2];
            Console.WriteLine($"Value #2: {num[index2]}");

            System.Threading.Thread.Sleep(400);
            Random rnd3 = new Random();
            int index3 = rnd3.Next(num.Length);
            int k = num[index3];
            Console.WriteLine($"Value #3: {num[index3]}");

            System.Threading.Thread.Sleep(300);
            Random rnd4 = new Random();
            int index4 = rnd4.Next(num.Length);
            int l = num[index4];
            Console.WriteLine($"Value #4: {num[index4]}");

            MessageBox.Show($"Value #1: {num[index1]}");
            MessageBox.Show($"Value #2: {num[index2]}");
            MessageBox.Show($"Value #3: {num[index3]}");
            Console.ReadLine();

            int m;
            m = (i + j + k);
            int n;
            n = (m + l);

            Console.WriteLine("Ace Result: " + m);
            Console.WriteLine("Final Result: " + n);
            Console.ReadLine();

            if (m > 11)
            {
                Console.ReadLine();
                MessageBox.Show("Your Ace Result: " + m);
            }
            else
            {
                Console.ReadLine();
                MessageBox.Show("Please try the fourth dice...");
                MessageBox.Show($"Value #4: {num[index4]}");
                MessageBox.Show("Your Final Result: " + n);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Press 【Roll!】 to start. Or press 【Exit】 to exit the program.\n The rules of the game: Roll out three dice at one time and check the sum.\n If the sum is greater than or equal to 12, the game ends immediately.\n If the sum is less than 12, there is an additional chance to roll the fourth dice\n and add the result to the previous sum.\n After that, the game ends.");
        }
    }
}
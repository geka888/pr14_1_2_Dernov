using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pr14_1_2_Dernov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = (int)numericUpDown1.Value;
            Stack<int> stack = new Stack<int>();
            for(int i=1; i<=n;i++)
            {
                stack.Push(i);
            }
            int peek = stack.Peek();
            int count = stack.Count();
            label1.Text = $"Размерность стека {n}";
            label2.Text = $"Верхний элемент стека {peek}";
            label3.Text = $"Размерность стека {count}";
            string soderjimoe = "Содержимое стека ";
            while(stack.Count>0)
            {
                soderjimoe += stack.Pop() + " ";
            }
            label4.Text = $"{soderjimoe}";
            
            label5.Text = $"Новая размерность стека {stack.Count} ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(!(textBox1.Text ==""))
            {
                StreamWriter sw = File.CreateText("t.txt");
                sw.WriteLine(textBox1.Text);
                sw.Close();
            }
            Stack<int> stack = new Stack<int>();
            string text = textBox1.Text;
            
            

        }
    }
}

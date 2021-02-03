using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лр_1
{
    public partial class Form1 : Form
    {
        Calculator calc;
        public Form1()
        {
            InitializeComponent();
            calc = new Calculator();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //symbol by index
            int indx;
            indx = Convert.ToInt32(textBox3.Text);
            textBox4.Text = "Найденный символ: " + calc.GetSymbolByIndex(textBox1.Text, indx);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //length
            textBox4.Text = "Длина строки: " +  calc.GetLenght(textBox1.Text).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //change substr
            textBox4.Text = "Измененная строка: " + calc.ChangeSubstr(textBox1.Text, textBox2.Text, textBox3.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //delete_symbol
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //nums of symbols
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //nums of vowels
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //nums of consonants
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //nums of sentences
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

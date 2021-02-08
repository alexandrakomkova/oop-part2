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

            if (textBox3.TextLength == 0)
            {
                MessageBox.Show("Вы не ввели индекс в поле\n'Введите символ/индекс/подстроку для замены'");
            }
            else 
            {
                try
                {
                    textBox4.Text = "Найденный символ: " + calc.GetSymbolByIndex(textBox1.Text, Convert.ToInt32(textBox3.Text));
                }
                catch
                {
                    MessageBox.Show("Вы ввели слишком большой индекс..\nПопробуйте еще раз!!");
                }
               
            }
            
 
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //length
            textBox4.Text = "Длина строки: " +  calc.GetLenght(textBox1.Text).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //change substr
            
            if (textBox3.TextLength == 0)
            {
                MessageBox.Show("Вы не ввели подстроку в поле\n'Введите символ/индекс/подстроку для замены'");
            }
            else
            {
                try
                {
                    textBox4.Text = "Измененная строка: " + calc.ChangeSubstr(textBox1.Text, textBox2.Text, textBox3.Text);
                }
                catch
                {
                    MessageBox.Show("Вы не ввели подстроку в поле\n'Введите подстроку, которую необходимо заменить'\nПопробуйте еще раз!!");
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //delete_substr
            
            if (textBox3.TextLength == 0)
            {
                MessageBox.Show("Вы не ввели подстроку в поле\n'Введите символ/индекс/подстроку для замены или удаления'");
            }
            else
            {
                try
                {
                    textBox4.Text = "Измененная строка: " + calc.DeleteSubstr(textBox1.Text, textBox3.Text);
                }
                catch
                {
                    MessageBox.Show("Что-то пошло не так..\nПопробуйте еще раз!!");
                }

            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //nums of symbols
            textBox4.Text = "Количество слов в строке: " + calc.NumOfWords(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //nums of vowels
            textBox4.Text = "Количество гласных в строке: " + calc.NumOfVowels(textBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //nums of consonants
            textBox4.Text = "Количество согласных в строке: " + calc.NumOfConsonants(textBox1.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //nums of sentences
            textBox4.Text = "Количество предложений: " + calc.NumOfSentences(textBox1.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("Инструкция:\n" +
                "Для выполнения всех операций необходимо ввести исходную строку в поле Введите строку.\n" +
                "Удаление подстроки: введите подстроку в поле Введите символ/индекс/подстроку " +
                "для замены или удаления после чего нажмите кнопку Удалить подстроку.\n" +
                "");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

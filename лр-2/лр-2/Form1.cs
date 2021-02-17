using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace лр_2
{
    public partial class Form1 : Form
    {
        
        public static Producer producer = new Producer();
        public Item item = new Item(producer);

        public Form1()
        {
            InitializeComponent();
            
           
            
        }

        public Form1(Form2 form2)
        {
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text == " " || textBox1.Text.Length == 0)
                e.Cancel = true; //не теряется фокуc  
            //if (textBox1.Text.Length == 0)
            //{
            //    MessageBox.Show("Вы не заполнили поле.");
            //    e.Cancel = true;
            //}
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
       
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //название товара
            
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //дата поступления
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //тип товара
            
        }
        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            if (comboBox1.Text == " " || comboBox1.Text.Length == 0)
                e.Cancel = true; //не теряется фокуc  
            //if (comboBox1.Text.Length == 0)
            //{
            //    MessageBox.Show("Вы не заполнили поле.");
            //    e.Cancel = true;
            //}
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //инвентарный номер
            //if (textBox2.Text.Length == 0)
            //{
            //    MessageBox.Show("Вы не заполнили поле.");
            //}
        }
        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text == " " || textBox2.Text.Length == 0)
                e.Cancel = true; //не теряется фокуc  
            //if (textBox2.Text.Length == 0)
            //{
            //    MessageBox.Show("Вы не заполнили поле.");
            //    e.Cancel = true;
            //}
        }
        public string radioChoice;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //xs-s
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                radioChoice =  radioButton1.Text;
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //m-l
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                radioChoice = radioButton2.Text;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //xl+
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                radioChoice = radioButton3.Text;
            }
        }
        
       

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //вес
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //количество товаров
        }
        private void numericUpDown1_Validating(object sender, CancelEventArgs e)
        {
            //количество товаров
            if (numericUpDown1.Value > numericUpDown1.Maximum)
            {
                MessageBox.Show("Максимальное количество товара 100.");
            }
            if (numericUpDown1.Value < numericUpDown1.Minimum)
            {
                MessageBox.Show("Минимальное количество товара 1.");
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            //цена
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(this);
            f.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            
            string output;
            output = "Название товара: " + this.textBox1.Text + "\r\n";
            output += "Инвентарный номер: " + this.textBox2.Text + "\r\n";
            output += "Размер: " + radioChoice + "\r\n";
            output += "Тип: " + this.comboBox1.Text + "\r\n";
            output += "Дата поступления: " + this.dateTimePicker1.Text + "\r\n";
            output += "Производитель: " + Form2.outputForm2 + "\r\n";
            output += "Вес: " + this.trackBar1.Value + "\r\n";
            output += "Количество товаров: " + this.numericUpDown1.Text + "\r\n";
            output += "Цена: " + this.trackBar2.Value + "\r\n";
            // Вставка нового текста.
            this.richTextOutput.Text = output;
        }

        
        XmlSerializer formatter = new XmlSerializer(typeof(Item));
        private void button1_Click(object sender, EventArgs e)
        {
            //запись в файл
            item.item_name = textBox1.Text;
            item.item_id  = Convert.ToInt32(textBox2.Text);
            item.item_size = radioChoice;
            item.item_date = dateTimePicker1.Text;
            item.item_producer = producer;
            item.item_type = comboBox1.Text;
            item.item_weight = trackBar1.Value;
            item.item_count = Convert.ToInt32(numericUpDown1.Text);
            item.item_cost = trackBar2.Value;

            using (FileStream fs = new FileStream(@"D:\uni\ооп\infoshop.xml", FileMode.OpenOrCreate))
            {
                try
                {
                    formatter.Serialize(fs, item);
                }
                catch
                {
                    MessageBox.Show("Что-то пошло не так..");
                }
                finally
                {
                    MessageBox.Show("Данные записаны в файл");
                }

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //чтение из файла
            using (FileStream fs = new FileStream(@"D:\uni\ооп\infoshop.xml", FileMode.OpenOrCreate))
            {

                Item itemfromfile = (Item)formatter.Deserialize(fs);

                this.richTextOutput.Text = "Из файла прочитано:\n";
                this.richTextOutput.Text += "Название товара: " + itemfromfile.item_name + "\r\n";
                this.richTextOutput.Text += "Инвентарный номер: " + itemfromfile.item_id + "\r\n";
                this.richTextOutput.Text += "Размер: " + itemfromfile.item_size + "\r\n";
                this.richTextOutput.Text += "Тип: " + itemfromfile.item_type + "\r\n";
                this.richTextOutput.Text += "Дата поступления: " + itemfromfile.item_date + "\r\n";
                this.richTextOutput.Text += "----------------" + "\r\n" + "Производитель: " 
                    + "ФИО: " + itemfromfile.item_producer.pr_fio + "\r\n"
                    + "Адрес: " + itemfromfile.item_producer.pr_address + "\r\n"
                    + "Огранизация: " + itemfromfile.item_producer.pr_company + "\r\n"
                    + "Страна: " + itemfromfile.item_producer.pr_country + "\r\n"
                    + "Телефон: " +  itemfromfile.item_producer.pr_phone + "\r\n" + "----------------" + "\r\n";
                this.richTextOutput.Text += "Вес: " + itemfromfile.item_weight + "\r\n";
                this.richTextOutput.Text += "Количество товаров: " + itemfromfile.item_count + "\r\n";
                this.richTextOutput.Text += "Цена: " + itemfromfile.item_cost + "\r\n";
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Инструкция\nКомкова А.В. 2021");
        }
    }
}

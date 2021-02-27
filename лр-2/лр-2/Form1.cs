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
       
        public List<Item> itemList = new List<Item> { };
        Form form3 = new Form3();
        public Form Form4 = new Form4();
        public int countItems = 0;

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
                label12.Visible = true;
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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
            //тип товара
            if (comboBox1.Text == " " || comboBox1.Text.Length == 0)
                label14.Visible = true;
            //    e.Cancel = true; //не теряется фокуc  

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //инвентарный номер

        }
        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text == " " || textBox2.Text.Length == 0)
                label13.Visible = true;
        }
        public string radioChoice;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //xs-s
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                radioChoice = radioButton1.Text;
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
          
            this.richTextOutput.Text = output;
           
        }



       
        XmlSerializer formatter = new XmlSerializer(typeof(List<Item>));
        private void button1_Click(object sender, EventArgs e)
        {
           
            //запись в файл
            item.item_name = textBox1.Text;
            item.item_id = Convert.ToInt32(textBox2.Text);
            item.item_size = radioChoice;
            item.item_date = dateTimePicker1.Text;
            item.item_producer = producer;
            item.item_type = comboBox1.Text;
            item.item_weight = trackBar1.Value;
            item.item_count = Convert.ToInt32(numericUpDown1.Text);
            item.item_cost = trackBar2.Value;

            //itemList.Add(new Item(textBox1.Text, 
            //    Convert.ToInt32(textBox2.Text),
            //    radioChoice,
            //    dateTimePicker1.Text,
            //    producer,
            //    comboBox1.Text,
            //    trackBar1.Value,
            //    Convert.ToInt32(numericUpDown1.Text),
            //    trackBar2.Value)
            //    );

            itemList.Add(new Item(textBox1.Text,
               Convert.ToInt32(textBox2.Text),
               radioChoice,
               dateTimePicker1.Text,
               new Producer(Form2.str_fio,
              Form2.str_company,
              Form2.str_address,
              Form2.str_phone,
              Form2.str_country
               ),
               comboBox1.Text,
               trackBar1.Value,
               Convert.ToInt32(numericUpDown1.Text),
               trackBar2.Value)
               );

            countItems++;
            using (FileStream fs = new FileStream(@"D:\uni\ооп\infoshop.xml", FileMode.OpenOrCreate))
            {
                try
                {
                    formatter.Serialize(fs, itemList);
     
                }
                catch
                {
                    MessageBox.Show("Что-то пошло не так..");
                }
                finally
                {
                    MessageBox.Show("Данные записаны в файл");
                }
                fs.Close();
            }
           

            deleteDataForm1();
            

        }
        //public string filename = @"D:\uni\ооп\infoshop.xml";
        public static class XmlSerializeWrapper
        {
            public static T Deserialize<T>(string filename)
            {
                T obj;
                using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
                {
                    XmlSerializer formatter = new XmlSerializer(typeof(T));
                    obj = (T)formatter.Deserialize(fs);
                }
                return obj;
            }
        }
        public static List<Item> listFromFile;
        private void button2_Click(object sender, EventArgs e)
        {
            
             listFromFile = XmlSerializeWrapper.Deserialize<List<Item>>(@"D:\uni\ооп\infoshop.xml");
            this.richTextOutput.Text = "Из файла прочитано:\n";
            foreach (Item itemFromFile in listFromFile)
            {
                this.richTextOutput.Text += "Название товара: " + itemFromFile.item_name + "\r\n";
                this.richTextOutput.Text += "Инвентарный номер: " + itemFromFile.item_id + "\r\n";
                this.richTextOutput.Text += "Размер: " + itemFromFile.item_size + "\r\n";
                this.richTextOutput.Text += "Тип: " + itemFromFile.item_type + "\r\n";
                this.richTextOutput.Text += "Дата поступления: " + itemFromFile.item_date + "\r\n";
                this.richTextOutput.Text += "----------------" + "\r\n" + "Производитель: "
                    + "ФИО: " + itemFromFile.item_producer.pr_fio + "\r\n"
                    + "Адрес: " + itemFromFile.item_producer.pr_address + "\r\n"
                    + "Огранизация: " + itemFromFile.item_producer.pr_company + "\r\n"
                    + "Страна: " + itemFromFile.item_producer.pr_country + "\r\n"
                    + "Телефон: " + itemFromFile.item_producer.pr_phone + "\r\n" + "----------------" + "\r\n";
                this.richTextOutput.Text += "Вес: " + itemFromFile.item_weight + "\r\n";
                this.richTextOutput.Text += "Количество товаров: " + itemFromFile.item_count + "\r\n";
                this.richTextOutput.Text += "Цена: " + itemFromFile.item_cost + "\r\n\n";

            }


        }


        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
        public void deleteDataForm1()
        {
            textBox1.Text = ""; //название товара
            textBox2.Text = ""; //инвентарный номер
            radioChoice = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            comboBox1.Text = "";
            trackBar1.Value = trackBar1.Minimum;
            trackBar2.Value = trackBar2.Minimum;
            numericUpDown1.Value = numericUpDown1.Minimum;
            richTextOutput.Text = "";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            deleteDataForm1();
        }

        private void label15_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Лабораторная работа 3\nКомкова А.В.\n2021");
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Инструкция\nКомкова А.В. 2021");
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //find -> ...
           
            form3.Show();
        }

        private void названиеToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //find -> item name
            form3.Show();
           

            //var selectedNames = from t in listFromFile 
            //                    where t.ToUpper().StartsWith("Б") //фильтрация по критерию
            //                    orderby t  // упорядочиваем по возрастанию
            //                    select t; // выбираем объект

            //foreach (var s in selectedNames)
                MessageBox.Show("");

        }

        private void textStatistics_TextChanged(object sender, EventArgs e)
        {
            this.textStatistics.Text = $"           {countItems}";
        }
        public static string result;
        private void dateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            result = "";
            var sortByDate = from i in itemList
                             orderby i.item_date
                             select i;
            foreach (Item s in sortByDate)
            {
                result += "----------------\n" + "Название товара: " + s.item_name + "\r\n";
                result += "Инвентарный номер: " + s.item_id + "\r\n";
                result += "Размер: " + s.item_size + "\r\n";
                result += "Тип: " + s.item_type + "\r\n";
                result += "Дата поступления: " + s.item_date + "\r\n";
                result += "Производитель: " + "\n"
                    + "ФИО: " + s.item_producer.pr_fio + "\r\n"
                    + "Адрес: " + s.item_producer.pr_address + "\r\n"
                    + "Огранизация: " + s.item_producer.pr_company + "\r\n"
                    + "Страна: " + s.item_producer.pr_country + "\r\n"
                    + "Телефон: " + s.item_producer.pr_phone + "\r\n";
                result += "Вес: " + s.item_weight + "\r\n";
                result += "Количество товаров: " + s.item_count + "\r\n";
                result += "Цена: " + s.item_cost + "\r\n" + "----------------\n";

            }

             MessageBox.Show(result);
           // Form4.Show();
        }

        private void countryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            result = "";
            var sortByCountry = from i in itemList
                                orderby i.item_producer.pr_country
                                select i;
            foreach (Item s in sortByCountry)
            {
                result += "----------------\n" + "Название товара: " + s.item_name + "\r\n";
                result += "Инвентарный номер: " + s.item_id + "\r\n";
                result += "Размер: " + s.item_size + "\r\n";
                result += "Тип: " + s.item_type + "\r\n";
                result += "Дата поступления: " + s.item_date + "\r\n";
                result += "Производитель: " + "\n"
                    + "ФИО: " + s.item_producer.pr_fio + "\r\n"
                    + "Адрес: " + s.item_producer.pr_address + "\r\n"
                    + "Огранизация: " + s.item_producer.pr_company + "\r\n"
                    + "Страна: " + s.item_producer.pr_country + "\r\n"
                    + "Телефон: " + s.item_producer.pr_phone + "\r\n";
                result += "Вес: " + s.item_weight + "\r\n";
                result += "Количество товаров: " + s.item_count + "\r\n";
                result += "Цена: " + s.item_cost + "\r\n" + "----------------\n";
            }
            MessageBox.Show(result);
            //Form4.Show();
        }

        private void nameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            result = "";
            var sortByName = from i in itemList
                             orderby i.item_name
                             select i;
            foreach (Item s in sortByName)
            {
                result += "----------------\n" + "Название товара: " + s.item_name + "\r\n";
                result += "Инвентарный номер: " + s.item_id + "\r\n";
                result += "Размер: " + s.item_size + "\r\n";
                result += "Тип: " + s.item_type + "\r\n";
                result += "Дата поступления: " + s.item_date + "\r\n";
                result += "Производитель: " + "\n"
                    + "ФИО: " + s.item_producer.pr_fio + "\r\n"
                    + "Адрес: " + s.item_producer.pr_address + "\r\n"
                    + "Огранизация: " + s.item_producer.pr_company + "\r\n"
                    + "Страна: " + s.item_producer.pr_country + "\r\n"
                    + "Телефон: " + s.item_producer.pr_phone + "\r\n";
                result += "Вес: " + s.item_weight + "\r\n";
                result += "Количество товаров: " + s.item_count + "\r\n";
                result += "Цена: " + s.item_cost + "\r\n" + "----------------\n";

            }
            MessageBox.Show(result);
            //Form4.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лр_2
{
    public partial class Form2 : Form
    {
        Form1 form1 = new Form1();

        public Form2(Form1 form1)
        {
            InitializeComponent();
            
        }
        public Form2()
        {
            InitializeComponent();

        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
            
        }
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text == " " || textBox1.Text.Length == 0)
                label7.Visible = true;
                //e.Cancel = true; //не теряется фокуc  
                
           
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text == " " || textBox2.Text.Length == 0)
                label8.Visible = true;
            // e.Cancel = true; //не теряется фокуc  

        }
        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (textBox3.Text == " " || textBox3.Text.Length == 0)
                label9.Visible = true;
            // e.Cancel = true; //не теряется фокуc  

        }
        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            if (comboBox1.Text == " " || comboBox1.Text.Length == 0)
                label10.Visible = true;
            // e.Cancel = true; //не теряется фокуc  

        }
        public static string outputForm2, str_fio, str_address, str_country, str_company,str_phone;
        private void button1_Click(object sender, EventArgs e)
        {
            Form1.lastOperation = "Вывод данных в форме Производитель";
            this.richTextBox1.Text = "ФИО: " + this.textBox1.Text + "\r\n";
            this.richTextBox1.Text += "Огранизация: " + this.textBox2.Text + "\r\n";
            this.richTextBox1.Text += "Страна: " + comboBox1.Text + "\r\n";
            this.richTextBox1.Text += "Адрес: " + this.textBox3.Text + "\r\n";
            this.richTextBox1.Text += "Телефон: " + maskedTextBox1.Text;

            str_fio = this.textBox1.Text;
            str_address = this.textBox3.Text;
            str_country = this.comboBox1.Text;
            str_phone = this.maskedTextBox1.Text;
            str_company = this.textBox2.Text;

            outputForm2 = this.richTextBox1.Text;
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1.lastOperation = "Запись данных в форме Производитель";
            form1.item.item_producer.pr_fio = this.textBox1.Text;
            form1.item.item_producer.pr_company = this.textBox2.Text;
            form1.item.item_producer.pr_country = this.comboBox1.Text;
            form1.item.item_producer.pr_address = this.textBox3.Text;
            form1.item.item_producer.pr_phone = this.maskedTextBox1.Text;
            MessageBox.Show("Данные успешно записаны!!");
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form1.lastOperation = "Help";
            MessageBox.Show("Инструкция\nКомкова А.В. 2021");
        }

       
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (maskedTextBox1.Text == " " || maskedTextBox1.Text.Length == 0)
                label11.Visible = true;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        public void deleteDataForm2()
        {
           
            textBox1.Text = ""; //фио
            textBox2.Text = ""; //организация
            textBox3.Text = ""; //адрес
            maskedTextBox1.Text = ""; //телефон
            comboBox1.Text = "";//страна
            richTextBox1.Text = "";

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form1.lastOperation = "Сброс данных в форме Производитель";
            deleteDataForm2();
        }
    }
}

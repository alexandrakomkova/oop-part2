﻿using System;
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
        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (textBox3.Text == " " || textBox3.Text.Length == 0)
                e.Cancel = true; //не теряется фокуc  
            //if (textBox3.Text.Length == 0)
            //{
            //    MessageBox.Show("Вы не заполнили поле.");
            //    e.Cancel = true;
            //}
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
        public static string outputForm2;
        private void button1_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "ФИО: " + this.textBox1.Text + "\r\n";
            this.richTextBox1.Text += "Огранизация: " + this.textBox2.Text + "\r\n";
            this.richTextBox1.Text += "Страна: " + comboBox1.Text + "\r\n";
            this.richTextBox1.Text += "Адрес: " + this.textBox3.Text + "\r\n";
            this.richTextBox1.Text += "Телефон: " + maskedTextBox1.Text;

            outputForm2 = this.richTextBox1.Text;
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
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
            MessageBox.Show("Инструкция\nКомкова А.В. 2021");
        }
    }
}

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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textFindName_TextChanged(object sender, EventArgs e)
        {
           
        }

        
        public static void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void backToForm1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {


            var selectedItems = from t in Form1.listFromFile // определяем каждый объект из teams как t
                                where t.item_name == this.textFindName.Text //фильтрация по критерию
                                select t; // выбираем объект

            foreach (Item i in selectedItems)
            {
                this.richFindResult.Text += "Название товара: " + i.item_name + "\r\n";
                this.richFindResult.Text += "Инвентарный номер: " + i.item_id + "\r\n";
                this.richFindResult.Text += "Размер: " + i.item_size + "\r\n";
                this.richFindResult.Text += "Тип: " + i.item_type + "\r\n";
                this.richFindResult.Text += "Дата поступления: " + i.item_date + "\r\n";
                this.richFindResult.Text += "----------------" + "\r\n" + "Производитель: "
                    + "ФИО: " + i.item_producer.pr_fio + "\r\n"
                    + "Адрес: " + i.item_producer.pr_address + "\r\n"
                    + "Огранизация: " + i.item_producer.pr_company + "\r\n"
                    + "Страна: " + i.item_producer.pr_country + "\r\n"
                    + "Телефон: " + i.item_producer.pr_phone + "\r\n" + "----------------" + "\r\n";
                this.richFindResult.Text += "Вес: " + i.item_weight + "\r\n";
                this.richFindResult.Text += "Количество товаров: " + i.item_count + "\r\n";
                this.richFindResult.Text += "Цена: " + i.item_cost + "\r\n\n";

            }
        }

        private void richFindResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

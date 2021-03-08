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
            this.Hide();
        }
        public IEnumerable<Item> selectedItems;
        public void findName() 
        {
            try
            {
                selectedItems = from t in Form1.itemList // определяем каждый объект из teams как t
                                where t.item_name == this.textFindName.Text //фильтрация по критерию
                                select t; // выбираем объект
            }
            catch 
            {
                MessageBox.Show("Добавьте для начала товар");
            }
            
        }
        public void findType()
        {

            try
            {
                selectedItems = from t in Form1.itemList // определяем каждый объект из teams как t
                                where t.item_type == this.comboFindType.Text //фильтрация по критерию
                                select t; // выбираем объект
            }
            catch
            {
                MessageBox.Show("Добавьте для начала товар");
            }

        }
        public void findPrice()
        {
            try
            {
                selectedItems = from t in Form1.itemList // определяем каждый объект из teams как t
                                where t.item_cost > Convert.ToInt32(this.textPriceLow.Text) &&
                                t.item_cost < Convert.ToInt32(this.textPriceUp.Text)
                                //фильтрация по критерию
                                select t; // выбираем объект
            }
            catch
            {
                MessageBox.Show("Добавьте для начала товар");
            }

        }
        public void printFind() 
        {
            try
            {
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
            catch
            {
                MessageBox.Show("Что-то пошло не так");
            }
        }
       

        private void richFindResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void comboFindType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void buttonFind_Validating(object sender, CancelEventArgs e)
        {
            if (Form1.itemList.Count == 0) 
            {
                MessageBox.Show("Добавьте товар в главном окне для дальнейшей работы.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textFindName.Text = "";
            this.comboFindType.Text = "";
            
            this.richFindResult.Text = "";
            selectedItems.ToList().Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            this.textPriceLow.Text = "0";
            this.textPriceUp.Text = "10";
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked) 
            {
                findName();
            }
            Form1.lastOperation = "Поиск по имени товара";
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                findType();
            }
            Form1.lastOperation = "Поиск по типу товара";
            if ((checkBox1.Checked && checkBox2.Checked) || (checkBox2.Checked && checkBox1.Checked))
            {
                selectedItems = from t in Form1.itemList // определяем каждый объект из teams как t
                                from a in Form1.itemList
                                where t.item_type == this.comboFindType.Text //фильтрация по критерию
                                //фильтрация по критерию
                                where a.item_name == this.textFindName.Text
                                select t; // выбираем объект
            }
            if ((checkBox2.Checked && checkBox3.Checked) || (checkBox3.Checked && checkBox2.Checked))
            {
                selectedItems = from t in Form1.itemList // определяем каждый объект из teams как t
                                from a in Form1.itemList
                                where t.item_type == this.comboFindType.Text //фильтрация по критерию
                                                                             //фильтрация по критерию
                                where a.item_cost > Convert.ToInt32(this.textPriceLow.Text) &&
                               a.item_cost < Convert.ToInt32(this.textPriceUp.Text)
                                select t; // выбираем объект
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                findPrice();
            }
            Form1.lastOperation = "Поиск по цене товара";
            
            if ((checkBox1.Checked && checkBox3.Checked) || (checkBox3.Checked && checkBox1.Checked))
            {
                selectedItems = from t in Form1.itemList // определяем каждый объект из teams как t
                                from a in Form1.itemList
                                where t.item_cost > Convert.ToInt32(this.textPriceLow.Text) &&
                                t.item_cost < Convert.ToInt32(this.textPriceUp.Text)
                                //фильтрация по критерию
                                where a.item_name == this.textFindName.Text
                                select t; // выбираем объект
            }

        }
        private void buttonFind_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false &&
                checkBox2.Checked == false &&
                checkBox3.Checked == false 
                )
            {
                MessageBox.Show("Поставьте галочку для поиска");
            }

            printFind();
            Form1.lastOperation = "Вывод найденной информации";

        }
    }
}

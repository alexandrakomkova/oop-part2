using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace лр_2
{
    [Serializable]
    [XmlRoot(Namespace = "лр_2")]
    [XmlType("Item")]

    public class Item
    {

        [Required(ErrorMessage = "Имя товара не установлено")]
        [XmlElement(ElementName = "item_name")]
        public string item_name { get; set; }
        [Required(ErrorMessage = "Идентификатор товара не установлен")]
        [XmlElement(ElementName = "item_id")]
        public int item_id { get; set; }
        [Required(ErrorMessage = "Размер товара не установлен")]
        [XmlElement(ElementName = "item_size")] 
        public string item_size{ get; set; }

        [Required(ErrorMessage = "Дата поставки товара не установлена")]
        [XmlElement(ElementName = "item_date")] 
        public string item_date { get; set; }

        [Required(ErrorMessage = "Тип товара не установлен")]
        [XmlElement(ElementName = "item_type")] 
        public string item_type { get; set; }

        [XmlElement(ElementName = "item_weight")] 
        public int item_weight{ get; set; }

        [XmlElement(ElementName = "item_count")] 
        public int item_count { get; set; }

        [XmlElement(ElementName = "item_cost")]
        public int item_cost { get; set; }
        public Producer item_producer { get; set; }
       
        public Item()
        {
            
        }
        public Item(string item_name, int item_id, string item_size, string item_date,
           Producer producer, string item_type, int item_weight, int item_cost, int item_count)
        {
            this.item_name = item_name;
            this.item_id = item_id;
            this.item_size = item_size;
            this.item_date = item_date;
            this.item_producer = producer;
            this.item_type = item_type;
            this.item_weight = item_weight;
            this.item_count = item_count;
            this.item_cost = item_cost;
        }
       
        public Item(Producer producer)
        {
            this.item_producer = producer;
        }
       
    }
    [Serializable]
    public class Producer
    {
        [XmlElement(ElementName = "pr_fio")]
        public string pr_fio { get; set; }
        [XmlElement(ElementName = "pr_company")]
        public string pr_company{get; set; }
        [XmlElement(ElementName = "pr_address")]
        public string pr_address { get; set; }
        [XmlElement(ElementName = "pr_phone")]
        public string pr_phone { get; set; }
        [XmlElement(ElementName = "pr_country")]
        public string pr_country { get; set; }
        public Producer() { }
        public Producer(
            string pr_fio, 
            string pr_company, 
            string pr_address, 
            string pr_phone, 
            string pr_country )
        {
            this.pr_fio = pr_fio;
            this.pr_company = pr_company;
            this.pr_address = pr_address;
            this.pr_phone = pr_phone;
            this.pr_country = pr_country;
        }

    }
   

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

using System;
using System.Collections.Generic;
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
        [XmlElement(ElementName = "item_name")]
        public string item_name { get; set; }

        [XmlElement(ElementName = "item_id")]
        public int item_id { get; set; }

        [XmlElement(ElementName = "item_size")] 
        public string item_size{ get; set; }

        [XmlElement(ElementName = "item_date")] 
        public string item_date { get; set; }

        [XmlElement(ElementName = "item_producer")] 
        public string item_producer { get; set; }

        [XmlElement(ElementName = "item_type")] 
        public string item_type { get; set; }

        [XmlElement(ElementName = "item_weight")] 
        public int item_weight{ get; set; }

        [XmlElement(ElementName = "item_count")] 
        public int item_count { get; set; }

        [XmlElement(ElementName = "item_cost")] 
        public int item_cost { get; set; }
        public Item()
        {
            
        }
        public Item(string item_name, int item_id, string item_size, string item_date,
            string item_producer, string item_type, int item_weight, int item_cost, int item_count)
        {
            this.item_name =  item_name;
            this.item_id = item_id;
            this.item_size = item_size;
            this.item_date = item_date;
            this.item_producer = item_producer;
            this.item_type = item_type;
            this.item_weight = item_weight;
            this.item_count = item_count;
            this.item_cost = item_cost;
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

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace лр_2
{
    [Serializable]
    [XmlRoot(Namespace = "лр_2")]
    [XmlType("Item")]
    public class IdAttribute : ValidationAttribute
    {
        
        public override bool IsValid(object value)
        {
            var i = value as Item;
            if (i.item_id == 0)
            {
                this.ErrorMessage = "Идентификационный номер не может быть равен 0.";
                return false;
            }
            return true;
        }
    }

    public abstract class State 
    {
        public abstract new string ToString();
    }
    public class New : State 
    {
        public override string ToString() 
        {
            return "новинка!";
        }
    }
    public class Old : State 
    {
        public override string ToString()
        {
            return "обычный товар";
        }
    }
    public interface IFactory
    {
        State CreateState();
    }
    public class NewFactory : IFactory
    {
        public State CreateState()
        { return new New(); }
    }
    public class OldFactory : IFactory
    {
        public State CreateState()
        { return new Old(); }
    }



    public class Item
    {

        [Required(ErrorMessage = "Имя товара не установлено")]
        [XmlElement(ElementName = "item_name")]
        public string item_name { get; set; }
        [Id]
        [Required]
        [XmlElement(ElementName = "item_id")]
        public int item_id { get; set; }
        [Required]
        [XmlElement(ElementName = "item_size")]
        public string item_size { get; set; }

        [Required]
        [XmlElement(ElementName = "item_date")]
        public string item_date { get; set; }

        [Required]
        [XmlElement(ElementName = "item_type")]
        public string item_type { get; set; }

        [Required]
        [XmlElement(ElementName = "item_weight")]
        public int item_weight { get; set; }

        [Required]
        [XmlElement(ElementName = "item_count")]
        public int item_count { get; set; }


        [XmlElement(ElementName = "item_cost")]
        public int item_cost { get; set; }
        [XmlElement(ElementName = "producer")]
        [Required(ErrorMessage = "Производитель товара не установлен")]
        public Producer item_producer { get; set; }

        [XmlElement(ElementName = "item_new")]
        public string item_new { get; set; }

        public Item()
        {

        }
        public Item(string item_name, int item_id, string item_size, string item_date,
           Producer producer, string item_type, int item_weight, int item_cost, int item_count, string item_new)
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
            this.item_new = item_new;
        }

        public Item(Producer producer)
        {
            this.item_producer = producer;
           
        }

    }

    public abstract class ProducerBuilder
    {
        public Producer Producer { get; private set; }
        public void CreateProducer()
        {
            Producer = new Producer();
        }
        public abstract void SetName(string fio);
        public abstract void SetCompany(string company);
        public abstract void SetAddress(string address);
        public abstract void SetPhone(string phone);
        public abstract void SetCountry(string country);
    }
    //[Serializable]
    //public class Producer
    //{
    //    [XmlElement(ElementName = "pr_fio")]
    //    public string pr_fio { get; set; }
    //    [XmlElement(ElementName = "pr_company")]
    //    public string pr_company { get; set; }
    //    [XmlElement(ElementName = "pr_address")]
    //    public string pr_address { get; set; }
    //    [XmlElement(ElementName = "pr_phone")]
    //    public string pr_phone { get; set; }
    //    [XmlElement(ElementName = "pr_country")]
    //    public string pr_country { get; set; }
    //    public Producer() { }
    //    public Producer(
    //        string pr_fio,
    //        string pr_company,
    //        string pr_address,
    //        string pr_phone,
    //        string pr_country)
    //    {
    //        this.pr_fio = pr_fio;
    //        this.pr_company = pr_company;
    //        this.pr_address = pr_address;
    //        this.pr_phone = pr_phone;
    //        this.pr_country = pr_country;
    //    }

    //}
    [Serializable]
    public class Producer
    {
        [XmlElement(ElementName = "pr_fio")]
        public string pr_fio { get; set; }
        [XmlElement(ElementName = "pr_company")]
        public string pr_company { get; set; }
        [XmlElement(ElementName = "pr_address")]
        public string pr_address { get; set; }
        [XmlElement(ElementName = "pr_phone")]
        public string pr_phone { get; set; }
        [XmlElement(ElementName = "pr_country")]
        public string pr_country { get; set; }
    }
    [Serializable]
    public class Producer1 : ProducerBuilder
    {

        public override void SetName(string fio)
        {
            this.Producer.pr_fio = fio;
        }
        public override void SetCompany(string company)
        {
            this.Producer.pr_company = company;
        }
        public override void SetAddress(string address)
        {
            this.Producer.pr_address = address;
        }
        public override void SetPhone(string phone)
        {
            this.Producer.pr_phone = phone;
        }
        public override void SetCountry(string country)
        {
            this.Producer.pr_country = country;
        }
    }
    public class MakeProducer
    {
        public Producer Make(ProducerBuilder prBuilder)
        {
            prBuilder.CreateProducer();
            prBuilder.SetName(Form2.str_fio);
            prBuilder.SetAddress(Form2.str_address);
            prBuilder.SetCompany(Form2.str_company);
            prBuilder.SetCountry(Form2.str_country);
            prBuilder.SetPhone(Form2.str_phone);
            return prBuilder.Producer;
        }
    }
    public sealed class Setting
    {
        private static Setting _instance;
        private Setting()
        { }
        public static Setting GetInstance()
        {
            return _instance ?? (_instance = new Setting());
        }
        public static void someBusinessLogic(Form f)
        {
           f.BackColor = ColorTranslator.FromHtml("#FFF0F5");
           f.Font = new Font("Times New Roman", 10, FontStyle.Italic);
           f.Size = new Size(1000, 600);
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

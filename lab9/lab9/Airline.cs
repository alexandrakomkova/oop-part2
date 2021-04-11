using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Xml.Serialization;
using System.Windows.Controls;
using lab9.CustomControls;

namespace lab9
{

    public interface IEnumerable
    {
        IEnumerator GetEnumerator();
    }
    [Serializable]
    [XmlRoot(Namespace = "lab9")]
    [XmlType("Airline")]
    public class Airline : DependencyObject
    {
        public static readonly DependencyProperty PriceProperty;
        

        [XmlElement(ElementName = "id")]
        public int f_id { get; set; } //автоматически считается
        [XmlElement(ElementName = "company")]
        public string f_company { get; set; }

        [XmlElement(ElementName = "from")]
        public string f_from { get; set; }
        [XmlElement(ElementName = "to")]
        public string f_toPoint { get; set; }
       
        //public int f_price
        //{
        //    get ; 
        //    set ; 
        //}
        [XmlElement(ElementName = "shortcode")]
        public string f_shortname { get; set; } //состоит из откуда-куда без гласных и в ап

        [XmlElement(ElementName = "fullcode")]
        public string f_fullname { get; set; } //состоит из откуда-куда

        [XmlElement(ElementName = "imageURL")]
        public string imagePath { get; set; } = @"D:\no_image.png";



        public Airline()
        {

        }
        static Airline() 
        {
            FrameworkPropertyMetadata metadata = new FrameworkPropertyMetadata();
            metadata.CoerceValueCallback = new CoerceValueCallback(CorrectValue);
            PriceProperty = DependencyProperty.Register(
                    "Txt", typeof(int), typeof(Airline), metadata, new ValidateValueCallback(ValidateValue));
        }

        public Airline(
            int f_id,
            string f_company,
            string f_from,
            string f_toPoint,
            int f_price,
            string f_shortname,
            string f_fullname,
            string imagePath
            )
        {
           
            this.f_id = f_id;
            this.f_company = f_company;
            this.f_from = f_from;
            this.f_toPoint = f_toPoint;
            this.f_price = f_price;
            this.f_fullname = f_fullname;
            this.f_shortname = f_shortname;
            this.imagePath = imagePath;
        }
        private static bool ValidateValue(object value)
        {
            int currentValue = (int)value;
            if (currentValue >= 0) // если текущее значение от нуля и выше
                return true;
            return false;
        }
        private static object CorrectValue(DependencyObject d, object baseValue)
        {
            int currentValue = (int)baseValue;
            if (currentValue > 9000)  // если больше 1000, возвращаем 1000
                return 9000;
            return currentValue; // иначе возвращаем текущее значение
        }
        [XmlElement(ElementName = "price")]
        public int f_price
        {
            get { return (int)GetValue(PriceProperty); }
            set { SetValue(PriceProperty, value); }
        }
        public Airline Clone()
        {
            return new Airline(
                this.f_id, 
                this.f_company, 
                this.f_from, 
                this.f_toPoint, 
                this.f_price, 
                this.f_fullname, 
                this.f_shortname,
                this.imagePath);
        }
       
    }
    public class AirlineList : IEnumerable
    {
        [XmlArray("Collection"), XmlArrayItem("Airline")]
        public ObservableCollection<Airline> list { get; set; }
       
        public AirlineList()
        {
            list = new ObservableCollection<Airline> { };
        }

        public void AddItem(Airline obj)
        {
            list.Add(obj.Clone());
        }
        public IEnumerator GetEnumerator()
        {
            return list.GetEnumerator();
        }
        public event EventHandler Changed = delegate { };
        public virtual void OnChanged()
        {
            Changed(this, EventArgs.Empty);
        }

    }
   
    public static class Serializer
    {
        
            public static void Serialize<T>(T obj, string filename)
            {
                XmlSerializer formatter = new XmlSerializer(typeof(T));
                using (FileStream fs = new FileStream(filename, FileMode.Create))
                {
                    formatter.Serialize(fs, obj);
                }
            }

        public static T Deserialize<T>(string filename)
        {

            T obj;

            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                obj = (T)serializer.Deserialize(fs);
            }
            return obj;

        }
       


      
    }
}

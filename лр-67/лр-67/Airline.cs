using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Xml.Serialization;

namespace лр_67
{

    public interface IEnumerable
    {
        IEnumerator GetEnumerator();
    }
    [Serializable]
    [XmlRoot(Namespace = "лр_67")]
    [XmlType("Airline")]
    public class Airline 
    {
        [XmlElement(ElementName = "id")]
        public int f_id { get; set; } //автоматически считается
        [XmlElement(ElementName = "company")]
        public string f_company { get; set; }

        [XmlElement(ElementName = "from")]
        public string f_from { get; set; }
        [XmlElement(ElementName = "to")]
        public string f_toPoint { get; set; }
        [XmlElement(ElementName = "price")]
        public int f_price { get; set; }
        [XmlElement(ElementName = "shortcode")]
        public string f_shortname { get; set; } //состоит из откуда-куда без гласных и в ап

        [XmlElement(ElementName = "fullcode")]
        public string f_fullname { get; set; } //состоит из откуда-куда

        [XmlElement(ElementName = "imageURL")]
        public string imagePath { get; set; }
      

        public Airline()
        {

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
        //public Food Last()
        //{
        //    return list[list.Count - 1];
        //}
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
        public static AirlineList MyXMLDeserializer()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(AirlineList));
            using (FileStream fs = new FileStream($"airlines.xml", FileMode.OpenOrCreate))
            {
                var restObj = xmlSerializer.Deserialize(fs) as AirlineList;
                fs.Close();
                return (restObj);
            }
        }


      
    }
}

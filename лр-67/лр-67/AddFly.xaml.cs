using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace лр_67
{
    /// <summary>
    /// Логика взаимодействия для AddFly.xaml
    /// </summary>
    /// 
    [Serializable]
    [XmlRoot(Namespace = "лр_67")]
    [XmlType("Airline")]
    public class Airline
    {
        [XmlElement(ElementName = "id")]
        int f_id { get; set; } //автоматически считается
        [XmlElement(ElementName = "company")]
        string f_company { get; set; }

        [XmlElement(ElementName = "from")]
        string f_from { get; set; }
        [XmlElement(ElementName = "to")]
        string f_toPoint { get; set; }
        [XmlElement(ElementName = "price")]
        int f_price { get; set; }
        [XmlElement(ElementName = "shortcode")]
        string f_shortname { get; set; } //состоит из откуда-куда без гласных и в ап

        [XmlElement(ElementName = "fullcode")]
        string f_fullname { get; set; } //состоит из откуда-куда

        [XmlElement(ElementName = "type")]
        string f_type { get; set; }
        [XmlIgnore]
        BitmapImage image { get; set; }

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
            string f_type
            )
        {
            this.f_id = f_id;
            this.f_company = f_company;
            this.f_from = f_from;
            this.f_toPoint = f_toPoint;
            this.f_price = f_price;
            this.f_fullname = f_fullname;
            this.f_shortname = f_shortname;
            this.f_type = f_type;
        }
    }
    public partial class AddFly : Window
    {
        public AddFly()
        {
            InitializeComponent();
        }

        public static Airline airline = new Airline();
        public static List<Airline> airlineList = new List<Airline> { };
        public static int countAir = 0;
        XmlSerializer formatter = new XmlSerializer(typeof(List<Airline>));

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            // ofd.Filter = "Image Files(*.BMP, *.PNG, *.JPG, *.JPEG)|*.BMP, *.PNG, *.JPG, *.JPEG|All Files (*.*)|*.*";
            ofd.Filter = "Image Files(*.bmp, *.PNG, *.jpg, *.JPEG)|*.BMP, *.PNG, *.jpg, *.JPEG|All Files (*.*)|*.*";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
            {
                try
                {
                    ImageCompany.Source = new BitmapImage(new Uri(ofd.FileName));
                }
                catch 
                {
                    System.Windows.MessageBox.Show("Не удалось загрузить картинку");
                }
            }
        }
        public string transformStr(string str) 
        {
            //string[] voc = { "A", "O", "E", "Y", "I" , "А", "О", "У", "Е", "И", "Я", "Ы", "Э", "Ю", "Ё" };
            //str.Trim();
            //str.Replace(" ", "");
            //for (int i = 0; i < voc.Length; i++)
            //{
            //    str.Replace(voc[i], "");
            //}
            str.ToUpper();
            return str;
        }
        public string makeShortname(string f_from, string f_to) 
        {
            return $"{transformStr(f_from)}-{transformStr(f_to)}";
        }
        public string makeFullname(string f_from, string f_to)
        {
            return $"{f_from}-{f_to}";
        }
        private void Serialize_Click(object sender, RoutedEventArgs e)
        {
            string s = "s";
            //airlineList.Add(
            //    new Airline(
            //        countAir++,
            //        CompanyTB.Text,
            //        FlyFromTB.Text,
            //        FlyToTB.Text,
            //        Convert.ToInt32(PriceTB.Text),
            //        makeShortname(FlyFromTB.Text, FlyToTB.Text),
            //        makeFullname(FlyFromTB.Text, FlyToTB.Text),
            //        s
            //        )
            //    ); 

            
                using (FileStream fs = new FileStream(@"D:\uni\ооп\airlines.xml", FileMode.OpenOrCreate))
                {
                    try
                    {
                        //formatter.Serialize(fs, airlineList);
                        System.Windows.MessageBox.Show(
                        //CompanyTB.Text+
                        //FlyFromTB.Text+
                        //FlyToTB.Text+
                        //Convert.ToInt32(PriceTB.Text)+
                        makeShortname(FlyFromTB.Text, FlyToTB.Text)//+
                        //makeFullname(FlyFromTB.Text, FlyToTB.Text)+
                        //s
                        );

                    }
                    catch
                    {
                        System.Windows.MessageBox.Show("Что-то пошло не так..");
                    }
                    finally
                    {
                        System.Windows.MessageBox.Show("Данные записаны в файл");
                    }
                    fs.Close();
                }
            
            
        }
    }
}

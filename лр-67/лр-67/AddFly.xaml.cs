using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
   
    public partial class AddFly : Window
    {
        public static Airline airline = new Airline();
        public static AirlineList airlineList = new AirlineList();
        public static int countAir = 0;

        // public string path = "airlines.xml";
        string path = @"D:\uni\ооп\лр-67\лр-67\bin\Debug\airlines.xml";
        public AddFly()
        {
            InitializeComponent();
            // 
           
            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                airlineList = Serializer.Deserialize<AirlineList>(path);
                //airlineList = Serializer.MyXMLDeserializer();
                foreach (var flyFromFile in airlineList)
                {
                    countAir++;
                }

            }
        }

        
        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            
            ofd.Filter = "Фотографии|*.jpg;*.png;*.jpeg| All Files (*.*)|*.*";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
            {
                try
                {
                    ImageCompany.Source = new BitmapImage(new Uri(ofd.FileName));
                    airline.imagePath = ofd.FileName;
                    //System.Windows.Forms.MessageBox.Show(airline.imagePath);
                }
                catch 
                {
                    System.Windows.MessageBox.Show("Не удалось загрузить картинку");
                }
            }
        }
        public string transformStr(string str)
        {
            string[] voc = { "A", "O", "E", "Y", "I", "А", "О", "У", "Е", "И", "Я", "Ы", "Э", "Ю", "Ё" };
            str = str.ToUpper();
            str = str.Trim();
            str = str.Replace(" ", "");
            for (int i = 0; i < voc.Length; i++)
            {
                str = str.Replace(voc[i], "");
                Console.WriteLine(str);
            }

            return str;
        }
        public string makeShortname(string f_from, string f_to)
        {
            return $"{transformStr(f_from)}-{transformStr(f_to)}";
        }
        public string makeFullname(string f_from, string f_to)
        {
            
            return $"{f_from.ToUpper()}-{f_to.ToUpper()}";
        }
        
        private void Serialize_Click(object sender, RoutedEventArgs e)
        {
            airline.f_id = countAir++;
            airline.f_company = CompanyTB.Text;
            airline.f_from = FlyFromTB.Text;
            airline.f_toPoint = FlyToTB.Text;
            airline.f_price = Convert.ToInt32(PriceTB.Text);
            airline.f_shortname = makeShortname(FlyFromTB.Text, FlyToTB.Text);
            airline.f_fullname = makeFullname(FlyFromTB.Text, FlyToTB.Text);
            airlineList.AddItem(airline);
            //MainWindow mainWindow = new MainWindow();
            //mainWindow.TemplateGrid.Visibility = Visibility.Visible;

            try
            {
                Serializer.Serialize<AirlineList>(airlineList, path);
                        //System.Windows.MessageBox.Show(
                        ////CompanyTB.Text+
                        ////FlyFromTB.Text+
                        ////FlyToTB.Text+
                        ////Convert.ToInt32(PriceTB.Text)+
                        //makeShortname(FlyFromTB.Text, FlyToTB.Text)+"\n"+
                        //makeFullname(FlyFromTB.Text, FlyToTB.Text)
                         //);

            }
             catch
            {
                System.Windows.MessageBox.Show("Что-то пошло не так..");
            }
             finally
            {
                System.Windows.MessageBox.Show("Данные записаны в файл");
                Clear();
            }

           


        }
        public void Clear()
        {
          
            CompanyTB.Text="";
            FlyFromTB.Text="";
            FlyToTB.Text="";
            PriceTB.Text="";
            ImageCompany.Source = null;


        }

        

        private void PriceTB_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PriceTB_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            string Symbol = e.Key.ToString();
            if (!Regex.Match(Symbol, @"[0-9]").Success && e.Key != Key.Back && e.Key != Key.OemPeriod && e.Key != Key.OemComma)
            {
                e.Handled = true;
            }
        }
    }
}

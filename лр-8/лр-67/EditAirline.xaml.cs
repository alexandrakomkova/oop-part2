using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace лр_67
{
    /// <summary>
    /// Логика взаимодействия для EditAirline.xaml
    /// </summary>
    public partial class EditAirline : Window
    {
        public AirlineList airlineList = new AirlineList();
        ObservableCollection<Airline> list = new ObservableCollection<Airline>();
        public Airline temp = new Airline();
        int flyToEdit = 0;

        string path = "airlines.xml";
        
        public EditAirline()
        {
            InitializeComponent();
            
        }
        public EditAirline(AirlineList airlineList, object indxToEdit)
        {
            InitializeComponent();
            
            
            this.airlineList = airlineList;
            this.flyToEdit = (int)indxToEdit;
            int num = 0;
            foreach (Airline i in airlineList.list)
            {
                if (num == this.flyToEdit)
                {
                    CompanyTB.Text = i.f_company;
                    FlyFromTB.Text = i.f_from;
                    FlyToTB.Text = i.f_toPoint;
                    PriceTB.Text = i.f_price.ToString();
                    ImageCompany.Source = new BitmapImage(new Uri(i.imagePath, UriKind.Absolute));
                    airlineList.list.Remove(i);
                    Serializer.Serialize(airlineList, path);
                  
                    
                    
                    break;
                }
                num++;
            }
           
            
           

        }
        private void SaveChanges_Click(object sender, RoutedEventArgs e)
        {
            temp.f_id = flyToEdit + 1000;
            temp.f_company = CompanyTB.Text;
            temp.f_from = FlyFromTB.Text;
            temp.f_toPoint = FlyToTB.Text;
            temp.f_price = Convert.ToInt32(PriceTB.Text);
            temp.f_shortname = AddFly.makeShortname(FlyFromTB.Text, FlyToTB.Text);
            temp.f_fullname = AddFly.makeFullname(FlyFromTB.Text, FlyToTB.Text);
            //ТУТ ТОЖЕ ПОМЕНЯЛ САНЯ САНЯ
            temp.imagePath = ImageCompany.Source.ToString();
            airlineList.AddItem(temp);
            Serializer.Serialize(airlineList, path);
            



            this.Close();
        }
        public void Clear()
        {

            CompanyTB.Text = "";
            FlyFromTB.Text = "";
            FlyToTB.Text = "";
            PriceTB.Text = "";
            ImageCompany.Source = null;


        }

        private void CompanyTB_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void FlyFromTB_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void FlyToTB_TextChanged(object sender, TextChangedEventArgs e)
        {

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
        public string image;
        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Фотографии|*.jpg;*.png;*.jpeg| All Files (*.*)|*.*";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    ImageCompany.Source = new BitmapImage(new Uri(ofd.FileName));
                   
                    //System.Windows.Forms.MessageBox.Show(airline.imagePath);
                }
                catch
                {
                    System.Windows.MessageBox.Show("Не удалось загрузить картинку");
                }
            }
        }
    }
}

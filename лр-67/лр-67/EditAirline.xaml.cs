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
        public Airline tempAirline = new Airline();
        int flyToEdit = 0;
        string path = @"D:\uni\ооп\лр-67\лр-67\bin\Debug\airlines.xml";
        
        public EditAirline()
        {
            InitializeComponent();
            
        }
        public EditAirline(AirlineList airlineList, object indxToEdit)
        {
            InitializeComponent();
            this.airlineList = airlineList;
            // this.flyToEdit = (int)indxToEdit;
            // int num = 0;
            //MainWindow window = new MainWindow();
            //Airline temp = (Airline)window.ListViewCollection.SelectedItem;

            //CompanyTB.Text = temp.f_company;
            //FlyFromTB.Text = temp.f_from;
            //FlyToTB.Text = temp.f_toPoint;
            //PriceTB.Text = temp.f_price.ToString();
            //ImageCompany.Source = new BitmapImage(new Uri(temp.imagePath));



            //temp = new Airline();
            //temp.f_id = flyToEdit + 1000;
            //temp.f_company = CompanyTB.Text;
            //temp.f_from = FlyFromTB.Text;
            //temp.f_toPoint = FlyToTB.Text;
            //temp.f_price = Convert.ToInt32(PriceTB.Text);
            //temp.f_shortname = AddFly.makeShortname(FlyFromTB.Text, FlyToTB.Text);
            //temp.f_fullname = AddFly.makeFullname(FlyFromTB.Text, FlyToTB.Text);
            //temp.imagePath = image;
            //foreach (Airline airline in airlineList.list)
            //{
            //    if (airline == (Airline)window.ListViewCollection.SelectedItem)
            //    {
            //        airlineList.list[airlineList.list.IndexOf(airline)] = temp;
            //        break;
            //    }
            //}
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
                    ImageCompany.Source = new BitmapImage(new Uri(i.imagePath));
                    break;
                }
                num++;
            }
            //Airline temp = new Airline();
            //temp.f_id = flyToEdit + 1000;
            //temp.f_company = CompanyTB.Text;
            //temp.f_from = FlyFromTB.Text;
            //temp.f_toPoint = FlyToTB.Text;
            //temp.f_price = Convert.ToInt32(PriceTB.Text);
            //temp.f_shortname = AddFly.makeShortname(FlyFromTB.Text, FlyToTB.Text);
            //temp.f_fullname = AddFly.makeFullname(FlyFromTB.Text, FlyToTB.Text);
            //temp.imagePath = image;
            //foreach (Airline airline in airlineList.list)
            //{
            //    if (flyToEdit == window.ListViewCollection.SelectedIndex)
            //    {
            //        airlineList.list[airlineList.list.IndexOf(airline)] = temp;
            //        break;
            //    }
            //}

        }
        private void SaveChanges_Click(object sender, RoutedEventArgs e)
        {
            //airline.f_id = countAir++;
            //airline.f_company = CompanyTB.Text;
            //airline.f_from = FlyFromTB.Text;
            //airline.f_toPoint = FlyToTB.Text;
            //airline.f_price = Convert.ToInt32(PriceTB.Text);
            //airline.f_shortname = makeShortname(FlyFromTB.Text, FlyToTB.Text);
            //airline.f_fullname = makeFullname(FlyFromTB.Text, FlyToTB.Text);
            //airlineList.AddItem(airline);

            //try
            //{


            //    //tempAirline.f_id = flyToEdit + 1000;
            //    //tempAirline.f_company = CompanyTB.Text;
            //    //tempAirline.f_from = FlyFromTB.Text;
            //    //tempAirline.f_toPoint = FlyToTB.Text;
            //    //tempAirline.f_price = Convert.ToInt32(PriceTB.Text);
            //    //tempAirline.f_shortname = AddFly.makeShortname(FlyFromTB.Text, FlyToTB.Text);
            //    //tempAirline.f_fullname = AddFly.makeFullname(FlyFromTB.Text, FlyToTB.Text);

            //    //MainWindow window = new MainWindow();
            //    Serializer.Serialize(airlineList, path);
            //    System.Windows.MessageBox.Show("Изменения сохранены.");
            //}
            //catch
            //{
            //    System.Windows.Forms.MessageBox.Show("Ошибка записи в файл.\nПопробуйте снова.");

            //}

            try
            {


                //tempAirline.f_id = flyToEdit + 1000;
                //tempAirline.f_company = CompanyTB.Text;
                //tempAirline.f_from = FlyFromTB.Text;
                //tempAirline.f_toPoint = FlyToTB.Text;
                //tempAirline.f_price = Convert.ToInt32(PriceTB.Text);
                //tempAirline.f_shortname = AddFly.makeShortname(FlyFromTB.Text, FlyToTB.Text);
                //tempAirline.f_fullname = AddFly.makeFullname(FlyFromTB.Text, FlyToTB.Text);
                //System.Windows.MessageBox.Show(
                //        tempAirline.f_id + "\n" +
                //        tempAirline.f_company + "\n" +
                //        tempAirline.f_from + "\n" +
                //        tempAirline.f_toPoint + "\n" +
                //        tempAirline.f_price + "\n" +
                //        tempAirline.f_shortname + "\n" +
                //        tempAirline.f_fullname
                //        );
                int num = 0;
                foreach (var i in airlineList.list)
                {
                    if (flyToEdit == num)
                    {
                        i.f_id = flyToEdit + 1000;
                        i.f_company = CompanyTB.Text;
                        i.f_from = FlyFromTB.Text;
                        i.f_toPoint = FlyToTB.Text;
                        i.f_price = Convert.ToInt32(PriceTB.Text);
                        i.f_shortname = AddFly.makeShortname(FlyFromTB.Text, FlyToTB.Text);
                        i.f_fullname = AddFly.makeFullname(FlyFromTB.Text, FlyToTB.Text);
                        //airlineList.list[airlineList.list.IndexOf(i)] = tempAirline;
                        //System.Windows.MessageBox.Show(
                        //tempAirline.f_id + "\n" +
                        //tempAirline.f_company + "\n" +
                        //tempAirline.f_from + "\n" +
                        //tempAirline.f_toPoint + "\n" +
                        //tempAirline.f_price + "\n" +
                        //tempAirline.f_shortname + "\n" +
                        //tempAirline.f_fullname
                        //);

                        break;
                    }
                    num++;
                }
                Serializer.Serialize<AirlineList>(airlineList, path);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Ошибка записи в файл.\nПопробуйте снова.");
                
            }
            System.Windows.MessageBox.Show("Изменения сохранены.");

            this.Hide();
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
                    image = ofd.FileName;
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

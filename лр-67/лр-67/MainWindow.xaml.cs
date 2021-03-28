using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Globalization;
using System.IO;
using System.Collections.ObjectModel;
using System.Threading;
using System.Windows.Threading;

namespace лр_67
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public AirlineList airlineList = new AirlineList();
        // public IEnumerable<AirlineList> airList => airlineList;
        ObservableCollection<Airline> list = new ObservableCollection<Airline>();
        DispatcherTimer timer;

        public MainWindow()
        {
            InitializeComponent();

            ListChange();
            //string path = @"D:\uni\ооп\лр-67\лр-67\bin\Debug\airlines.xml";
            //FileInfo fileInf = new FileInfo(path);
            //if (fileInf.Exists)
            //{
            //    airlineList = Serializer.Deserialize<AirlineList>(path);

            //    list = airlineList.list;
            //    ListViewCollection.ItemsSource = list;
            //}
            timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timerTick);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
        }
        private void timerTick(object sender, EventArgs e)
        {
            ListChange();
            //string path = @"D:\uni\ооп\лр-67\лр-67\bin\Debug\airlines.xml";
            //FileInfo fileInf = new FileInfo(path);
            //if (fileInf.Exists)
            //{
            //    airlineList = Serializer.Deserialize<AirlineList>(path);

            //    list = airlineList.list;
            //    ListViewCollection.ItemsSource = list;
            //}
        }
        public void ListChange()
        {
            string path = @"D:\uni\ооп\лр-67\лр-67\bin\Debug\airlines.xml";
            FileInfo fileInf = new FileInfo(path);
            list.Clear();
            if (fileInf.Exists)
            {
                airlineList = Serializer.Deserialize<AirlineList>(path);

                list = airlineList.list;
                ListViewCollection.ItemsSource = list;
            }
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
           this.Close();
           
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddFly addFlyWindow = new AddFly();
            addFlyWindow.Show();

        }

        private void Toolbar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left) 
            {
                this.DragMove();
            }
        }

        private void LanguageRus_Selected(object sender, RoutedEventArgs e)
        {
            CultureInfo lang = new CultureInfo("ru-RU");
           // App.Language = lang;
        }

        private void LanguageEng_Selected(object sender, RoutedEventArgs e)
        {

            CultureInfo lang = new CultureInfo("en-US");
           // App.Language = lang;

        }

        private void ViewAllButton_Click(object sender, RoutedEventArgs e)
        {
           // MessageBox.Show("view all");
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            
            var selected = ListViewCollection.SelectedItems.Cast<Object>().ToArray();
            foreach (var item in selected)
            {
                //ListViewCollection.Items.Remove(item);
                //ListChange();
                MessageBox.Show(selected.ToString());
            }
        }
    }
}

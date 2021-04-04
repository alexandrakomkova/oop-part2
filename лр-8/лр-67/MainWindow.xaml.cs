﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Resources;
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
using System.Text.RegularExpressions;

namespace лр_67
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public AirlineList airlineList = new AirlineList();
        ObservableCollection<Airline> list = new ObservableCollection<Airline>();
        //DispatcherTimer timer;
        
        public MainWindow()
        {
            InitializeComponent();
            AppTheme.Items.Clear();
            List<string> styles = new List<string> { "light", "dark" };
            AppTheme.SelectionChanged += ThemeChange;
            AppTheme.ItemsSource = styles;
            AppTheme.SelectedItem = "dark";
            App.LanguageChanged += LanguageChanged;

            CultureInfo currLang = App.Language;

            //Заполняем меню смены языка:
           

            ListChange();

            //timer = new DispatcherTimer();
            //timer.Tick += new EventHandler(timerTick);
            //timer.Interval = new TimeSpan(0, 0, 1);
            //timer.Start();
        }
        private void LanguageChanged(Object sender, EventArgs e)
        {
            CultureInfo currLang = App.Language;

            
        }
        private void ThemeChange(object sender, SelectionChangedEventArgs e)
        {
            string style = AppTheme.SelectedItem as string;
            // определяем путь к файлу ресурсов
            var uri = new Uri(style + ".xaml", UriKind.Relative);
            // загружаем словарь ресурсов
            ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
            // очищаем коллекцию ресурсов приложения
            Application.Current.Resources.Clear();
            // добавляем загруженный словарь ресурсов
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }

        private void LanguageRus_Selected(object sender, RoutedEventArgs e)
        {
            CultureInfo lang = new CultureInfo("ru-RU");
            App.Language = lang;
        }

        private void LanguageEng_Selected(object sender, RoutedEventArgs e)
        {

            CultureInfo lang = new CultureInfo("en-US");
            App.Language = lang;

        }
        //private void timerTick(object sender, EventArgs e)
        //{
        //    ListChange();
            
        //}
        public void ListChange()
        {
            string path = "airlines.xml";
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
            //добавил событие на закрытие окна
            //САНЯ САНЯ САНЯ
            addFlyWindow.Closing += (Sender, E) => ListChange();
            addFlyWindow.Show();
        }

        private void Toolbar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left) 
            {
                this.DragMove();
            }
        }

       
        private void ViewAllButton_Click(object sender, RoutedEventArgs e)
        {
            if (!ListViewCollection.Items.IsEmpty)
            {
                
                ListChange();
                FindTB.Text = "";
            }
            else
            {
                MessageBox.Show("Список пуст.\nДобавьте хотя бы один рейс.");
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            int num = 0;
            if (!ListViewCollection.Items.IsEmpty)
            {
                foreach (var airlineFromList in list)
                {
                    if (num == ListViewCollection.SelectedIndex)
                    {
                        airlineList.list.Remove((Airline)ListViewCollection.SelectedItem);
                        Serializer.Serialize(airlineList, "airlines.xml");
                        MessageBox.Show($"Рейс {airlineFromList.f_id} - {airlineFromList.f_shortname} удалён.");
                        break;
                    }
                    num++;
                }
                ListChange();
            }
            else 
            {
                MessageBox.Show("Список пуст.\nДобавьте хотя бы один рейс."); 
            }
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if (ListViewCollection.SelectedItem == null)
            {
                MessageBox.Show("Выберите объект для изменения.");

            }
            else
            {
                EditAirline editFlyWindow = new EditAirline(airlineList, ListViewCollection.SelectedIndex);
                //EditAirline editFlyWindow = new EditAirline(airlineList, ListViewCollection.SelectedItem);

                //САНЯ САНЯ САНЯ
                editFlyWindow.Closing += (Sender, E) => ListChange();
                editFlyWindow.Show();
            }
            
        }
        public void sortByCompany() 
        {
            var sortByCountry = from i in airlineList.list
                                orderby i.f_company
                                select i;
            ListViewCollection.ItemsSource = sortByCountry;
        }
        public void sortByFromPoint()
        {
            var sortByFromPoint = from i in airlineList.list
                                orderby i.f_from
                                select i;
            ListViewCollection.ItemsSource = sortByFromPoint;
        }
        public void sortByToPoint()
        {
            var sortByToPoint = from i in airlineList.list
                                  orderby i.f_toPoint
                                  select i;
            ListViewCollection.ItemsSource = sortByToPoint;
        }
        private void SortByCompany_Checked(object sender, RoutedEventArgs e)
        {
            sortByCompany();
            //timer.Stop();
        }

        private void SortByFromPonit_Checked(object sender, RoutedEventArgs e)
        {
            sortByFromPoint();
            //timer.Stop();
        }

        private void SortByToPoint_Checked(object sender, RoutedEventArgs e)
        {
            sortByToPoint();
            //timer.Stop();
        }

        private void ClearSortButton_Click(object sender, RoutedEventArgs e)
        {
            SortByCompany.IsChecked = false;
            SortByFromPoint.IsChecked = false;
            SortByToPoint.IsChecked = false;
            ListChange();
            //timer.Start();
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {

        }
        public bool matchIsFound = false;
      
        private void FindTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                matchIsFound = false;
                //timer.Stop();
                string pattern = $"{FindTB.Text}";

                Regex regex = new Regex(pattern);
                var findItems = from i in airlineList.list
                                where regex.IsMatch(i.f_company)
                                select i; 
               
                ListViewCollection.ItemsSource = findItems;
                if (findItems.Count() !=0) 
                {
                    matchIsFound = true;
                }
            }
            catch
            {
                MessageBox.Show("В поле поиска можно вводить только буквы, цифры и символы.");
            }
        }

        private void FindButton_Click(object sender, RoutedEventArgs e)
        {
            if (matchIsFound==false)
            {
                MessageBox.Show("Совпадений не найдено :(");
            }

            
        }
        
    }
}

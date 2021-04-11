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

namespace lab9.CustomControls
{
    /// <summary>
    /// Логика взаимодействия для LimitedTextBox.xaml
    /// </summary>
    public partial class LimitedTextBox : UserControl
    {
       // public static DependencyProperty PriceProperty;
        public LimitedTextBox()
        {
            InitializeComponent();
            this.DataContext = this;
            

            //FrameworkPropertyMetadata metadata = new FrameworkPropertyMetadata();
            //metadata.CoerceValueCallback = new CoerceValueCallback(CorrectValue);
            //PriceProperty = DependencyProperty.Register(
            //    "Txt", typeof(bool), typeof(LimitedTextBox), metadata, new ValidateValueCallback(ValidateValue));
            

        }
       
        public string Title { get; set; }

        public int MaxLength { get; set; }
        //public bool CheckPrice
        //{
        //    get { return (bool)GetValue(PriceProperty); }
        //    set { SetValue(PriceProperty, value); }
        //}
        
    }
}


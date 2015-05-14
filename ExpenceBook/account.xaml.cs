using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MicroMVVM.Expence.Daily;
using System.Configuration;

namespace ExpenceBook
{
    /// <summary>
    /// Interaction logic for account.xaml
    /// </summary>
    public partial class account : UserControl
    {
        public account()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string transactionType = dropdown.Text;

            List<DailyExpence> AccountTypeDailyExpence = new List<DailyExpence>();

            string loginId = ConfigurationManager.AppSettings["loginUserId"];

            AccountTypeDailyExpence = DailyExpence.FillAccountTypeExpenceList(loginId, transactionType);

            AccountTypeExpence.DataContext = AccountTypeDailyExpence;
        }
        private void Window_ContentRendered(object sender, EventArgs e)
        {
            SolidColorBrush MyBrush = Brushes.Aquamarine;

            // Set the value
            Application.Current.Resources["DynamicBG"] = MyBrush;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush MyBrush = Brushes.CadetBlue;

            // Set the value
            Application.Current.Resources["DynamicBG"] = MyBrush;

        }
        public partial class MainWindow : Window
        {
            public MainWindow()
            {
                ExpenceBook.InitializeComponent();
            }

            private void Window_Loaded(object sender, RoutedEventArgs e)
            {
                this.Resources["DynamicBG"] = new SolidColorBrush(Colors.Red);
            }

        }
    }
}

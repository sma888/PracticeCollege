using CarDealership.Core;
using CarDealership.ViewModel;
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

namespace CarDealership
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
            this.DataContext = new AuthViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as AuthViewModel).Password = pswBox.Password.ToString();
            (DataContext as AuthViewModel).Checking();
        }
    }
}

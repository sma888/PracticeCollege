using CarDealership.ViewModel;
using System.Windows;

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

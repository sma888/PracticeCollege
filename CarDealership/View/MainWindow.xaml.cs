using CarDealership.ViewModel;
using System.Windows;

namespace CarDealership.View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainWindowViewModel();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as MainWindowViewModel).btnAdd_Click(sender, e);
        }
    }
}

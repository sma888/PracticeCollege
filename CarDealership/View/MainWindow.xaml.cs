using CarDealership.ViewModel;
using System.Windows;

namespace CarDealership.View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow(Manager manager)
        {
            InitializeComponent();
            this.DataContext = new MainWindowViewModel(manager);
            textBlockAccount.Text = "Аккаунт:\n" + manager.Surname + " " +manager.FirstName;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as MainWindowViewModel).btnAdd_Click(sender, e);
            
            (DataContext as MainWindowViewModel).LoadData();
        }

        private void btnDeleteToDb_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as MainWindowViewModel).DeleteItem(sender, e);
            (DataContext as MainWindowViewModel).LoadData();//обнавление данных, также по таймеру каждые 20 сек.
        }
    }
}

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
using System.Windows.Shapes;

namespace CarDealership.View
{
    /// <summary>
    /// Логика взаимодействия для AddManagerWindow.xaml
    /// </summary>
    public partial class AddManagerWindow : Window
    {
        public AddManagerWindow(Manager manager)
        {
            InitializeComponent();
            //boxAge.Text = manager.Age.ToString();
            //boxName.Text = manager.FirstName;
            //даже так не заполнился
            
            this.DataContext = new AddManagerWindowViewModel(manager);
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as AddManagerWindowViewModel).btnSave_Click(sender, e);
        }
    }
}

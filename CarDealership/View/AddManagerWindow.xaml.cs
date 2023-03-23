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
        public AddManagerWindow()
        {
            InitializeComponent();

            this.DataContext = new AddManagerWindowViewModel();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as AddManagerWindowViewModel).btnSave_Click(sender, e);
        }
    }
}

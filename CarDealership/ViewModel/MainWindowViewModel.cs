using CarDealership.DbEntites;
using CarDealership.View;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace CarDealership.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        private ObservableCollection<Manager> _manager;

        private Manager _selectedManager;

        public Manager SelectedManager
        {
            get => _selectedManager;
            set
            {
                _selectedManager = value;
                OnPropertyChanged(nameof(SelectedManager));
            }
        }

        public ObservableCollection<Manager> Manager
        {
            get => _manager;
            set
            {
                _manager = value;
                OnPropertyChanged(nameof(Manager));
            }
        }


        public MainWindowViewModel(Manager manager)
        {
            Manager = new ObservableCollection<Manager>();
            LoadData();
            Timer();
        }

        public void LoadData()
        {
            if (Manager.Count > 0)
            {
                Manager.Clear();
            }

            var result = DbSingileton.Db_s.Manager.ToList();

            result.ForEach(elem => Manager?.Add(elem));
        }

        public void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var add = new AddManagerWindow(_selectedManager);
            add.Show();
        }




        public void DeleteItem(object sender, EventArgs e)
        {

            if (!(SelectedManager is null))
            {
                using (var db = new CarDealershipEntities())
                {

                    var result = MessageBox.Show("Вы уверены, что хотите удалить данный элемент?" +
                        "Это действие невозможно отменить.", "Предупреждение", MessageBoxButton.YesNo, MessageBoxImage.Warning);

                    if (result == MessageBoxResult.Yes)
                    {
                        try
                        {
                            var entityForDelete = db.Manager.Where(elem => elem.ID == SelectedManager.ID).FirstOrDefault();

                            db.Manager.Remove(entityForDelete);

                            db.SaveChanges();



                            MessageBox.Show("Данные успешно удалены", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Информация", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                }
            }
        }

        System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
        private void Timer()
        {
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 10);
            dispatcherTimer.Start();
        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            LoadData();

        }
    }
}

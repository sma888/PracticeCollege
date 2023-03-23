using CarDealership.DbEntites;
using CarDealership.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.ViewModel
{
    public class MainWindowViewModel:BaseViewModel
    {
        private ObservableCollection<Manager> _manager;

        public ObservableCollection<Manager> Manager
        {
            get => _manager;
            set
            {
                _manager = value;
                OnPropertyChanged(nameof(Manager));
            }
        }

        public MainWindowViewModel()
        {
            Manager = new ObservableCollection<Manager>();

            LoadData();
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
    }
}

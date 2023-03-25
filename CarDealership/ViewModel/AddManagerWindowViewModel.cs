using CarDealership.DbEntites;
using CarDealership.View;
using System;
using System.Data.Entity.Migrations;
using System.Windows;

namespace CarDealership.ViewModel
{
    class AddManagerWindowViewModel : BaseViewModel
    {
        private string _firstName;
        private string _surname;
        private string _middleName;
        private int _age;
        private string _password;
        private string _login;
        private Manager _manager;

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

        public AddManagerWindowViewModel(Manager manager)
        {
            if (manager is null)
            {
                _manager = manager = new Manager();
            }
            else
            {
                _manager = manager;
            }
        }

        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }

        public string Surname
        {
            get => _surname;
            set
            {
                _surname = value;
                OnPropertyChanged(nameof(Surname));
            }
        }

        public string MiddleName
        {
            get => _middleName;
            set
            {
                _middleName = value;
                OnPropertyChanged(nameof(MiddleName));
            }
        }

        public int Age
        {
            get => _age;
            set
            {
                _age = value;
                OnPropertyChanged(nameof(Age));
            }
        }

        public string Login
        {
            get => _login;
            set
            {
                _login = value;
                OnPropertyChanged(nameof(Login));
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }


        public Manager Manager
        {
            get => _manager;
            set
            {
                _manager = value;
                OnPropertyChanged(nameof(Manager));
            }
        }

        public void btnSave_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                _manager.FirstName = _firstName;
                _manager.Surname = _surname;
                _manager.MiddleName = _middleName;
                _manager.Age = _age;
                _manager.Login = _login;
                _manager.Password = _password;

                if (string.IsNullOrEmpty(_manager.FirstName) || string.IsNullOrEmpty(_manager.Surname) || string.IsNullOrEmpty(_manager.MiddleName)
                    || string.IsNullOrEmpty(_manager.Login) || string.IsNullOrEmpty(_manager.Password) || _manager.Age <= 0)
                {
                    MessageBox.Show("Данные заполнены неверно!", "Информация", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                        DbSingileton.Db_s.Manager.AddOrUpdate(_manager);

                        DbSingileton.Db_s.SaveChanges();

                        MessageBox.Show("Данные успешно сохранены", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);

                        foreach (Window item in Application.Current.Windows)
                        {
                            if (item is AddManagerWindow)
                            {
                                item.Close();
                            }
                        }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Информация", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}


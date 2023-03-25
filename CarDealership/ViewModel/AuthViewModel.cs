using CarDealership.Core;
using CarDealership.View;
using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace CarDealership.ViewModel
{
    class AuthViewModel : BaseViewModel
    {
        private string _password;
        private string _login;


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

        public void Checking()
        {
            var verif = new Verificate();
            var res = verif.Check(Login, Password);
            if (res.ID != -1)
            {
                MessageBox.Show("Авторизация прошла успешно", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                MainWindow main = new MainWindow(res);
                main.Show();
                foreach (Window wind in Application.Current.Windows)
                {
                    if (wind is AuthWindow)
                    {
                        wind.Close();
                    }
                }
            }
            else MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Stop);
        }
    }
}


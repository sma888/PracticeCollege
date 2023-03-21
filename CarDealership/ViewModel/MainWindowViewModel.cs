using CarDealership.Core;
using System.Windows;

namespace CarDealership.ViewModel
{
    class MainWindowViewModel : BaseViewModel
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
            bool res = verif.Check(Login, Password);
            if (res)
            {
                MessageBox.Show("Авторизация прошла успешно", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Stop);
        }
    }
}


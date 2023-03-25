using CarDealership.DbEntites;
using CarDealership.ViewModel;
using System.Collections.ObjectModel;
using System.Linq;

namespace CarDealership.Core
{
    public class Verificate
    {


        public Manager Check(string login, string password)
        {
            var managers = new Manager();
            var result = DbSingileton.Db_s.Manager.FirstOrDefault(manager => manager.Login == login && manager.Password == password);

            if (result != null)
            {
                managers.FirstName = result.FirstName;
                managers.Surname = result.Surname;
                managers.MiddleName = result.MiddleName;
                managers.Age = result.Age;
                managers.Login = result.Login;
                managers.Password = result.Password;

                return managers;
            }
            managers.ID = -1;
            return managers;
        }
    }
}


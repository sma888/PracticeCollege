using CarDealership.DbEntites;
using System.Linq;

namespace CarDealership.Core
{
    public class Verificate
    {

        public bool Check(string login, string password)
        {

            var result = DbSingileton.Db_s.Manager.FirstOrDefault(manager => manager.Login == login && manager.Password == password);

            if (result != null)
            {
                return true;
            }

            return false;
        }
    }
}


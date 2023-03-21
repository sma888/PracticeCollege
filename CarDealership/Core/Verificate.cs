using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace CarDealership.Core
{
    public class Verificate
    {

        public bool Check(string login, string password)
        {
            using (var db = new CarDealershipEntities())
            {
                var result = db.User.FirstOrDefault(user => user.Login == login && user.Password == password);

                if (result != null)
                {
                    return true;
                }
            }
            return false;
        }
    }
}


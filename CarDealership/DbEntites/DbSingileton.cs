using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.DbEntites
{
    public static class DbSingileton
    {
        public static CarDealershipEntities Db_s = new CarDealershipEntities();
    }
}

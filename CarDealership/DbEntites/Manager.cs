using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.DbEntites
{
    public partial class Manager
    {

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }
        public int Age { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

    }
}


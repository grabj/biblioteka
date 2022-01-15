using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.data
{
    class UserList
    {
        public static List<User> LoadSampleData()
        {
            List<User> uList = new List<User>();

            //uList.Add(new User{ firstName = "Maria", lastName = "Kowalska", email = "MK@wp.pl", password = "kowalska" });

            return uList;
        }
    }
}

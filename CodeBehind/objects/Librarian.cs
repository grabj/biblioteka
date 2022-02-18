using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Projekt
{
    [Serializable()]
    public class Librarian : User
    {
        [field: NonSerialized]
        private static uint numOfLibrarians;

        public Librarian()
        {
            ID = numOfLibrarians + 10;
            numOfLibrarians++;
        }

        public Librarian(string firstName, string lastName, string email, string password, string login) : base(firstName, lastName, email, password, login)
        {
            ID = numOfLibrarians + 10;
            numOfLibrarians++;
        }

        public uint ID { get; set; }
    }
}

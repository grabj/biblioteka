using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Librarian : User
    {
        private static uint numOfLibrarians;

        public Librarian(string name, string surname, string email) : base(name, surname, email)
        {
            numOfLibrarians++;
            ID = numOfLibrarians + 10;
        }

        public uint ID { get; }
    }
}

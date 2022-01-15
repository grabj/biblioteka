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

        public Librarian(string firstName, string lastName, string email, string password) : base(firstName, lastName, email, password)
        {
            numOfLibrarians++;
            ID = numOfLibrarians + 10;
        }

        public uint ID { get; }
    }
}

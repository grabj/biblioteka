using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Reader : User
    {
        private static uint numOfReaders;

        public Reader(string firstName, string lastName, string email, string password, int bookLimit = 3) : base(firstName, lastName, email, password)
        {
            numOfReaders++;
            ID = numOfReaders + 1000;
            BookLimit = bookLimit;
        }

        public int BookLimit { get; }
        public uint ID { get; }
    }
}

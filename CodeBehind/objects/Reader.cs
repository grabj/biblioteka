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
        private int _bookCount = 0;

        public Reader(string firstName, string lastName, string email, string password, int bookLimit = 3) : base(firstName, lastName, email, password)
        {
            ID = numOfReaders + 1000;
            numOfReaders++;
            BookLimit = bookLimit;
        }

        public int BookCount
        { 
            get => _bookCount; 
            set => _bookCount = value; 
        }
        public int BookLimit { get; }
        public uint ID { get; }
    }
}

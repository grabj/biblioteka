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

        public Reader(string firstName, string lastName, string email) : base(firstName, lastName, email)
        {
            numOfReaders++;
            ID = numOfReaders + 1000;
        }

        public uint ID { get; }
    }
}

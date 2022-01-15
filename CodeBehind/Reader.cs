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

        public Reader(string name, string surname, string email) : base(name, surname, email)
        {
            numOfReaders++;
            ID = numOfReaders + 100;
        }

        public uint ID { get; }
    }
}

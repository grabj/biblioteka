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
    public class Reader : User
    {
        [field: NonSerialized]
        private static uint numOfReaders;
        [field: NonSerialized]
        private int _bookCount = 0;

        public Reader()
        {
            ID = numOfReaders + 100;
            numOfReaders++;
        }

        public Reader(string firstName, string lastName, string email, string password, string login) : base(firstName, lastName, email, password, login)
        {
            ID = numOfReaders + 100;
            numOfReaders++;
        }

        public int BookCount
        { 
            get => _bookCount; 
            set => _bookCount = value; 
        }

        public uint ID { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class ReaderList
    {
        public static List<Reader> Readers = new List<Reader>();

        public static void AddReader(Reader reader)
        {
            if (Readers.Count > 0)
            {
                Readers.Add(reader);
            }
            else
            {
                List<Reader> Readers = new List<Reader>();
                Readers.Add(reader);
            }
        }

        public static List<Reader> LoadSampleData()
        {
            List<Reader> rList = new List<Reader>();

            //rList.Add(item: new Reader { firstName = "Maria", lastName = "Kowalska", email = "MK@wp.pl", password = "kowalska", Login = "mk"});

            return rList;
        }
    }
}

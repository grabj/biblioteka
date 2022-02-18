using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Projekt.data
{
    public static class Xml
    {
        public static void SerializeBook(this List<Book> list, string fileName)
        {
            var serializer = new XmlSerializer(typeof(List<Book>));
            using (var stream = File.CreateText(fileName))
            {
                serializer.Serialize(stream, list);
            }
        }

        public static void DeserializeBook(this List<Book> list, string fileName)
        {
            var serializer = new XmlSerializer(typeof(List<Book>));
            using (var stream = File.OpenRead(fileName))
            {
                var other = (List<Book>)(serializer.Deserialize(stream));
                list.Clear();
                list.AddRange(other);
            }
        }

        public static void SerializeReader(this List<Reader> list, string fileName)
        {
            var serializer = new XmlSerializer(typeof(List<Reader>));
            using (var stream = File.CreateText(fileName))
            {
                serializer.Serialize(stream, list);
            }
        }

        public static void DeserializeReader(this List<Reader> list, string fileName)
        {
            var serializer = new XmlSerializer(typeof(List<Reader>));
            using (var stream = File.OpenRead(fileName))
            {
                var other = (List<Reader>)(serializer.Deserialize(stream));
                list.Clear();
                list.AddRange(other);
            }
        }

        public static void SerializeLibrarian(this List<Librarian> list, string fileName)
        {
            var serializer = new XmlSerializer(typeof(List<Librarian>));
            using (var stream = File.CreateText(fileName))
            {
                serializer.Serialize(stream, list);
            }
        }

        public static void DeserializeLibrarian(this List<Librarian> list, string fileName)
        {
            var serializer = new XmlSerializer(typeof(List<Librarian>));
            using (var stream = File.OpenRead(fileName))
            {
                var other = (List<Librarian>)(serializer.Deserialize(stream));
                list.Clear();
                list.AddRange(other);
            }
        }

        public static void SerializeLoan(this List<Loan> list, string fileName)
        {
            var serializer = new XmlSerializer(typeof(List<Loan>));
            using (var stream = File.CreateText(fileName))
            {
                serializer.Serialize(stream, list);
            }
        }

        public static void DeserializeLoan(this List<Loan> list, string fileName)
        {
            var serializer = new XmlSerializer(typeof(List<Loan>));
            using (var stream = File.OpenRead(fileName))
            {
                var other = (List<Loan>)(serializer.Deserialize(stream));
                list.Clear();
                list.AddRange(other);
            }
        }
    }
}

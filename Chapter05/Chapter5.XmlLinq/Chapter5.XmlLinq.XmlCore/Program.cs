using System;
using Chapter5.XmlLinq.XmlLinqLib;

namespace Chapter5.XmlLinq.XmlCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmlFile = @"C:\Projects\Chapter5\Chapter5.XmlLinq\Chapter5.XmlLinq.XmlCore\books.xml";

            var books = new XmlBooks(xmlFile);

            var titles = books.GetBookTitles();

            foreach (var title in titles)
            {
                Console.WriteLine(title);
            }

            Console.ReadLine();
        }
    }
}

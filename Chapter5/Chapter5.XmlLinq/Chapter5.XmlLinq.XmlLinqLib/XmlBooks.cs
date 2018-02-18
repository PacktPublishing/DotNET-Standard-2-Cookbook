using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;

namespace Chapter5.XmlLinq.XmlLinqLib
{
    public class XmlBooks
    {
        private string _xmlFile;

        public XmlBooks(string xmlFile)
        {
            _xmlFile = xmlFile;
        }

        public List<string> GetBookTitles()
        {
            var titles = new List<string>();

            XDocument xDoc = XDocument.Load(_xmlFile);
            var books = xDoc.Descendants("book"); 

            foreach (var book in books)
            {
                titles.Add(book.Element("title").Value);
            }

            return titles;
        }


    }
}

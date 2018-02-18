using System;
using System.Xml;
using System.IO;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;

namespace Chapter5.XmlDoc.XmlLib
{
    public class XMLLog
    {
        private string _xmlFile;

        public XMLLog(string xmlFile)
        {
            _xmlFile = xmlFile;
        }

        public void WriteToLog(string message)
        {
            if (!File.Exists(_xmlFile))
            {
                using (XmlWriter xmlWriter = XmlWriter.Create(_xmlFile))
                {
                    xmlWriter.WriteStartDocument();
                    xmlWriter.WriteStartElement("Log");

                    xmlWriter.WriteStartElement("LogEntry");
                    xmlWriter.WriteElementString("LogDate", DateTime.Now.ToString());
                    xmlWriter.WriteElementString("Message", message);
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteEndElement();
                    xmlWriter.WriteEndDocument();
                    xmlWriter.Flush();
                    xmlWriter.Close();
                }
            }
            else
            {
                XDocument xDoc = XDocument.Load(_xmlFile);
                XElement root = xDoc.Element("Log");
                IEnumerable<XElement> rows = root.Descendants("LogEntry");
                XElement lastRow = rows.Last();
                lastRow.AddAfterSelf(
                   new XElement("LogEntry",
                   new XElement("LogDate", DateTime.Now.ToString()),
                   new XElement("Message", message)));
                xDoc.Save(_xmlFile);
            }
        }

        public Dictionary<string, string> ReadLog()
        {
            var xmlOutPut = new Dictionary<string, string>();
            var line = 0;

            if (File.Exists(_xmlFile))
            {
                using (XmlReader xmlReader = XmlReader.Create(_xmlFile))
                {
                    while(xmlReader.Read())
                    {
                        if (xmlReader.IsStartElement())
                        {
                            switch (xmlReader.Name)
                            {
                                case "LogDate":
                                    xmlOutPut.Add($"LogDate - {line}", xmlReader.ReadElementContentAsString());
                                    break;
                                case "Message":
                                    xmlOutPut.Add($"Message - {line}", xmlReader.ReadElementContentAsString());
                                    break;
                            }
                        }

                        line++;
                    }
                }
            }

            return xmlOutPut;
        }
    }
}

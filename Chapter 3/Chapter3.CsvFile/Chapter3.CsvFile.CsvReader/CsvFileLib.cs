using System;
using System.IO;
using System.Collections.Generic;

namespace Chapter3.CsvFile.CsvReader
{
    public class CsvFileLib
    {

        private string _fileName; 

        public CsvFileLib(string csvFile)
        {
            _fileName = csvFile;
        }

        public List<string> ReadCsvFile()
        {
            var fileContents = new List<string>();

            using (var csvFile = File.OpenRead(_fileName))
            {
                var fileStream = new StreamReader(csvFile);

                while(!fileStream.EndOfStream)
                {
                    fileContents.Add(fileStream.ReadLine());
                }

                fileStream.Close();
            }

            return fileContents;
        }

    }
}

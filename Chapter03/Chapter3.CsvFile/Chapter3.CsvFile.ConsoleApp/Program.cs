using System;
using Chapter3.CsvFile.CsvReader;

namespace Chapter3.CsvFile.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var moviesFile = new CsvFileLib("movies.txt");
            var moviesList = moviesFile.ReadCsvFile();

            foreach (var movie in moviesList)
            {
                var row = movie.Split(',');
                
                Console.WriteLine($"ID: {row[0]} Title : {row[1]} Year : {row[2]}");
                
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;

namespace Salon.Console.CsvParser
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader(@"Clients.csv"))
            {
                List<string> listOfThings = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    while (!line.EndsWith('"'))
                    {
                        line += reader.ReadLine();
                    }
                    System.Console.WriteLine($"line {line}");
                }
            }
        }
    }
}

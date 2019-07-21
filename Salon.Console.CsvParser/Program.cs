using Microsoft.Extensions.Configuration;
using Salon.Data;
using Salon.Data.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;

namespace Salon.Console.CsvParser
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();

            var connection = configuration.GetConnectionString("SalonContext");
            using (var reader = new StreamReader(@"Clients.csv"))
            {                
                List<string> listOfCompleteRecords = new List<string>();
                var firstLine = reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    
                    var record = reader.ReadLine();
                    while (!record.EndsWith('"'))
                    {
                        record += " ";
                        record += reader.ReadLine();
                    }
                    listOfCompleteRecords.Add(record);
                }
                // System.Console.WriteLine($"Number of records: {listOfThings.Count}");
                foreach (var customerRecord in listOfCompleteRecords)
                {
                    string[] customerProperty = customerRecord.Split(',');
                    System.Console.Write($"{customerProperty.Length}");
                    if (customerProperty.Length != 22)
                    {
                        System.Console.WriteLine("There are less than 22 properties in the record");
                    }
                    System.Console.WriteLine($"{customerRecord}");
                    customerProperty[0] = customerProperty[0].Replace("\"", "").Trim();
                    var customer = new Customer
                    {
                        FirstName = customerProperty[0].Split(' ')[0],
                        LastName = customerProperty[0].Split(' ')[0].Length != customerProperty[0].Length ? 
                        customerProperty[0].Substring(customerProperty[0].Split(' ')[0].Length + 1, customerProperty[0].Length - customerProperty[0].Split(' ')[0].Length - 1) :
                        "Unknown",
                        PrimaryPhoneNumber = customerProperty[1].Replace("\"","").Trim(),
                        Notes = customerProperty[5].Replace("\"","").Trim()
                    };
                    SalonContext salonContext = new SalonContext();
                    var customers = salonContext.Customers.ToList();
                    salonContext.Customers.Add(customer);
                    salonContext.SaveChanges();
                }
            }
            System.Console.ReadLine();
        }
    }
}

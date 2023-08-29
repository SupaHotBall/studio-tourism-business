using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace customer_management_system
{
    internal class CustomerManager
    {
        private static readonly string FilePath = "customers.txt";
        public static List<Customer> LoadCustomersFromFile()
        {
            if (!File.Exists(FilePath)) return new List<Customer>();

            var lines = File.ReadAllLines(FilePath);
            return lines.Select(line =>
            {
                var parts = line.Split(',');
                return new Customer(int.Parse(parts[0]), parts[1], parts[2]);
            }).ToList();
        }
    }
}

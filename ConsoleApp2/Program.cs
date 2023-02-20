using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var StreetList = new Dictionary<string, string>();

            StreetList.Add("Kullamäe", "tänav");
            StreetList.Add("Mihkli", "tänav");
            StreetList.Add("Kadaka", "tänav");
            StreetList.Add("Tapa", "tänav");
            StreetList.Add("Viru", "tänav");

            Console.WriteLine("Tänava List");

            foreach (var street in StreetList)
            {
                Console.WriteLine($"{street.Key} {street.Value}");
            }
        }
    }
}

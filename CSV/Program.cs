using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\romel\OneDrive\Documents\Book1.csv ";
            CSVreader reader = new CSVreader(filePath);
            Country[] countries = reader.ReadFirstCountries(2);
            foreach (Country country in countries)
            {
                //Console.WriteLine($"{country.name}:  {country.population}  ");
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.population).PadLeft(15)}: {country.name}");
            }
            Console.ReadKey();
        }
    }
    

 }
     

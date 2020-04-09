using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSV
{
    class CSVreader
    {
        private string _csvFilePath;

        public CSVreader(string csvFilePath)
        {
            _csvFilePath = csvFilePath;
        }
        public Country[] ReadFirstCountries(int nCountries)
        {
            Country[] countries = new Country[nCountries];
            using (StreamReader sr = new StreamReader(_csvFilePath))
            {
                sr.ReadLine();
                for(int i=0; i<nCountries;i++)
                {
                    string csvLine = sr.ReadLine();
                    countries[i] = ReadCountryfroCSV(csvLine);
                }
            }
            return countries;
        }
        public Country ReadCountryfroCSV (string csvLine)
        {
            string[] parts = csvLine.Split(new char[] { ',' });
            string name = parts[0];
            string code = parts[1];
            string region = parts[2];
           int population = int.Parse(parts[3]);
            return new Country(name, code, region, population);
            
        }
       
    } 
}

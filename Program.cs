using System;

namespace ConsoleApp3
{
    class Country
    {
        public string name;
        public string capital;
        public string languages;
        public string etnic;
        public string religion;
        public int area;
        public int population;

        public Country()
        {
            name = "Republic of Armenia";
            capital = "Yerevan";
            languages = "Armenian";
            etnic = "98.1% Armenians, 1.2% Yazidis, 0.4% Russians, 0.3% other";
            religion = "Cristianity";
            area = 29743;
            population = 2951745;
          
            print();
        }
        public Country(string _name, string _capital, string _languages, string _etnic, string _religion, int _area, int _population)
        {
            name = _name;
            capital = _capital;
            languages = _languages;
            etnic = _etnic;
            religion = _religion;
            area = _area;
            population = _population;
           
            print();
        }

        public void print()
        {
            Console.WriteLine("Name - " + name);
            Console.WriteLine("Capital - " + capital);
            Console.WriteLine("Languages - " + languages);
            Console.WriteLine("Etnic groups - " + etnic);
            Console.WriteLine("Religion - " + religion);
            Console.WriteLine("Area(km2) - " + area);
            Console.WriteLine("Population - " + population);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string TTranscaucasianCountry;
            Console.WriteLine("Which Transcaucasian country are you interested in? \n 1)Armenia, 2)Georgia, 3)Azerbaijan");
            Console.WriteLine();
            TTranscaucasianCountry = Console.ReadLine();
            Console.WriteLine();
            if (TTranscaucasianCountry is "Armenia")
            {
                Country Armenian = new Country();
                Console.WriteLine();
            } else if(TTranscaucasianCountry is "Georgia")
            {
                Country Georgia = new Country("Georgia", "Tbilisi", "Georgian", "86,8% Georgians, 6,2% Azerbaijanis, 4,5% Armenians, 2,85 other", "Cristianity", 69700, 3723464);
                Console.WriteLine();
            } if(TTranscaucasianCountry is "Azerbaijan")
            {
                Country Azerbaijan = new Country("Republic of Azerbaijan", "Baku", "Azerbaijani", "91.60% Azerbaijanis, 2.02% Lezgians, 1.35% Armenians, 1.34% Russians, 1.26% Talysh, 2,43 other", "Shia Muslim", 86600, 10027874);
                Console.WriteLine();
            }
                       
        }
    }
}


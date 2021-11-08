using System;

namespace hometask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hometask #1!");
            Console.WriteLine(" ");

            Console.WriteLine("Enter your birthday");
            Person firstPerson = new Person();
            firstPerson.ConstructPerson();

            int customYear = 40;
            int fortyYears = firstPerson.Year + customYear;

            DateTime nowadays = DateTime.Now;

            firstPerson.PrintData();
            if (nowadays.Year < fortyYears)
                Console.WriteLine("Years til he(she) got 40 years old: {0}", firstPerson.yearsTilForty(nowadays, fortyYears));
            else
                Console.WriteLine("He(She) already got 40 years old");
        }
    }
}
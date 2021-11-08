using System;
using System.Collections.Generic;
using System.Text;

namespace hometask1
{
    class Person
    {
        string _name;
        string _surname;

        private DateTime _dateOfBirth;

        public int Year => _dateOfBirth.Year;
        public int Month => _dateOfBirth.Month;
        public int Day => _dateOfBirth.Day;

        public void ConstructPerson()
        {
            Console.WriteLine("Enter your name");
            _name = Console.ReadLine();

            Console.WriteLine("Enter your surname");
            _surname = Console.ReadLine();

            Console.WriteLine("Day:");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Mouth:");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Year:");
            int year = Convert.ToInt32(Console.ReadLine());

            _dateOfBirth = new DateTime(year, month, day);
        }

        public void PrintData()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Name: {0}", _name);
            Console.WriteLine("Surname: {0}", _surname);
            Console.WriteLine("Birthday: {0}.{1}.{2}", Day, Month, Year);
        }

        public int yearsTilForty(DateTime now, int fortyYear)
        {
            if (Month > now.Month)
            {
                return fortyYear - now.Year + 1;
            }
            else
            {
                if (Month == now.Month)
                {
                    if (Day < now.Day)
                    {
                        return fortyYear - now.Year + 1;
                    }
                    else
                    {
                        return fortyYear - now.Year;
                    }
                }
                else
                {
                    return fortyYear - now.Year;
                }
            }
        }
    }
}
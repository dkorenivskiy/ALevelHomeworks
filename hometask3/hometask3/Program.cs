using System;

namespace hometask3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("******Hometask 3******");
            Console.WriteLine();

            string choice;

            string userString;
            Console.WriteLine("Enter the string. One word must contain at least one letter in word and must not contain punctuations");
            userString = Console.ReadLine();

            while (WorkWithString.IfLettersOrPuncts(userString) == false)
            {
                Console.WriteLine();
                Console.WriteLine("One word must contain at least one letter and must not contain punctuations");
                Console.WriteLine("Enter the string");
                userString = Console.ReadLine();
            }

            while (WorkWithString.CountWords(userString) < 5)
            {
                Console.WriteLine();
                Console.WriteLine("You need to enter 5 words or more to continue");
                Console.WriteLine("Enter the string");
                userString = Console.ReadLine();
            }

            do
            {
                Console.WriteLine();
                Console.WriteLine("Point #1 - 1");
                Console.WriteLine("Point #2 - 2");
                Console.WriteLine("Point #3 - 3");
                Console.WriteLine("Exit  - 0");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        var point1 = new Point1(userString);
                        userString = point1.Program();
                        Console.WriteLine("************************************************");
                        break;

                    case "2":
                        Point2 point2 = new Point2(userString);
                        userString = point2.Program();
                        Console.WriteLine("************************************************");
                        break;

                    case "3":
                        Point3 point3 = new Point3(userString);
                        userString = point3.Program();
                        Console.WriteLine("************************************************");
                        break;

                    case "0":
                        break;

                    default:
                        Console.WriteLine("Wrong Key!");
                        break;
                }

            } while (choice != "0");
        }
    }
}

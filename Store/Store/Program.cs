using System;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;

            string[] items = new string[5];
            int[] quantity = new int[5];

            do
            {
                Console.WriteLine("1 - display items in store");
                Console.WriteLine("2 - add to store");
                Console.WriteLine("3 - remove from store");
                Console.WriteLine("exit - display items in store");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Display display = new Display(items, quantity);
                        display.Program();
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;

                    case "2":
                        Add add = new Add(items, quantity);
                        (items, quantity) = add.Program();
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;

                    case "3":
                        Remove remove = new Remove(items, quantity);
                        (items, quantity) = remove.Program();
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;

                    case "exit":
                        break;

                    default:
                        Console.WriteLine("Wrong Key! Please try again");
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                }

                Console.Clear();
            } while (choice != "exit");

        }
    }
}

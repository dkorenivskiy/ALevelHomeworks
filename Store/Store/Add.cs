using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Add
    {
        string[] items;
        int[] quantity;

        public Add(string[] userItems, int[] userQuantity)
        {
            items = userItems;
            quantity = userQuantity;
        }

        private void AddItemsQuantity(ref string item, ref int quantity)
        {
            do
            {
                Console.Write("Name of item: ");
                item = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(item))
                    Console.WriteLine("Please type the correct name.");
            } while (string.IsNullOrWhiteSpace(item));

            do
            {
                Console.Write("Quantity of item: ");
                quantity = Convert.ToInt32(Console.ReadLine());
                if (quantity < 0)
                    Console.WriteLine("Please type the correct quantity.");
            } while (quantity < 0);
        }

        private void AddExistItemsQuantity(ref int quantity)
        {
            Console.WriteLine("How many items do you want to add?");
            int newQuantity = Convert.ToInt32(Console.ReadLine());
            quantity += newQuantity;
        }

        public (string[], int[]) Program()
        {
            if (!string.IsNullOrWhiteSpace(items[0]))
            {
                string choice;
                do
                {
                    Console.WriteLine("Store is full.\n 1 - change item's quantity.\n2 - don't change anything.");
                    choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1":
                            Console.WriteLine("Enter the name of item, which quantity you want to change.");
                            string changeItem = Console.ReadLine();

                            for (int i = 0; i < items.Length; i++)
                            {
                                if (items[i] == changeItem)
                                    AddExistItemsQuantity(ref quantity[i]);
                                else
                                    Console.WriteLine("There is no such an item.");
                            }
                            break;

                        case "2":
                            var _result = (items, quantity);

                            return _result;

                        default:
                            Console.WriteLine("Wrong Key!");
                            Console.WriteLine("Press any key to continue");
                            Console.ReadKey();
                            break;
                    }
                } while (choice != "2");
            }
            else
            {
                int index = 0;
                for (int i = 0; i < items.Length; i++)
                {
                    Console.WriteLine($"{index}.");
                    AddItemsQuantity(ref items[i], ref quantity[i]);
                    Console.WriteLine();
                    index++;
                }
            }

            var result = (items, quantity);
            return result;
        }
    
    }
}

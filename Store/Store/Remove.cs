using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Remove
    {
        string[] items;
        int[] quantity;

        public Remove(string[] userItems, int[] userQuantity)
        {
            items = userItems;
            quantity = userQuantity;
        }

        private void RemoveQuantity(ref int quantity)
        {
            int removeQuantity;

            do
            {
                Console.WriteLine("How many items do you want to remove from store?");
                removeQuantity = Convert.ToInt32(Console.ReadLine());

                if (removeQuantity > quantity)
                    Console.WriteLine("There are no so many items. Please try again.");
                else
                    quantity = quantity - removeQuantity;
            } while (removeQuantity > quantity);
        }

        public (string[], int[]) Program()
        {
            if (string.IsNullOrWhiteSpace(items[0]))
            {
                Console.WriteLine("Store is empty");

                var _result = (items, quantity);
                return _result;
            }

            Console.WriteLine("Enter the name of item, which quantity you want to change.");
            string changeItem = Console.ReadLine();

            bool find = false;
            int index = 0;
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == changeItem)
                {
                    find = true;
                    index = i;
                    break;
                }
                else
                {
                    find = false;
                }
            }

            if (find == true)
            {
                RemoveQuantity(ref quantity[index]);
            }
            else
            {
                Console.WriteLine("There is no such an item.");
            }

            var result = (items, quantity);
            return result;
        }
    }
}

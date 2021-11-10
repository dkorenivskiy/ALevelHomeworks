using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Display
    {
        string[] items;
        int[] quantity;

        public Display(string[] userItems, int[] userQuantity)
        {
            items = userItems;
            quantity = userQuantity;
        }  

        public int Program()
        {
            if (string.IsNullOrWhiteSpace(items[0]))
            {
                Console.WriteLine("Store is empty");
                return 0;
            }

            int index = 0;
            Console.Write($"Id{"",10} Name{"",10} Quantity\n");
            for (int i = 0; i < items.Length; i++)
            {
                if(items[i].Length > 15)
                {
                    items[i].Remove(14, items[i].Length - 14);
                }

                Console.WriteLine($"{index}.{"",10} {items[i]}{"",10} {quantity[i]}");
                index++;
            }

            return 0;
        }
    }
}

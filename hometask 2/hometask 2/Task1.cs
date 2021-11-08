using System;
using System.Collections.Generic;
using System.Text;

namespace hometask_2
{
    class FirstTask : BaseTask
    {
        public FirstTask()
        {
            _rndFrom = -150;
            _rndTo = 150;
        }

        protected int FindElements(int [] array, int size)
        {
            int countElems = 0;
            Console.WriteLine("Element which -100 < x < 100:");
            for (int i = 0; i < size; i++)
            {
                if ((array[i] > (-100)) && (array[i] < 100))
                {
                    Console.WriteLine("{0}. {1}", i, array[i]);
                    countElems++;
                }
            }

            return countElems;
        }

        public override void Execute()
        {
            Console.WriteLine("Write size of array");
            int sizeArray = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[sizeArray];

            FillArray(array, sizeArray);
            Console.WriteLine("Array A:");
            PrintArray(array, sizeArray);
            Console.WriteLine();
            Console.WriteLine("Edited array A:");
            int countElems = FindElements(array, sizeArray);
            Console.WriteLine();
            Console.WriteLine("{0} elements which -100 < x < 100:", countElems);
        }
    }
}
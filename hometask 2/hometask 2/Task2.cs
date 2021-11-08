using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hometask_2
{
    class SecondTask : BaseTask
    {
        public SecondTask()
        {
            _rndFrom = -1000;
            _rndTo = 1000;
        }

        protected int FindElements(int[] array, int size)
        {
            int countElems = 0;
            for (int i = 0; i < size; i++)
            {
                if (array[i] <= 888)
                {
                    countElems++;
                }
            }

            return countElems;
        }

        private void CopyElements(int[] arrayOne , int[] arrayTwo, int sizeOne)
        {
            int k = 0;
            for (int i = 0; i < sizeOne; i++)
            {
                if (arrayOne[i] <= 888)
                {
                    arrayTwo[k] = arrayOne[i];
                    k++;
                }
            }
        }

        void SortArray(int[] array, int size)
        {
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if(array[i] < array[j])
                    {
                        int buffer = array[i];
                        array[i] = array[j];
                        array[j] = buffer;
                    }
                }
            }
        }

        public override void Execute()
        {
            int sizeA = 20;
            int[] arrayA = new int[sizeA];

            FillArray(arrayA, sizeA);
            Console.WriteLine("Array A:");
            PrintArray(arrayA, sizeA);
            Console.WriteLine();

            int sizeB = FindElements(arrayA, sizeA);
            int[] arrayB = new int[sizeB];

            CopyElements(arrayA, arrayB, sizeA);
            Console.WriteLine("Array B:");
            PrintArray(arrayB, sizeB);
            Console.WriteLine();

            SortArray(arrayB, sizeB);
            Console.WriteLine();
            Console.WriteLine("Edited array B:");
            PrintArray(arrayB, sizeB);
        }
    }
}
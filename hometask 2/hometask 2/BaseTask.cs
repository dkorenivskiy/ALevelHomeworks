using System;
using System.Collections.Generic;
using System.Text;

namespace hometask_2
{
    abstract class BaseTask
    {
        protected int _rndFrom;
        protected int _rndTo;
        protected void FillArray(int[] array, int size)
        {
            for (int i = 0; i < size; i++)
            {
                array[i] = new Random().Next(_rndFrom, _rndTo);
            }
        }

        protected void PrintArray(int[] array, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("{0}. {1}", i, array[i]);
            }
        }

        public abstract void Execute();
    }
}

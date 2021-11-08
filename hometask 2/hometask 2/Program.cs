using System;

namespace hometask_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string exit = null;

            while (exit != "exit")
            {
                Console.WriteLine("HomeTask #2");
                Console.WriteLine("Task #1 - 1");
                Console.WriteLine("Task #2 - 2");
                Console.WriteLine("Exit - type 'exit'");

                exit = Console.ReadLine();

                BaseTask task;

                switch (exit)
                {
                    case "1":
                        task = new FirstTask();
                        break;

                    case "2":
                        task = new SecondTask();
                        break;

                    default:
                        continue;
                }

                task.Execute();
            } 
        }
    }
}

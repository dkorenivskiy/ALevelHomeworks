using System;
using System.Collections.Generic;
using System.Text;

namespace hometask3
{
    class WorkWithString
    {
        public static int CountWords(string userString)
        {
            int count = 0;

            string[] words = userString.Split(' ');
            foreach (string s in words)
            {
                count++;
            }

            return count;
        }

        public static bool IfLettersOrPuncts(string userString)
        {
            int countLett = 0;
            int countPuncts = 0;

            string[] words = userString.Split(' ');

            foreach (string s in words)
            {
                countLett = 0;
                countPuncts = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (char.IsLetter(s[i]))
                        countLett++;

                    if (char.IsPunctuation(s[i]))
                        countPuncts++;
                }

                if (countLett == 0)
                    break;
            }



            if (countLett < 2 || countPuncts != 0)
                return false;
            else
                return true;
        }

        public static void PrintWords(string []words)
        {
            foreach(string s in words)
            {
                Console.Write("{0} ", s);
            }
            Console.WriteLine();
        }

        public static string CollectWords(string[] words)
        {
            string result = string.Join(' ', words);

            return result;
        }
    }
}

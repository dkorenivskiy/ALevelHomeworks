using System;
using System.Collections.Generic;
using System.Text;

namespace hometask3
{
    class Point2
    {
        string userStr;

        public Point2(string userString)
        {
            userStr = userString;
        }

        private string ChangeRegister(string str)
        {
            char[] words = str.ToCharArray();

            for (int i = 0; i < words.Length; i++)
            {
                if(i == 0)
                    words[i] = char.ToUpper(words[i]);
                else
                    words[i] = char.ToLower(words[i]);
            }

            str = new string(words);

            return str;
        }

        public string Program()
        {
            string[] words = userStr.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = ChangeRegister(words[i]);
            }

            WorkWithString.PrintWords(words);

            return WorkWithString.CollectWords(words);
        }
    }
}

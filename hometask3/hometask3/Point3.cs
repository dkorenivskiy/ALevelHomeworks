using System;
using System.Collections.Generic;
using System.Text;

namespace hometask3
{
    class Point3 
    {
        string userStr;

        public Point3(string userString)
        {
            userStr = userString;
        }

        private string ChangeLetter(string s)
        {
            char[] letters = s.ToCharArray();
            
            if (letters[0] == 'P' || letters[0] == 'p')
                letters[0] = 'S';

            if (letters[letters.Length - 1] == 'N' || letters[letters.Length - 1] == 'n')
                letters[letters.Length - 1] = 'O';

            s = new string(letters);
            return s;
        }

        public string Program()
        {
            string[] words = userStr.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int k = 0;
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = ChangeLetter(words[i]);
            }

            WorkWithString.PrintWords(words);

            return WorkWithString.CollectWords(words);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace hometask3
{
    class Point1
    {
        private string userStr;

        public Point1(string userString)
        {
            userStr = userString;
        }

        private string DeleteNumbs(string s)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (!char.IsDigit(s[i]))
                {
                    result.Append(s[i]);
                }
            }

            return result.ToString();
        }

        private string ReverseWords(string s)
        {
            var chars = s.ToCharArray();
            Array.Reverse(chars);
            var result = new string(chars);

            return result;
        }

        public string Program()
        {
            string[] words = userStr.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int k = 0;
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = DeleteNumbs(words[i]);
            }

            for (var i = 0; i < words.Length; i += 2)
            {
                words[i] = ReverseWords(words[i]);
            }

            WorkWithString.PrintWords(words);

            return WorkWithString.CollectWords(words);
        }
    }
}

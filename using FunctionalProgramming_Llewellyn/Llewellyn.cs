using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming_Llewellyn
{
    class Llewellyn
    {
        public delegate string LettersDelegate(string str);
        public LettersDelegate letterDelegate;

        public string OrderLetters(string str)
        {
            StringBuilder builder = new StringBuilder();
            if (str == null) return null;
            if (str == "") return "";
            str = str.ToUpper();
            char[] word = str.ToCharArray();
            Array.Sort(word);
            int count = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] < 'A' || word[i] > 'Z') continue;
                if (builder.Length == 0)
                {
                    builder = builder.Append(word[i]);
                    count = 1;
                }
                else if (word[i] == word[i - 1])
                {
                    count++;
                }
                else
                {
                    builder = builder.Append(count.ToString());
                    builder = builder.Append(word[i]);
                    count = 1;
                }
            }
            builder = builder.Append(count.ToString());
            return builder.ToString();
        }
    }
}

//Write a function that takes in a string of letters(e.g., "Llewellyn") 
//and returns a alphabetically ordered string corresponding to the letter frequency (e.g., "E2L4N1W1Y1")

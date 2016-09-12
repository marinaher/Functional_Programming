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

        public void OrderLetters()
        {
            string word = "Llewellyn";

            var letterCount = word.ToUpper()
                .OrderBy(x => x)
                .GroupBy(c => c)
                .Select(k => new { Char = k.Key, Count = k.Count() });

            foreach (var y in letterCount)
            {
                Console.Write("{0}{1}", y.Char, y.Count);
            }

            Console.ReadLine();
        }
    }
}

//Write a function that takes in a string of letters(e.g., "Llewellyn") 
//and returns a alphabetically ordered string corresponding to the letter frequency (e.g., "E2L4N1W1Y1")

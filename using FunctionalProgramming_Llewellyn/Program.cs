using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming_Llewellyn
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Llewellyn";
            Llewellyn functionalProgramming = new Llewellyn();

            functionalProgramming.letterDelegate = (string x) => { return functionalProgramming.OrderLetters(x); };

            Console.WriteLine(functionalProgramming.OrderLetters(word));
            Console.ReadLine();
        }
    }
}

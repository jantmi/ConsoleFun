using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence and I will count the vowels for you:");
            string theSentence = Console.ReadLine();
            Console.WriteLine("Thanks for the sentence \"" + theSentence + "\".");

            var aCount = 0;
            var eCount = 0;
            var iCount = 0;
            var oCount = 0;
            var uCount = 0;

            foreach (char currentChar in theSentence)
            {
                if (currentChar.ToString().ToLower() == "a")
                {
                    aCount++;
                }
                if (currentChar.ToString().ToLower() == "e")
                {
                    eCount++;
                }
                if (currentChar.ToString().ToLower() == "i")
                {
                    iCount++;
                }
                if (currentChar.ToString().ToLower() == "o")
                {
                    oCount++;
                }
                if (currentChar.ToString().ToLower() == "u")
                {
                    uCount++;
                }
            }

            Console.WriteLine("Here are the totals....");
            Console.WriteLine("a = " + aCount);
            Console.WriteLine("e = " + eCount);
            Console.WriteLine("i = " + iCount);
            Console.WriteLine("o = " + oCount);
            Console.WriteLine("u = " + uCount);

            Console.Read();
        }
    }
}

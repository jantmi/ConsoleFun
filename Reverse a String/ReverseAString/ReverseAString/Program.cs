using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string you wish to reverse below:");
            string originalString = Console.ReadLine();
            Console.WriteLine("The string you want to reverse is " + originalString);
            string reversedString = new string(originalString.Reverse().ToArray());
            Console.WriteLine("The reversed string is " + reversedString);
            Console.Read();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string word, reverse;
            Console.WriteLine("enter a word: ");
            word = Console.ReadLine();
            char[] ch = word.ToCharArray();

            Array.Reverse(ch);
            reverse = new string(ch);

            bool b = word.Equals(reverse, StringComparison.OrdinalIgnoreCase);
            if (b == true)
            {
                Console.WriteLine("" + word + " is a Palindrome!");
            }
            else
            {
                Console.WriteLine(" " + word + " is not a Palindrome!");
            }
            Console.Read();
        }
    }
}

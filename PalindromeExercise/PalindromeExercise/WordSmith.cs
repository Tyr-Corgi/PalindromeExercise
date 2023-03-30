using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public WordSmith()
        {

            //Console.WriteLine("What is your name?");
            //string name = Console.ReadLine();

            //if (IsAPalindrome(name) == true) { Console.WriteLine($"{name}is a Palindrome!"); } else { Console.WriteLine($"{name} is not a palindrome."); }
        }
        public bool IsAPalindrome(string nameHolder)
        {
            string nameForward, nameBackward;
            nameForward = nameHolder.ToLower();
            char[] nameForwardArray = nameForward.ToCharArray();
            Array.Reverse(nameForwardArray);
            nameBackward = new string(nameForwardArray);

          return nameForward==nameBackward ? true : false;
                
        }



    }
}

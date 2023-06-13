using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        #region Challenge description

        /*

        Write a program that converts numbers into words.
        Considerations:
        Range: 0 - 9999
        Language: english
        Only Integers
        Consider invalid inputs

        Example:
        Input: 9        - Output: nine
        Input: 75       - Output: seventy five
        input: 256      - Output: two hundred fifty six
        Input: 3985     - Output: three thousand nine hundred eighty five 
        Input: a34      - Output: error
        Input:          - Output: error
        Input: -5623    - Output: error

        */

        #endregion

        #region Program

        public static string NumbersToText(int input)
        {
            return Number.ToText(input);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("-Number to text examples-");
            Console.WriteLine($"8: {NumbersToText(8)}");
            Console.WriteLine($"10: {NumbersToText(10)}");
            Console.WriteLine($"13: {NumbersToText(13)}");
            Console.WriteLine($"19: {NumbersToText(19)}");
            Console.WriteLine($"33: {NumbersToText(33)}");
            Console.WriteLine($"69: {NumbersToText(69)}");
            Console.WriteLine($"80: {NumbersToText(80)}");
            Console.WriteLine($"99: {NumbersToText(99)}");
            Console.WriteLine($"101: {NumbersToText(101)}");
            Console.WriteLine($"110: {NumbersToText(110)}");
            Console.WriteLine($"444: {NumbersToText(444)}");
            Console.WriteLine($"510: {NumbersToText(510)}");
            Console.WriteLine($"890: {NumbersToText(890)}");
            Console.WriteLine($"1000: {NumbersToText(1000)}");
            Console.WriteLine($"1001: {NumbersToText(1001)}");
            Console.WriteLine($"1010: {NumbersToText(1010)}");
            Console.WriteLine($"1101: {NumbersToText(1101)}");
            Console.WriteLine($"1110: {NumbersToText(1110)}");
            Console.WriteLine($"1111: {NumbersToText(1111)}");

            Console.WriteLine("Please type the number:");
            string input = Console.ReadLine();
            Console.WriteLine(NumbersToText(int.Parse(input)));
            Console.ReadKey();

        }
    }
    #endregion
}

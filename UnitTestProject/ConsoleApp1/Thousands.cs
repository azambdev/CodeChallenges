using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Thousands:Number
    {


        internal static string _thousandsKeyWord = "thousand";
        private static Dictionary<int, string> _thousands = new Dictionary<int, string>()
        {
            [0] = "",
            [1] = "one",
            [2] = "two",
            [3] = "three",
            [4] = "four",
            [5] = "five",
            [6] = "six",
            [7] = "seven",
            [8] = "eight",
            [9] = "nine",
        };

        public static new string ToText(int number)
        {
            return number == 0 ? _thousands[number] : string.Join(" ", _thousands[number], _thousandsKeyWord);
        }





    }
}

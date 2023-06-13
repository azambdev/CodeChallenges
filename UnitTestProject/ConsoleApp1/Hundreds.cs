using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Hundreds:Number
    {

        internal static string _hundredKeyWord = "hundred";
        private static Dictionary<int, string> _hundreds = new Dictionary<int, string>()
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
            return number == 0 ? _hundreds[number].Trim() : string.Join(" ", _hundreds[number], _hundredKeyWord).Trim();
        }






    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Number
    {

        internal static string ToText(int input)
        {
            if (input < 0) return "error";


            int lenght = input.ToString().Length;

            switch (lenght)
            {
                case 1:

                    return input == 0 ? "zero" : Units.ToText(input);

                case 2:

                    return input <= 19 ? Tens.ToText(input) : string.Join(" ", Tens.ToText(input / 10), Units.ToText(input % 10)).Trim();

                case 3:

                    int lastTwoDigits = input % 100;
                    if (lastTwoDigits <= 19 && lastTwoDigits > 10)
                    {
                        return string.Join(" ", Hundreds.ToText(input / 100), Tens.ToText(lastTwoDigits)).Trim();
                    }
                    if (((input / 10) % 10) == 0)
                    {
                        return string.Join(" ", Hundreds.ToText(input / 100), Units.ToText(input % 10)).Trim();
                    }

                    return string.Join(" ", Hundreds.ToText(input / 100), Tens.ToText((input / 10) % 10), Units.ToText(input % 10)).Trim();

                case 4:

                    lastTwoDigits = input % 100;
                    if (lastTwoDigits <= 19 && lastTwoDigits > 10)
                    {
                        return string.Join(" ", Thousands.ToText(input / 1000), Hundreds.ToText((input / 100) % 10), Tens.ToText(lastTwoDigits)).Trim();
                    }

                    if (((input / 10) % 10) == 0)
                    {
                        return string.Join(" ", Thousands.ToText(input / 1000), Hundreds.ToText(input / 100 % 10), Units.ToText(input % 10)).Trim();
                    }

                    return string.Join(" ", Thousands.ToText(input / 1000), Hundreds.ToText((input / 100) % 10), Tens.ToText((input / 10) % 10), Units.ToText(input % 10)).Trim();


                default:
                    return "error";
            }




        }


    }
}

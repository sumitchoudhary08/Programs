using System;

namespace FactorialProgram
{
    /// <summary>
    /// Facorial program for large numbers.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int number = 100;
            int temp = number - 1;
            string num1 = number.ToString();
            string num2 = temp.ToString();
            while (temp > 0)
            {
                num1 = Multiply(num1, num2);
                num2 = (Convert.ToInt32(num2) - 1).ToString();
                temp--;
            }

            Console.Write("Factorial of " + number + " is: " + num1);
            Console.ReadKey();
        }

        /// <summary>
        /// multiply two string and returns result.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static string Multiply(string num1, string num2)
        {
            if (num1 == "0" || num2 == "0")
                return "0";

            int num1Len = num1.Length;
            int num2Len = num2.Length;

            char[] result = new char[num1Len + num2Len];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = '0';
            }

            int remainder = 0;
            int placeSpecifier = result.Length - 1;
            int initialize = result.Length - 1;

            for (int j = num1Len - 1; j >= 0; j--)
            {
                int multiplier = int.Parse(num1[j].ToString());

                for (int k = num2Len - 1; k >= 0; k--)
                {
                    int multiplyBy = int.Parse(num2[k].ToString());

                    int product = multiplier * multiplyBy + remainder + int.Parse(result[placeSpecifier].ToString());
                    remainder = 0;

                    int unitAns = product % 10;

                    if (product > 9)
                    {
                        remainder = product / 10;
                    }

                    result[placeSpecifier] = Convert.ToChar(unitAns.ToString());
                    placeSpecifier--;
                }

                if (remainder > 0)
                {
                    result[placeSpecifier] = Convert.ToChar(remainder.ToString());
                    remainder = 0;
                }

                initialize--;
                placeSpecifier = initialize;
            }

            if (remainder > 0)
            {
                result[placeSpecifier] = Convert.ToChar(remainder.ToString());
                remainder = 0;
            }


            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] == '0')
                {
                    result[i] = ' ';
                }
                else {
                    break;
                }
            }

            return new string(result).Trim();
        }
    }
}

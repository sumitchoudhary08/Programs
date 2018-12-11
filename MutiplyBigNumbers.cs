using System.IO;
using System;

//Multiplication.
class Program
{
    static void Main()
    {
        //string number1 = "797897897897676765";
        //string number2 = "7098909809889789789787";
        string number1 = "12";
        string number2 = "12";
        string multiple = Multiply(number1, number2);
        Console.Write(string.Format("{0} * {1} = {2}", number1, number2, multiple));
        
        
    }
    
    public static string Multiply(string num1, string num2)
    {
        if (num1 == "0" || num2 == "0") 
            return "0";

        int num1_len = num1.Length;
        int num2_len = num2.Length;

        // it will initialize the result with all zeros 
        // with the length as sum of both given number length.
        char[] result = new char[num1_len + num2_len];
        for (int k = 0; k < result.Length; k++)
        {
            result[k] = '0';
        }

        int remainder = 0;
        int placeSpecifier = result.Length - 1;
        // starting from the right most index.
        int initialize = result.Length - 1;

        for (int i = num1_len - 1; i >= 0; i--)
        {
            int multiplier = int.Parse(num1[i].ToString());

            for (int j = num2_len - 1; j >= 0; j--)
            {
                int multiplyBy = int.Parse(num2[j].ToString());

                int product = multiplier * multiplyBy + remainder
                             + int.Parse(result[placeSpecifier].ToString());
                remainder = 0;

                int unitAns = product % 10;
                // carry forward
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
        
        // remove the 0s from the beginning, if any.
        for (int i = 0; i < result.Length; i++)
        {
            if (result[i] == '0') 
                result[i] = ' ';
            else
                break;
        }

        return new string(result).Trim();
    }
    
}
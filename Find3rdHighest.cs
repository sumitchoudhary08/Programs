using System.IO;
using System;

//Find 3rd highest number.
class Program
{
    static void Main()
    {
        //array must be sorted in ascending order.
        int []arr = {5, 10, 23, 24, 3, 91};
        int number = FindThirdHighest(arr);
        
        Console.WriteLine(number);
    }
    
    //Sorting the given list and returns the third highest number.
    public static int FindThirdHighest(int []arr)
    {
        Array.Sort(arr); //sorts the array.
        return arr[arr.Length-3];
    }
}
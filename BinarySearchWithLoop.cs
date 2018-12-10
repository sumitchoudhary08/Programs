using System.IO;
using System;

//Binary seacrh program with iteration.
class Program
{
    static void Main()
    {
        //array must be sorted in ascending order.
        int []arr = {5, 10, 23, 24, 78, 91};
        int searchElement = 78;
        int index = BinarySearch(arr, 0, arr.Length-1, searchElement);
        
        if(index != -1)
            Console.WriteLine(searchElement + " is present at index: " + index);
        else
            Console.WriteLine(searchElement + " is not present int the given list.");
    }
    
    //FInd the given element using loop, bineary search algo.
    public static int BinarySearch(int []arr, int startIndex, int lastIndex, int searchElement)
    {
        while(startIndex <= lastIndex)
        {
            int midIndex = startIndex + (lastIndex - startIndex)/2;
        
            if(arr[midIndex] == searchElement)
                return midIndex;
                
            if(searchElement > arr[midIndex] )
                startIndex = midIndex + 1;
                
            if(searchElement < arr[midIndex] )
                lastIndex = midIndex - 1;
        }
        
        return -1;
    }
}
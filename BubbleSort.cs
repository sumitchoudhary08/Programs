using System.IO;
using System;

class Program
{
    static void Main()
    {
        int[] arr = {1, 2, 3, 4,5 };
        SortAndDisplay(arr);
        //Console.WriteLine("Hello, World!");
    }
    
    public static void SortAndDisplay(int[] arr)
    {
        for(int i=0; i<arr.Length; i++)
        {
            bool swapped = false;
            for(int j=0; j<arr.Length-i-1; j++)
            {
                if(arr[j] > arr[j+1])
                {
                    int temp = arr[j+1];
                    arr[j+1] = arr[j];
                    arr[j] = temp;
                    swapped = true;
                }
            }
            
            if(swapped)
                break;
        }
        
        
        for(int i=0; i<arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}
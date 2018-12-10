using System.IO;
using System;

class Program
{
    static void Main()
    {
        int[] arr = {1, 21, 3, 41, 5};
        SortAndDisplay(arr);
        //Console.WriteLine("Hello, World!");
    }
    
    public static void SortAndDisplay(int[] arr)
    {
        for(int i=0; i<arr.Length -1; i++)
        {
            int minIndex = i;
            for(int j=i+1; j<arr.Length; j++)
            {
                if(arr[minIndex] > arr[j])
                {
                    minIndex = j;
                }
            }
            
            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }
        
        
        for(int i=0; i<arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}
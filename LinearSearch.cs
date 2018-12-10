using System.IO;
using System;

//Linear seacrh program.
class Program
{
    static void Main()
    {
        int[] arr = {10, 23, 24, 5, 6};
        int searchElement = 6;
        SearchElement(arr, searchElement);
    }
    
    //Finds the given elemnt for the list of elements.
    public static void SearchElement(int[] arr, int searchElement){
        bool elementFound = false;
        for(int i=0; i<arr.Length; i++)
        {
            if(searchElement == arr[i])
            {
                Console.WriteLine(searchElement + " is present at index: " + i);
                elementFound = true;
                break;
            }
        }
        
        if(!elementFound)
            Console.WriteLine(searchElement + " is not present in the given list.");
    }
}
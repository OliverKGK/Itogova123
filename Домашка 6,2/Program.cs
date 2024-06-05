using System; 
 
class Program 
{ 
    static void Main() 
    { 
        int[] myArray = { 1, 2, 3, 4, 5 }; 
 
        Console.WriteLine("Элементы массива, начиная с конца:"); 
        PrintArrayReverse(myArray, myArray.Length - 1); 
    } 
 
    static void PrintArrayReverse(int[] arr, int index) 
    { 
        if (index >= 0) 
        { 
            Console.Write(arr[index] + " "); 
            PrintArrayReverse(arr, index - 1); 
        } 
    } 
}
using System;
using System.Diagnostics;
using System.Threading;

namespace sort
{
    class Program
    {
       static void bubbleSort(int []arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
            for (int j = 0; j < n - i - 1; j++)
                if (arr[j] > arr[j + 1])
                {
                    
                    int element = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = element;
                }
    }
  
    
    static void printArray(int []arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; ++i)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }
  
    
    public static void Main()
    {int []arr = new int[8000];
    Random rnd = new Random();
    for (int i = 0; i < 8000; i++) {
  arr[i] = rnd.Next(0,1000) ;
}
    
        Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();
        bubbleSort(arr);
        
        stopwatch.Stop();
         Console.WriteLine("Sorted array");
        printArray(arr);
        Console.WriteLine("Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);
    }
    }
}

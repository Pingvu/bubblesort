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
    {Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();
        int []arr = {2000,1000,4000,8000, 9000 ,1000000, 2384234, 10,4,6,293,56,21,56};
        bubbleSort(arr);
        
        stopwatch.Stop();
         Console.WriteLine("Sorted array");
        printArray(arr);
        Console.WriteLine("Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);
    }
    }
}

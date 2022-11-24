/*
double n = double.Parse(Console.ReadLine());
double m = double.Parse(Console.ReadLine());
Console.WriteLine(n + " * " + m + " = " + n + m);
Console.WriteLine(n + " - " + m +" = " + (n - m));
Console.WriteLine(n + " * " + m + " = " + n * m);
Console.WriteLine(n + " / " + m +" = " + n / m);
Console.WriteLine(n + " % " + m+ " = " + n % m);
*/
/*
int[] arr = new int[10] ;
int n = int.Parse(Console.ReadLine());
for (int i = 0; i< n-1; i++)
{
  arr[i] = int.Parse(Console.ReadLine());
    int min = i;
    
  
    for (int j = 1; j < n; j++)
    {
        if (arr[j] > arr[min])
        {
            min = j;
        }
    }
    int sort = arr[i];
    arr[i] = arr[min];
    arr[min] = sort;
  
}
Console.Write(" sorted array:{0} ", string.Join(",", arr));
*/


using System;
public class Example
{
    static void Main(string[] args)
    {
        int[] arr = new int[10] ;
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Selection sort");
        Console.Write("Initial array is: ");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        int temp, smallest;
        for (int i = 0; i < n - 1; i++)
        {
            smallest = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[smallest])
                {
                    smallest = j;
                }
            }
            temp = arr[smallest];
            arr[smallest] = arr[i];
            arr[i] = temp;
        }
        Console.WriteLine();
        Console.WriteLine("Sorted array is: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}

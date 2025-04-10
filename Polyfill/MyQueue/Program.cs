using System;
using System.Runtime.CompilerServices;
using MyQueue;

public class Program
{
    public static void Main()
    {
         Queue<int> numbers = new Queue<int>();

        // adds 65 and 17 to the queue
        numbers.Enqueue(65);
        numbers.Enqueue(17);

        // print elements of the queue 
        foreach (int item in numbers)
        {
            Console.WriteLine(item);
        }
    }
}
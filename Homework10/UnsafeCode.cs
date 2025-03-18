using System;
namespace project.cs
{
    internal class Program
    {
        unsafe static void Main(string[] args)
        {
            const int size = 10;
            int* ptr = stackalloc int[size];

            for (int i = 0; i < size; i++)
            {
                *(ptr + i) = int.Parse(Console.ReadLine());
            }
            int max = *(ptr);
            for (int i = 1; i < size; i++)
            {
                if (*(ptr + i) > max)
                {
                    max = *(ptr + i);
                }
            }
            Console.WriteLine("The max element in this array is: " + max);
        }
    }
}

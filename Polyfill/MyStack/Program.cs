using System;
using MyStack;
public class Program
{
    public static void Main()
    {
        MyStack<string> arr = new MyStack<string>();
        arr.Push("a");
        Console.WriteLine (arr.Peek());

        arr.Push("b");
        Console.WriteLine (arr.Peek());

        arr.Push("c");
        Console.WriteLine (arr.Peek());

        arr.Pop();
        Console.WriteLine (arr.Peek());
    }
}
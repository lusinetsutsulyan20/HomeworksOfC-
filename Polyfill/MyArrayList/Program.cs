using System;
using System.Collections;
using MyArray;
public class Program
{
    public static void Main()
    {
        MyArrayList arr = new MyArrayList();
        // arr.Add(5);
        // arr.Add(3);
        // arr.Add("SDf");
        // arr.Print();
        // arr.RemoveAt(0);
        // // Console.WriteLine(arr[1]);
        // arr.Insert(5, 9);
        // arr.Print();
        // Console.WriteLine (arr.Contains(9));
        // Console.WriteLine (arr.Contains("Svc"));

        Person p1 = new Person("Anna", 15);
        Person p2 = new Person("Ani", 22);

        arr.Add(p1);
        arr.Add(p2);
        arr.Print();
    }
}   
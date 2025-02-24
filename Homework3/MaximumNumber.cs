using System;
public class MaxNumber{
    public static void MaxOfArray(ref int n, params int[] numbers){
        int max = n;
        foreach (int num in numbers){
            if (num > max){
                max = num;
            }
        }
        Console.WriteLine($"The maximum number of array is {max}");
    }
}
 internal class BookLibrary{
    static void Main(string[] args){
        int[] arr = new int[5];
        for (int i = 0; i < arr.Length; i++){
            arr[i] = int.Parse(Console.ReadLine() ?? "");
        }
        int max = 5;
        MaxNumber.MaxOfArray(ref max, arr);
        Console.WriteLine(max);
   }
}

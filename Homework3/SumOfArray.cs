using System;
public class SumNumber{
    public static void SumOfArray(ref int sum, params int[] numbers){
        foreach (int num in numbers){
            sum += num;
        }
        Console.WriteLine($"The maximum number of array is {sum}");
    }
}
 internal class SumNumbers{
    static void Main(string[] args){
        int[] arr = new int[5];
        for (int i = 0; i < arr.Length; i++){
            arr[i] = int.Parse(Console.ReadLine() ?? "");
        }
        int sum = 0;
        SumNumber.SumOfArray(ref sum, arr);
        Console.WriteLine(sum);
   }
}

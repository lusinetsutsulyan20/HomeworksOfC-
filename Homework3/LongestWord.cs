using System;
public class LongestWord{
    public static string Find(params string[] arr){
        int max = arr[0].Length;
        int index = 0;
        for (int i = 1; i < arr.Length; i++){
            if (max < arr[i].Length){
                max = arr[i].Length;
                index = i;
            }
        }
        return arr[index];
    }
}
 internal class task{
    static void Main(string[] args){
        string[] arr = new string[5];
        for (int i = 0; i < arr.Length; i++){
            arr[i] = Console.ReadLine() ?? "";
        }
        string res = LongestWord.Find(arr);
        Console.WriteLine(res);
   }
}

using System;
public class FibonacciSequence{
     public static int Fib(int n){
            if (n <= 1) {
                return n;
            } 
            return Fib(n - 1) + Fib(n - 2);
        }
}
 internal class BookLibrary{
    static void Main(string[] args){
        int number = int.Parse(Console.ReadLine() ?? "");
        Console.WriteLine (FibonacciSequence.Fib (number));
   }
}

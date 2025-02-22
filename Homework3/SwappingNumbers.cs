using System;
class SwappingNumbers {
    static void Swap (ref int a,ref int b){
        int tmp = a;
        a = b;
        b = tmp;
    }
       
    static void Main() {
        int a = int.Parse(Console.ReadLine() ?? "");
        int b = int.Parse(Console.ReadLine() ?? "");
        
        Console.WriteLine (a);
        Console.WriteLine (b);
     
        Swap(ref a, ref b);
        
        Console.WriteLine ("Is Swapped");
        
        Console.WriteLine (a);
        Console.WriteLine (b);
    }
}









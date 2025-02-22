using System;
class BasicCalculator {
    public static int Add (int a, int b){
        return a + b;
    }
    
    public static int Subtract (int a, int b){
        return a - b;    
    }
       
    public static int Multiply (int a, int b){
        return a * b;
    }
    
    public static int Divide (int a, int b){
        return (a / b);
    }
       
       
    static void Main() {
        int a = int.Parse(Console.ReadLine() ?? "");
        int b = int.Parse(Console.ReadLine() ?? "");
        
        int res = Add (a, b);
        Console.WriteLine ($"{a} + {b} = {res}");
        
        res = Subtract (a, b);
        Console.WriteLine ($"{a} - {b} = {res}");
        
        res = Multiply (a, b);
        Console.WriteLine ($"{a} * {b} = {res}");
        
        res = Divide (a, b);
        Console.WriteLine ($"{a} / {b} = {res}");
        
    }
}









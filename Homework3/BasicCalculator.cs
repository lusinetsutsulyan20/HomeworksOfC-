
using System;
public static class BasicCalculator {
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
       
    public static void Calculate(){
        Console.WriteLine("Enter action");
        string i = Console.ReadLine() ?? "";
        if (i == "x"){
            Console.WriteLine("Recursion finished");
            return;
        }
        Console.WriteLine ("Enter two numbers");
        int first = int.Parse(Console.ReadLine() ?? "");
        int second = int.Parse(Console.ReadLine() ?? "");
        
        switch(i){
            case "+":
                Console.WriteLine(Add(first, second));
                break;
            case "-":
                Console.WriteLine(Subtract(first, second));
                break;
            case "*":
                Console.WriteLine(Multiply(first, second));
                break;
            case "/":
                Console.WriteLine(Divide(first, second));
                break;
            default:
                Console.WriteLine("Enter 'x' for break");
                break;
        }
        Calculate();
    }
}
  internal class BookLibrary{
   static void Main(string[] args){
    
       BasicCalculator.Calculate();
   }
    
}


using System;
public static class BasicCalculator {
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
       
    public static void Calculate(){
        Console.WriteLine("Enter action");
        string i = Console.ReadLine() ?? "";
        if (i == "x"){
            Console.WriteLine("Recursion finished");
            return;
        }
        Console.WriteLine ("Enter two numbers");
        int first = int.Parse(Console.ReadLine() ?? "");
        int second = int.Parse(Console.ReadLine() ?? "");
        
        switch(i){
            case "+":
                Console.WriteLine(Add(first, second));
                break;
            case "-":
                Console.WriteLine(Subtract(first, second));
                break;
            case "*":
                Console.WriteLine(Multiply(first, second));
                break;
            case "/":
                Console.WriteLine(Divide(first, second));
                break;
            default:
                Console.WriteLine("Enter 'x' for break");
                break;
        }
        Calculate();
    }
}
  internal class BookLibrary{
   static void Main(string[] args){
    
       BasicCalculator.Calculate();
   }
    
}


using System;
public static class BasicCalculator {
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
       
    public static void Calculate(){
        Console.WriteLine("Enter action");
        string i = Console.ReadLine() ?? "";
        if (i == "x"){
            Console.WriteLine("Recursion finished");
            return;
        }
        Console.WriteLine ("Enter two numbers");
        int first = int.Parse(Console.ReadLine() ?? "");
        int second = int.Parse(Console.ReadLine() ?? "");
        
        switch(i){
            case "+":
                Console.WriteLine(Add(first, second));
                break;
            case "-":
                Console.WriteLine(Subtract(first, second));
                break;
            case "*":
                Console.WriteLine(Multiply(first, second));
                break;
            case "/":
                Console.WriteLine(Divide(first, second));
                break;
            default:
                Console.WriteLine("Enter 'x' for break");
                break;
        }
        Calculate();
    }
}
  internal class BookLibrary{
   static void Main(string[] args){
    
       BasicCalculator.Calculate();
   }   
}

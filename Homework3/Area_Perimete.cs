using System;
public class BasicCalculator{
    public static void CalculateArea(float rad, ref double area){
       double pi = Math.PI;
       area = 2 * pi * rad * rad;
    }
    public static void CalculatePerimeter(float rad, out double area){
       double pi = Math.PI;
       area = 2 * pi * rad;
    }
}
 internal class BookLibrary{
    static void Main(string[] args){
        Console.WriteLine("Enter radius");
        float radius = float.Parse(Console.ReadLine() ?? "");
        
        double area = 0;
        BasicCalculator.CalculateArea (radius, ref area);
        Console.WriteLine($"The area is {area}");
        
        double perimeter;
        BasicCalculator.CalculatePerimeter(radius, out perimeter);
        Console.WriteLine($"The perimeter is {perimeter}");
        
   }
}

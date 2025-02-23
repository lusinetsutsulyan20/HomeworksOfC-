using System;
class ConvertTemperature{
    public static void ConvertFahrenheit(double cel, ref double far){
        far = cel * (double)(9.0 / 5.0) + 32;
    }
    public static void ConvertKelvin(double cel, out double kel){
        kel = cel;
        kel += 273.15;
    }
}
 internal class BookLibrary{
    static void Main(string[] args){
        double tmp = double.Parse(Console.ReadLine() ?? "");
        double far = 0;;
        ConvertTemperature.ConvertFahrenheit(tmp, ref far);
        Console.WriteLine($"{tmp} in Fahrenheit is {far}");
        
        double kel;
        ConvertTemperature.ConvertKelvin(tmp, out kel);
        Console.WriteLine($"{tmp} in Kelvin is {kel}");
        
   }
}

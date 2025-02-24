using System;
public class Converts{
    public static void Convert(int t, out int h, out int m, out int s){
        h = t / 3600;
        m = (t - h * 3600) / 60;
        s = t - h * 3600 - m * 60;
    }
}
 internal class task{
    static void Main(string[] args){
        int totalSeconds = int.Parse(Console.ReadLine() ?? "");
        int hours = 0;
        int minutes = 0;
        int seconds = 0;
        
        Converts.Convert(totalSeconds, out hours, out minutes, out seconds);
        
        Console.WriteLine($"{totalSeconds} is {hours} hours: {minutes} minutes: {seconds} seconds");
        
   }
}

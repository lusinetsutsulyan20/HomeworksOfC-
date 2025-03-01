using System;
class WaterSystem {
    public class WaterTank {
        private double Capacity;
        private double CurrentLevel;
        
        public WaterTank (double c, double cl) {
            Capacity = c;
            CurrentLevel = cl;
        }
        public WaterTank (){
            Capacity = 0;
            CurrentLevel = 0;
        }
        
        public static WaterTank operator + (WaterTank a, WaterTank b){
            WaterTank tmp = new WaterTank();
            
            if (a.CurrentLevel + b.CurrentLevel > a.Capacity){
                Console.WriteLine("This is unavailable");
                return a;
            } 
            
            tmp.CurrentLevel = a.CurrentLevel + b.CurrentLevel;
            return tmp;
        }
        
        public static WaterTank operator - (WaterTank a, double b) {
            WaterTank tmp = new WaterTank();
            
            if (a.CurrentLevel - b < 0){
                Console.WriteLine ("This is unavailable");
                return a;
            } 
            
            tmp.CurrentLevel = a.CurrentLevel - b;
            return tmp;
        }
        
        public override string ToString (){
            return "Current Level is " + CurrentLevel;
        }
    }

    static void Main() {
        
        WaterTank obj = new WaterTank (10.0, 5.5);
        WaterTank obj2 = new WaterTank (10.0, 2.5);
        
        obj = obj + obj2;
        obj += obj2;
        
        Console.WriteLine(obj.ToString());
    }
}

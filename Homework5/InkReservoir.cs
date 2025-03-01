using System;
class DigitalInkReservoir {
    public class InkReservoir{
        private string Color;
        private double InkAmount;
        
        public InkReservoir (string color, double inkAmount){
            Color = color;
            InkAmount = inkAmount;
        }
        
        public static InkReservoir operator + (InkReservoir a, InkReservoir b){
            if (a.Color == b.Color){
                a.InkAmount += b.InkAmount;
                b = a;
                return a;
            }
            Console.WriteLine ("They have not the same color");
            return a;
        }
        
        public static InkReservoir operator - (InkReservoir a, double count){
            if (a.InkAmount - count < 0){
                Console.WriteLine ("This is unavailable");
                return a;
            }
            a.InkAmount -= count;
            return a;
        }
        
        public override string ToString (){
            return "The color is " + Color + "The InkReservoir is " + InkAmount;
        }
    }

    static void Main() {
        InkReservoir obj1 = new InkReservoir ("Red", 20.5);
        InkReservoir obj2 = new InkReservoir ("Blue", 5.4);
        InkReservoir obj3 = new InkReservoir ("Red", 4.5);
        
        obj1 = obj1 + obj3;
        Console.WriteLine (obj1.ToString());
        
        obj2 -= 3;
        Console.WriteLine (obj2.ToString());
    }
}






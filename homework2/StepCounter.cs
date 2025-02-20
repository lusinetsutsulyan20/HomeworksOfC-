namespace StepCounter
{
    public class Smartwatch{
        public string ownerName;
        public int stepCount;

        public Smartwatch(string name){
            ownerName = name;
            stepCount = 0;
        }
        public void AddSteps(int steps){
            stepCount += steps;
        }
        public void ShowSteps(){
            Console.WriteLine($"The {ownerName}'s steps count is {stepCount}");
        }
    }

     internal class FlightReservation{
        static void Main(string[] args){
            Smartwatch S = new Smartwatch("anun");
            S.AddSteps(3);
            S.ShowSteps();

        }
     }
}

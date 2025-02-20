namespace FitnesTracker
{
    public class WorkOutSession{
        public string exerciseType;
        public int durationInMinutes;

        public WorkOutSession(string e, int s){
            exerciseType = e;
            durationInMinutes = s;
        }
        public void ShowWorkoutDetails(){
            Console.WriteLine($"The exercise type is {exerciseType}, duration in minutes is {durationInMinutes}");
        }   
    }

    internal class BookLibrary{
        static void Main(string[] args){
            WorkOutSession W1 = new WorkOutSession("mi ban", 30);
            WorkOutSession W2 = new WorkOutSession("Mi ban", 20);

            W1.ShowWorkoutDetails();
            W2.ShowWorkoutDetails();
        }
    }
}

namespace CarRentalSystem
{
    public class Car{
        public string model;
        public int year;
        public bool isRented;
    
        public Car (string m, int y){
            model = m;
            year = y;
            isRented = false;
        }

        public void RentCar(){
            if (!isRented){
                isRented = true;
            }
        }
        public void ReturnCar(){
            isRented = false;
        }
        public void Display(){
            if (!isRented){
                Console.WriteLine($"{model} is rented");
            } else {
                Console.WriteLine($"{model} is not rented");
            }
        }

    }

    internal class BookLibrary{
        static void Main(string[] args){
            Car[] C = new Car[5];

            for (int i = 0; i < C.Length; i++){
                string model = Console.ReadLine() ?? "";
                int year = int.Parse(Console.ReadLine() ?? "");

                C[i] = new Car(model, year);
            }
            C[2].RentCar();
            C[4].RentCar();

            for (int i = 0; i < C.Length; i++){
                C[i].Display();
            }
        }
    }

}
using System.Runtime.CompilerServices;

namespace TicketBooking
{
    public class MovieTicket{
        public string movieName;
        public int seatNumber;
        public bool isBooked;

        public MovieTicket (string mn, int sn){
            movieName = mn;
            seatNumber = sn;
            isBooked = false;
        }
        public void BookTicket(){
            if (!isBooked){
                isBooked = true;
            }
        }
        public void Booked(){
            if (!isBooked){
                Console.WriteLine($"{seatNumber}This seat is available");
            }
        }
    }

    internal class BookLibrary{
        static void Main(string[] args){
            MovieTicket[] M = new MovieTicket[5];

            for (int i = 0; i < M.Length; i++){
                string movieName = Console.ReadLine() ?? "";
                int seatNumber = int.Parse(Console.ReadLine() ?? "");
                M[i] = new MovieTicket(movieName, seatNumber);
            }
            M[0].BookTicket();
            M[3].BookTicket();
            for (int i = 0; i < M.Length; i++){
                M[i].Booked();
            }

        }
    }
}

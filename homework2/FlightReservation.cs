namespace FlightReservation
{
    public class FlightTicket{
        public string passengerName;
        public int flightNumber;
        public int seatNumber;
        
        public FlightTicket(string name, int fNumber, int sNumber){
            passengerName = name;
            flightNumber = fNumber;
            seatNumber = sNumber;
        }
    }

    internal class FlightReservation{
        static void Main(string[] args){
            FlightTicket flight = new FlightTicket("anun", 5, 1);
            Console.WriteLine(flight.passengerName);
            Console.WriteLine(flight.flightNumber);
            Console.WriteLine(flight.seatNumber);
        }
    }

}

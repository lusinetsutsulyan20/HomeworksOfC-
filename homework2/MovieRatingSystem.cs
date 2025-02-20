using System;
namespace FileDownload
{
    public class Movie{
       private int _rating;
       
       public int Rating {
           get {
                Console.WriteLine("Invalid value");  
                return _rating;
           }
            set {
                if ((value >= 1) && (value <= 5)){
                    _rating = value;
                }  
            }
       }
    }
    internal class BookLibrary{
        static void Main(string[] args){
            Movie M = new Movie();
            M.Rating = 9;
            M.Rating = 3;
            Console.WriteLine(M.Rating);
        }
    }
}

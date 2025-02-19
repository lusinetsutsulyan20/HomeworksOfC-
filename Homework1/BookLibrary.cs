namespace task2
{
public class Book{
    public string title;
    public string author;
    public bool isAvailable;
    public Book (string title, string author){
        this.title = title;
        this.author = author;
        isAvailable = false;
    }
    public void BorrowBook(){
        isAvailable = false;
    }
    public void ReturnBook(){
        isAvailable = true;
    }
}
    internal class BookLibrary{
        static void Main(string[] args)
        {
            Book[] B = new Book[3];
            for (int i = 0; i < B.Length; i++){
                string title = Console.ReadLine() ?? "";
                string author = Console.ReadLine() ?? "";
                B[i] = new Book (title, author);
            }
            for (int i = 0; i < B.Length; i++){
                if (!(B[i].isAvailable)){
                    Console.WriteLine ("This book is borrowed");
                } else {
                     Console.WriteLine ("This book is returned");
                }
            }
        }
    }
}
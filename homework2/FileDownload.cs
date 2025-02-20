using System;
namespace FileDownload
{
    public class FileDownload{
        public FileDownload (){
            Console.WriteLine("Download started");
        }
        ~FileDownload(){
            Console.WriteLine("Download completed");
        }
    }

    internal class BookLibrary{
        static void Main(string[] args){
            FileDownload F = new FileDownload();
            
        }
    }
}

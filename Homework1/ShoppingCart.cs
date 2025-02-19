namespace task2
{
    public class Product {
        public string? name;
        public int price;
        public int quantity;
        public Product (string n, int p, int q){
            name = n;
            price = p;
            quantity = q;
        }
        public float TotalPrice(){
            if (quantity >= 5){
                float res = (float) price * quantity * 90 / 100;
                return res;
            }
            return price * quantity;
        }
    internal class BookLibrary{
        static void Main(string[] args){
                Product[] P = new Product[3];
                for (int i = 0; i < P.Length; i++){
                    string name = Console.ReadLine() ?? "";
                    int price = int.Parse(Console.ReadLine() ?? "");
                    int count = int.Parse(Console.ReadLine() ?? "");
                    P[i] = new Product(name, price, count);
                }
                for (int i = 0; i < P.Length; i++){
                    Console.WriteLine(P[i].TotalPrice());
                }
        }
    }
    }
}
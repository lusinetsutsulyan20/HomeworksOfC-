namespace ProductSystem
{
    public class Product{
        public string name;
        public int price;
        public int stockQuantity;

        public Product (string name, int price, int stockQuantity){
            this.name = name;
            this.price = price;
            this.stockQuantity = stockQuantity;
        }
    }
    internal class ProductSystem{
        static void Main(string[] args){
            Product P1 = new Product("anun", 500, 2);
            Console.WriteLine(P1.name);
            Console.WriteLine(P1.price);
            Console.WriteLine(P1.stockQuantity);
        }
     }
}

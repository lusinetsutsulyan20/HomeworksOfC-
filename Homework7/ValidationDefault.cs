using System;
class Program {
    public class Product {
        private double _price;
        public double Price {
            get{
                return _price;
            }
            private set{
                if (value < 0){
                    _price = 0;
                } else {
                     _price = value;
                }
            }
        }
        
        private int _stock;
        public int Stock {
            get {
                return _stock;
            }
            set {
                if (value < 0){
                    _stock = 10;
                } else {
                     _stock = value;
                }
            }
        }
        
        public Product (double p, int s){
            Price = p;
            Stock = s;
        }
        
        public void ProductInfo(){
            Console.WriteLine("The price of product is " + _price + ", stock is " + _stock);
        }
        
    }
    static void Main() {
        Product P = new Product(99, 6);
        P.ProductInfo();
        
        Product P1 = new Product(-9, -6);
        P1.ProductInfo();
    }
}






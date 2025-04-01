using System;
public class Program {
    public abstract class Shape
    {
        protected string Name;
        protected int Height;
        protected int Weight;
        
        public abstract int Surface ();
        public abstract void Draw ();
        
        public void Print()
        {
            Console.WriteLine($"{this.Name}, S = {this.Surface()}");
            Draw();
        }
        public Shape (int height, int weight)
        {
            Height = height;
            Weight = weight;
        }
    }
    
    public class Square : Shape
    {
        public Square (int height) : base (height, height)
        {
            Name = "Square";
        }
        
        public override int Surface()
        {
            return Height * Height;
        }
        public override void Draw()
        {
            for (int i = 0; i < Height; ++i){
                for (int j = 0; j < Height; ++j){
                    Console.Write ("+");
                }
                Console.WriteLine();
            }
        }
    }
    
    public class Rectangle : Shape
    {
        public Rectangle (int height, int weight) : base (height, weight)
        {
            Name = "Rectangle";
        }
        public override int Surface()
        {
            return Height * Weight;
        }
        public override void Draw()
        {
            for (int i = 0; i < Height; ++i){
                for (int j = 0; j < Weight; ++j){
                    Console.Write ("+");
                }
                Console.WriteLine();
            }
        }
    }
    
    
    static void Main() {
        Shape[] shapes = new Shape[2];
        shapes[0] = new Square(4);
        shapes[1] = new Rectangle(4,6);
        
        foreach(Shape s in shapes){
            s.Print();
        }
    }
}

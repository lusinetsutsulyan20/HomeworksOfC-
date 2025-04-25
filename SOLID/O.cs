// public class Shape
// {
//     public string Type { get; set; }
// }
// public class AreaCalculator
// {
//     public double CalculateArea(Shape shape)
//     {
//         if (shape.Type == "Circle")
//             return 3.14 * 5 * 5; // Hardcoded radius
//         else if (shape.Type == "Square")
//             return 5 * 5; // Hardcoded side
//         else
//             throw new Exception("Shape not supported");
//     }
// }

// Այստեղ խաղտվում է open/closed սկզբունքը, որովհետև, եթե ցանկանանք որևէ պատկեր ավելացնել,
// ապա ստիպված ենք if ավելացնել, պետք է ավելացնել ինտերֆեյս։


public interface IShape 
{
    double AreaCalculator();
}
public class Circle : IShape
{
    public double AreaCalculator()
    {
        return 3.14 * 5 * 5; // Hardcoded radius
    }
}
public class Square : IShape
{
    public double AreaCalculator()
    {
        return 5 * 5; // Hardcoded side 
    }   
}

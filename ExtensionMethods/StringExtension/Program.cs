using MyExtensionsNamespace;
namespace MyProg
{
public class Program
{
    public static void Main()
    {
        string text = "Hello World, Welcome to ChatGPT";

        // Test MySplit method
        Console.WriteLine("Test MySplit:");
        var splitResult = text.MySplit(' ');
        foreach (var part in splitResult)
        {
            Console.WriteLine(part); // Should split by space
        }

        // Test MyIndexOf method
        Console.WriteLine("\nTest MyIndexOf:");
        int index = text.MyIndexOf('W');
        Console.WriteLine(index); // Should print the index of 'W' (6)

        // Test MyContains method
        Console.WriteLine("\nTest MyContains:");
        bool contains = text.MyContains("World");
        Console.WriteLine(contains); // Should print true

        // Test MySubstring method
        Console.WriteLine("\nTest MySubstring:");
        string substring = text.MySubstring(6, 5);
        Console.WriteLine(substring); // Should print "World"
    }
}
}

using MyListExtensionNamespace;
namespace MYProg
{
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        Console.WriteLine("Original list:");
        PrintList(numbers);

        // Test MyShuffle
        numbers.MyShuffle();
        Console.WriteLine("\nAfter Shuffle:");
        PrintList(numbers);

        // Test MyReverse
        numbers.MyReverse();
        Console.WriteLine("\nAfter Reverse:");
        PrintList(numbers);

        // Test Slice
        var sliced = numbers.Slice(2, 4); // Slice from index 2, 4 elements
        Console.WriteLine("\nSliced list (start=2, length=4):");
        PrintList(sliced);

        // Test At
        Console.WriteLine("\nMyAt(0): " + numbers.MyAt(0)); // First element
        Console.WriteLine("MyAt(2): " + numbers.MyAt(2)); // 3rd element
        Console.WriteLine("MyAt(-1): " + numbers.MyAt(-1)); // Last element
        Console.WriteLine("MyAt(-3): " + numbers.MyAt(-3)); // 3rd from end
    }

    static void PrintList<T>(List<T> list)
    {
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
}

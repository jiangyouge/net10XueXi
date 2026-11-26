T Max<T>(T a, T b) where T : IComparable<T>
{
    return a.CompareTo(b) > 0 ? a : b;
}

Console.WriteLine("比大小：");
Console.WriteLine(Max(3, 5)); // Output: 5
Console.WriteLine(Max(1.5, 2.5)); // Output: 2.5
Console.WriteLine(Max("apple", "banana")); // Output: banana

void PrintAll<T>(IEnumerable<T> items)
{
    Console.WriteLine(string.Join(", ", items));
}

PrintAll(new List<int> { 1, 2, 3 }); // Output: 1, 2, 3
PrintAll(new List<string> { "apple", "banana" }); // Output: apple, banana

var intBox = new Box<int>(42);
var textBox = new Box<string>("Hello, Generics!");
Console.WriteLine(intBox); // Output: Box containing: 42
Console.WriteLine(textBox); // Output: Box containing: Hello, Generics!
Console.WriteLine(intBox.Value + 8); // Output: 50

//动手任务
Console.WriteLine("动手任务：");
T FirstOr<T>(List<T> items, T fallback)
{
    if (items.Count > 0)
    {
        return items[0];
    }
    else
    {
        return fallback;
    }
}
Console.WriteLine(FirstOr(new List<int> { 1, 2, 3 }, -1)); // Output: 1
Console.WriteLine(FirstOr(new List<string>(), "default")); // Output: default
var intBox2 = new Box<List<string>>(["apple", "banana"]);
Console.WriteLine(string.Join(", ", intBox2.Value)); // Output: apple, banana
Console.WriteLine(intBox2.Value.Count); // Output: 2


public class Box<T>
{
    public T Value { get; set; }
    public Box(T value)
    {
        Value = value;
    }
    public override string ToString()
    {
        return $"Box containing: {Value}";
    }
}
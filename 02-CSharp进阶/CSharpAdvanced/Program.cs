List<int> numbers = new List<int> { 5, 2, 8, 1, 9, 4 };
numbers.Sort((a, b) => a - b);
Console.WriteLine("Sorted numbers: " + string.Join(", ", numbers));

var evens = numbers.FindAll(n => n % 2 == 0);
Console.WriteLine("Even numbers: " + string.Join(", ", evens));

int threshold = 4;
var big = numbers.FindAll(n => n > threshold);
Console.WriteLine($"Numbers greater than {threshold}: " + string.Join(", ", big));

Func<int, int> square = x => x * x;
Console.WriteLine(square(6));

Func<int, int, int> max = (a, b) =>
{
    int result = a > b ? a : b;
    return result;
};
Console.WriteLine(max(3, 7));

var forActions = new List<Action>();
for (int i = 0; i < 3; i++)
{
    forActions.Add(() => Console.WriteLine($"forActions Action {i} executed."));
}
foreach (var action in forActions) action();

var foreachActions = new List<Action>();
foreach (int n in new[] {0, 1, 2})
{
    foreachActions.Add(() => Console.WriteLine($"foreachActions Action {n} executed."));
}
foreach (var action in foreachActions) action();

Console.WriteLine("动手任务：");
List<string> strs = new List<string> { "apple", "kiwi", "banana", "fig" };
strs.Sort((a, b) => a.Length - b.Length);
Console.WriteLine("Strings: " + string.Join(", ", strs));

Func<int, bool> isRuNian = year => (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
Console.WriteLine("Is 2024 a leap year? " + isRuNian(2024));
Console.WriteLine("Is 1900 a leap year? " + isRuNian(1900));
Console.WriteLine("Is 2000 a leap year? " + isRuNian(2000));

var copyActions = new List<Action>();
for (int i = 0; i < 3; i++)
{
    int copy = i;
    copyActions.Add(() => Console.WriteLine($"copyActions Action of copy {copy} executed."));
}
foreach (var action in copyActions) action();
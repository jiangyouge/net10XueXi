MathOp add = (x, y) => x + y;
MathOp multiply = (x, y) => x * y;
Console.WriteLine($"Add: {add(5, 10)}"); // Output: Add: 15
Console.WriteLine($"Multiply: {multiply(5, 10)}"); // Output: Multiply: 50

Action<string> log = message => Console.WriteLine($"[LOG] {message}");
log("Application started."); // Output: [LOG] Application started.

Func<int, int, int> sub = (x, y) => x - y;
Console.WriteLine($"Subtract: {sub(10, 5)}"); // Output: Subtract: 5

Predicate<int> isEven = number => number % 2 == 0;
Console.WriteLine($"Is 4 even? {isEven(4)}"); // Output: Is 4 even? True

//多播：一个委托变量可以绑定多个方法，按+=的顺序执行
Action<string> pipeline = log;
pipeline += message => Console.WriteLine($"[FILE] {message}");
pipeline("Save Successful.");

var counter = new Counter();
counter.Reached += count => Console.WriteLine($"Count reached: {count}");
counter.Finished += () => Console.WriteLine("数完了");
for (int i = 0; i < 10; i++)
{
    counter.Add();
}

Console.WriteLine("动手任务：");
Notify notify = message => Console.WriteLine($"[1] {message}");
notify += message => Console.WriteLine($"[2] {message}");
notify("你好");

Func<decimal, decimal> discount = price => price * 0.8m;
Console.WriteLine(discount(100m));   // 80.0

public delegate int MathOp(int a, int b);
public delegate void Notify(string message);

public class Counter
{
    public event Action<int>? Reached;
    public event Action? Finished;

    private int _count;
    public void Add()
    {
        _count++;
        if (_count % 5 == 0)
        {
            Reached?.Invoke(_count);
        }
        if (_count == 10)
        {
            Finished?.Invoke();
        }
    }
    
}
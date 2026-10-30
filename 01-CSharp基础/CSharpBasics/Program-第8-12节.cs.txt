Console.WriteLine($"第八节 start");
var book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", 10.99m);
var book2 = new Book("To Kill a Mockingbird", "Harper Lee", 12.99m);

Console.WriteLine(book1.GetInfo());
Console.WriteLine(book2.GetInfo());

book1.Price = 9.99m; // Update the price of book1
Console.WriteLine($"Updated Price of : {book1.GetInfo()}");

//这里Book跟string用法类似
Book bookAlias = book1; // Create an alias for book1
bookAlias.Price = 8.99m; // Update the price using the alias
Console.WriteLine($"Updated bookAlias Price of : {bookAlias.GetInfo()}");

var book3 = new Book("UnAuthored Book");
Console.WriteLine(book3.GetInfo());

Console.WriteLine($"动手任务");
var personList = new List<Person>
{
    new Person("Alice", 30),
    new Person("Bob", 17),
    new Person("Charlie", 35)
};

foreach (var person in personList)
{
    Console.WriteLine(person.GetInfo());
}
int adultCount = personList.Count(p => p.IsAdult());
Console.WriteLine($"Number of adults: {adultCount}");
int adultCountF = 0;
foreach (var person in personList)
{
    if (person.IsAdult())
    {
        adultCountF++;
    }
}
Console.WriteLine($"成年人数：{adultCountF} / {personList.Count}");
Console.WriteLine($"IsCheaperThan: {book1.IsCheaperThan(book2)}");

Console.WriteLine($"第八节 end");

Console.WriteLine($"第九节 start");
var account = new Account();
account.Deposit(100); // 存100
Console.WriteLine($"Account Balance after deposit 100 : {account.Balance}");
bool ok = account.Withdraw(30); // 提款30
Console.WriteLine($"Withdraw 30 success: {ok}, New Balance: {account.Balance}");
bool fail = account.Withdraw(90); // 尝试提款90，余额不足
Console.WriteLine($"Withdraw 90 success: {fail}, New Balance: {account.Balance}");
account.Deposit(-50); // 尝试存负数/非法金额
Console.WriteLine($"Account Balance after deposit -50 : {account.Balance}");

Console.WriteLine($"动手任务");
Person ageM = new Person("老王", 200);
Console.WriteLine($"年龄限制：{ageM.GetInfo()}");
book1.Price = -5m;
Console.WriteLine($"价格限制 book1.Price -5m ：{book1.GetInfo()}");

Console.WriteLine($"第九节 end");

Console.WriteLine($"第十节 start");
var animals = new List<Animal>
{
    new Dog("Buddy"),
    new Cat("Whiskers"),
    new Dog("Max"),
    new Cat("Luna"),
    new Bird("Tweety")
};
foreach (var animal in animals)
{
    animal.speak();
}
Animal generic = new Animal("UnKnown");
generic.speak();

var vehicles = new List<Vehicle>
{
    new Car("Toyota"),
    new Bike("Yamaha")
};
foreach (var vehicle in vehicles)
{
    vehicle.Describe();
}

Console.WriteLine($"第十节 end");

Console.WriteLine($"第十一节 start");
var shapes = new List<IShape>
{
    new Circle(2),
    new Square(3),
    new Triangle(3, 4)
};
foreach (IShape shape in shapes)
{
    Console.WriteLine($"Shape: {shape.Name}, Area: {shape.Area():F2}");
}
var printables = new List<IPrintable>
{
    new Circle(5),
    new Square(4)
};
foreach (IPrintable printable in printables)
{
    printable.Print();
}
Console.WriteLine($"第十一节 end");

Console.WriteLine($"第十二节 start");
try
{
    int number = int.Parse("NotANumber");
    Console.WriteLine($"Parsed number: {number}");
}
catch (FormatException)
{
    Console.WriteLine("FormatException: Failed to parse the number.");
}
catch (Exception ex) // Exception 是所有异常的基类
{
    Console.WriteLine($"Exception: {ex.Message}");
}
finally
{
    Console.WriteLine("Finally block executed.");
}
try
{
    int number = int.Parse("123");
    Console.WriteLine($"Parsed number: {number}");
}
catch (FormatException)
{
    Console.WriteLine("FormatException: Failed to parse the number.");
}
finally
{
    Console.WriteLine("Finally block executed after successful parse.");
}

try
{
    int zero = 0;
    int result = 10 / zero; // This will throw DivideByZeroException
    Console.WriteLine($"10 / zero = Result: {result}");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"DivideByZeroException: Cannot divide by zero. {ex.Message}");
}
try
{
    string input = Console.ReadLine() ?? "";
    var number = int.Parse(input);   // 输入 abc 会抛 FormatException
    Console.WriteLine($"转换成功：{number}");
}
catch (FormatException)
{
    Console.WriteLine("FormatException: Failed to parse the number.");
}
try
{
    string input = Console.ReadLine() ?? "";

    if (int.TryParse(input, out int number)) // TryParse 返回 bool； out int number 是“顺带把结果放进 number”
    {
        Console.WriteLine($"转换成功：{number}");
    }
    else
    {
        Console.WriteLine("不是数字，请重输");
    }
}
finally
{
    Console.WriteLine("Finally block executed for TryParse.");
}

bool TryDivide(int a, int b, out double result)
{
    if (b == 0)
    {
        result = 0; // 设置默认值
        return false; // 返回 false 表示失败
    }
    result = (double)a / b;
    return true; // 返回 true 表示成功

}
if (TryDivide(10, 2, out double r1))
{
    Console.WriteLine($"10 / 2 = {r1}");
}
else
{
    Console.WriteLine("r1 failed.");
}
if (TryDivide(10, 0, out double r2))
{
    Console.WriteLine($"10 / 0 = {r2}");
}
else
{
    Console.WriteLine("r2 failed.");
}
if (TryDivide(10, 4, out double r3))
{
    Console.WriteLine($"10 / 4 = {r3}");
}
else
{
    Console.WriteLine("r3 failed.");
}

Console.WriteLine($"第十二节 end");

public interface IShape
{
    string Name { get; } // 只要求能读，形状的名字不需要外部改
    double Area(); // 只要求能算
}
public interface IPrintable
{
    void Print();
}
public class Circle : IShape, IPrintable
{
    public string Name
    {
        get { return "Circle"; }
    }
    public double Radius { get; set; }
    public Circle(double radius)
    {
        Radius = radius;
    }
    public double Area()
    {
        return Math.PI * Radius * Radius;
    }
    public void Print()
    {
        Console.WriteLine($"Circle with radius: {Radius}, Area: {Area():F2}");
    }
}
public class Square : IShape, IPrintable
{
    public string Name
    {
        get { return "Square"; }
    }
    public double SideLength { get; set; }
    public Square(double sideLength)
    {
        SideLength = sideLength;
    }
    public double Area()
    {
        return SideLength * SideLength;
    }
    public void Print()
    {
        Console.WriteLine($"Square with side length: {SideLength}, Area: {Area():F2}");
    }
}
public class Triangle : IShape
{
    public string Name
    {
        get { return "Triangle"; }
    }
    public double BaseLength { get; set; }
    public double Height { get; set; }
    public Triangle(double baseLength, double height)
    {
        BaseLength = baseLength;
        Height = height;
    }
    public double Area()
    {
        return 0.5 * BaseLength * Height;
    }
}
public class Person
{
    public string Name { get; set; }
    //public int Age { get; set; }
    private int _age; // 私有字段，外部无法直接访问
    public int Age
    {
        get { return _age; } // 公开的获取器，允许外部读取年龄
        set
        {
            if (value < 0 || value > 150)
            {
                _age = 0; // 如果设置的年龄小于0或大于150，则将年龄设置为0
            }
            else
            {
                _age = value; // 否则，设置为指定的年龄
            }
        }
    }
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public string GetInfo()
    {
        return $"Name: {Name}, Age: {Age}";
    }
    public bool IsAdult()
    {
        return Age >= 18;
    }
}
public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    //public decimal Price { get; set; }
    private decimal _price; // 私有字段，外部无法直接访问
    public decimal Price
    {
        get { return _price; } // 公开的获取器，允许外部读取价格
        set
        {
            if (value < 0)
            {
                _price = 0; // 如果设置的价格小于0，则将价格设置为0
            }
            else
            {
                _price = value; // 否则，设置为指定的价格
            }
        }
    }
    public Book(string title, string author, decimal price)
    {
        Title = title;
        Author = author;
        Price = price;
    }
    public Book(string title)
    {
        Title = title;
        Author = "Unknown";
        Price = 0.0m;
    }
    public string GetInfo()
    {
        return $"Title: {Title}, Author: {Author}, Price: {Price:F2}";
    }
    public bool IsCheaperThan(Book other)
    {
        return Price < other.Price;
    }
}
public class Account
{
    private decimal _balance; // 私有，只有类内部可以访问
    public decimal Balance
    {
        get { return _balance; }
        //private set { _balance = value; } // 私有设置器，外部无法直接修改余额
    }
    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            return;
        }
        _balance += amount;
    }
    public bool Withdraw(decimal amount)
    {
        if (amount <= 0 || amount > _balance)
        {
            return false; // 提款失败
        }
        _balance -= amount;
        return true; // 提款成功
    }
}
public class Animal
{
    public string Name { get; }
    public int Age { get; set; }
    public Animal(string name)
    {
        Name = name;
    }
    public virtual void speak()
    {
        Console.WriteLine($"{Name} makes a sound.");
    }
}
public class Dog : Animal // 继承自Animal类
{
    public Dog(string name) : base(name) // 调用基类构造函数
    {
    }
    public override void speak() // 重写基类的speak方法
    {
        Console.WriteLine($"{Name} barks for Dog.");
    }
}
public class Cat : Animal // 继承自Animal类
{
    public Cat(string name) : base(name) // 调用基类构造函数
    {
    }
    public override void speak() // 重写基类的speak方法
    {
        Console.WriteLine($"{Name} meows for Cat.");
    }
}
public class Bird : Animal
{
    public Bird(string name) : base(name)
    {
    }
    public override void speak()
    {
        Console.WriteLine($"{Name} chirps for Bird.");
    }
}
public class Vehicle
{
    public string Name { get; set; }
    public Vehicle(string name)
    {
        Name = name;
    }
    public virtual void Describe()
    {
        Console.WriteLine($"{Name} is a vehicle.");
    }
}
public class Car : Vehicle
{
    public Car(string name) : base(name)
    {
    }
    public override void Describe()
    {
        base.Describe(); // 调用基类的Describe方法
        Console.WriteLine($"{Name} have 4 wheels.");
    }
}
public class Bike : Vehicle
{
    public Bike(string name) : base(name)
    {
    }
    public override void Describe()
    {
        base.Describe(); // 调用基类的Describe方法
        Console.WriteLine($"{Name} have 2 wheels.");
    }
}
// 第 4 周综合练习：猜数字（练习 A）/ 简单计算器（练习 B）
Console.WriteLine("第四周练习 start");
Console.WriteLine("===== 练习 A =====");
var random = new Random();
while (true)
{
    int targetNumber = random.Next(1, 101); // 生成 1 到 100 的随机数
    int guessCount = 0;
    while (true)
    {
        Console.WriteLine("请输入一个1~100数字:");
        string input = Console.ReadLine() ?? "";
        if (!int.TryParse(input, out int guess))
        {
            Console.WriteLine("请输入一个有效的数字。");
            continue;
        }
        else
        {
            if (guess < 1 || guess > 100)
            {
                Console.WriteLine("请输入 1 到 100 之间的数字。");
                continue;
            }
            guessCount++;
            if (guess == targetNumber)
            {
                Console.WriteLine("恭喜你猜对了！");
                Console.WriteLine($"你总共猜了 {guessCount} 次。");
                break;

            }
            else if (guess < targetNumber)
            {
                Console.WriteLine("猜小了，请再试一次。");
            }
            else
            {
                Console.WriteLine("猜大了，请再试一次。");
            }
        }
    }
    Console.WriteLine("是否继续游戏？(y/n)");
    if (Console.ReadLine()?.Trim()?.ToLower() != "y")
    {
        Console.WriteLine("游戏结束。");
        break;
    }
}

Console.WriteLine("===== 练习 B =====");
while (true)
{
    Console.Write("输入算式（如 3 + 5），输入 q 退出：");
    string line = Console.ReadLine() ?? "";
    if (line.Trim().ToLower() == "q")
    {
        break;
    }

    string[] parts = line.Split(' ');
    if (parts.Length != 3)
    {
        Console.WriteLine("格式不对，示例：3 + 5");
        continue;
    }

    if (!double.TryParse(parts[0], out double a) ||
        !double.TryParse(parts[2], out double b))
    {
        Console.WriteLine("数字解析失败");
        continue;
    }

    switch (parts[1])
    {
        case "+":
            Console.WriteLine($"{a} + {b} = {a + b}");
            break;
        case "-":
            Console.WriteLine($"{a} - {b} = {a - b}");
            break;
        case "*":
            Console.WriteLine($"{a} * {b} = {a * b}");
            break;
        case "/":
            if (b == 0)
            {
                Console.WriteLine("除数不能为 0");
            }
            else
            {
                Console.WriteLine($"{a} / {b} = {a / b}");
            }
            break;
        default:
            Console.WriteLine("只支持 + - * /");
            break;
    }
}

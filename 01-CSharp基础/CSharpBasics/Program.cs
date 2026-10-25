Console.WriteLine($"第一节 start");
int age = 28;  // 整数
double height = 1.75;   // 浮点数
string name = "小王吧"; // 字符串
bool isStuDent = true; // 布尔值
var city = "广东"; // 使用 var 关键字声明变量，类型由编译器推断

Console.WriteLine(name);
Console.WriteLine($"年龄: {age}, 身高: {height}, 是否是学生: {isStuDent}, 城市: {city}");

age = age + 1; // 修改变量的值
decimal price = 99.99m; // decimal 类型，适合表示货币
Console.WriteLine($"price: {price}");

double c = 0.1 + 0.2; // 浮点数运算可能会有精度问题

decimal d = 0.1m + 0.2m; // decimal 运算精度更高，适合货币计算
Console.WriteLine($"c: {c}, d: {d}");
Console.WriteLine($"第一节 end");

Console.WriteLine($"第二节 start");
int a = 7;
int b = 2;

Console.WriteLine($"a + b = {a + b}"); // 加法
Console.WriteLine($"a - b = {a - b}"); // 减法
Console.WriteLine($"a * b = {a * b}"); // 乘法
Console.WriteLine($"a / b = {a / b}"); // 除法
Console.WriteLine($"a % b = {a % b}"); // 取模/取余
Console.WriteLine($"a / (double)b = {a / (double)b}"); // 强制类型转换为 double 进行浮点数除法
Console.WriteLine($"(double)a / b = {(double)a / b}"); // 强制类型转换为 double 进行浮点数除法

bool isGreater = a > b; // 大于 true
bool both = isGreater && b > 1; // 逻辑与 true
Console.WriteLine($"isGreater: {isGreater}, both: {both}");

double x = 3.9;
int truncated = (int)x; // 强制转换，截断小数
int rounded = Convert.ToInt32(truncated); // 四舍六入五成双
Console.WriteLine($"truncated: {truncated}, rounded: {rounded}");

string s = "123";
int n = int.Parse(s); // 字符串 =》 整数
Console.WriteLine(n);

double weight = 85;   // 浮点数
double bmi = weight / (height * height);
Console.WriteLine($"bmi: {bmi:F1}");
Console.WriteLine($"第二节 end");

Console.WriteLine($"第三节 start");
//Console.WriteLine("请输入成绩：");
//string input = Console.ReadLine() ?? "";
//int score = int.Parse(input);

//if (score >= 90)
//{
//    Console.WriteLine("等级 A");
//}
//else if (score >= 80)
//{
//    Console.WriteLine("等级 B");
//}
//else if (score >= 60)
//{
//    Console.WriteLine("等级 C");
//}
//else
//{
//    Console.WriteLine("不及格");
//}

//string sInput = Console.ReadLine() ?? "";
//int sScore = int.Parse(sInput);
//switch(sScore % 2)
//{
//    case 0:
//        Console.WriteLine($"输入：{sInput}是偶数");
//        break;
//    default:
//        Console.WriteLine($"输入：{sInput}不是偶数");
//        break;
//}
Console.WriteLine($"第三节 end");

Console.WriteLine($"第四节 start");
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}

int sum = 0;
for (int i = 1; i <= 100; i++)
{
    sum += i;
}
Console.WriteLine($"for 1到100的和为: {sum}");

int sumWhile = 0;
int count = 1;
while (count <= 100)
{
    sumWhile += count;
    count++;
}
Console.WriteLine($"while 1到100的和为: {sumWhile}");

for (int i = 1; i <= 9; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write($"{j} * {i} = {i * j}\t"); // Console.Write 输出后不换行
    }
}

for (int i = 1; i <= 10; i++)
{
    if (i == 4) continue; // 跳过当前循环的剩余部分，继续下一次循环
    if (i == 7) break; // 终止整个循环
    Console.Write($"{i} ");
}

//动手任务
Console.WriteLine("动手任务"); // 
//1、把九九乘法表倒着打印。只改外层 for：从 9 开始、i >= 1、i--，内层不动。
for (int i = 9; i >= 1; i--)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write($"{i} * {j} = {i * j}\t"); // Console.Write 输出后不换行
    }
    Console.WriteLine(); // 换行
}
//2、求 1 到 100 的偶数和（提示：if (i % 2 == 0)），结果应该是 2550。
int sumO = 0;
for (int i = 1; i <= 100; i++)
{
    if (i % 2 == 0)
    {
        sumO += i;
    }
}
Console.WriteLine($"for 1到100的偶数和为: {sumO}");
//3、挑战：用嵌套循环打印 5 行直角三角形星星——第 1 行 1 个，第 5 行 5 个。提示：外层 i = 1..5，内层 j = 1..i，内层用 Console.Write("*")，内层结束后 Console.WriteLine()。
for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine(); // 换行
}
Console.WriteLine($"第四节 end");

Console.WriteLine($"第五节 start");

int totle = Add(3, 5);
PrintMenu("记事本");
double myBmi = CalcBmi(73.6, 1.65);


//方法定义
int Add (int x, int y)
{
    return x + y;
}
void PrintMenu (string title)
{
    Console.WriteLine($"====={title}=====");

}
double CalcBmi (double weightKg, double heightM)
{
    return weightKg / (heightM * heightM);
}

//练习
Console.WriteLine("请输入成绩：");
string input = Console.ReadLine() ?? "100";
int score = int.Parse(input);
Console.WriteLine($"成绩:{score} 等级为：{Grade(score)}");
Console.WriteLine($"Max 99 98:{Max(99, 98)}");
Console.WriteLine($"成绩是否偶數 :{IsEven(score)}");
string Grade(int score)
{
    if (score >= 90)
    {
        return "A";
    }
    else if (score >= 80)
    {
        return "B";
    }
    else if (score >= 60)
    {
        return "C";
    }
    else
    {
        return "不及格";
    }
}
int Max(int a, int b)
{
    if (a > b) return a; return b;
}
bool IsEven(int number)
{
    return number % 2 == 0;
}
Console.WriteLine($"第五节 end");

Console.WriteLine($"第六节 start");
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
int i = (int)x; // 强制转换，截断小数
int j = Convert.ToInt32(i); // 四舍六入五成双
Console.WriteLine($"i: {i}, j: {j}");

string s = "123";
int n = int.Parse(s); // 字符串 =》 整数
Console.WriteLine(n);

double weight = 85;   // 浮点数
double bmi = weight / (height * height);
Console.WriteLine($"bmi: {bmi:F1}");
Console.WriteLine($"第二节 end");

Console.WriteLine($"第三节 start");
Console.WriteLine("请输入成绩：");
string input = Console.ReadLine() ?? "";
int score = int.Parse(input);

if (score >= 90)
{
    Console.WriteLine("等级 A");
}
else if (score >= 80)
{
    Console.WriteLine("等级 B");
}
else if (score >= 60)
{
    Console.WriteLine("等级 C");
}
else
{
    Console.WriteLine("不及格");
}

string sInput = Console.ReadLine() ?? "";
int sScore = int.Parse(sInput);
switch(sScore % 2)
{
    case 0:
        Console.WriteLine($"输入：{sInput}是偶数");
        break;
    default:
        Console.WriteLine($"输入：{sInput}不是偶数");
        break;
}
Console.WriteLine($"第三节 end");







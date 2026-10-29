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
int rounded = Convert.ToInt32(x); // 四舍六入五成双
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
    Console.WriteLine(); // 换行
}

for (int i = 1; i <= 10; i++)
{
    if (i == 4) continue; // 跳过当前循环的剩余部分，继续下一次循环
    if (i == 7) break; // 终止整个循环
    Console.Write($"{i} ");
}
Console.WriteLine();

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

int total = Add(3, 5);
Console.WriteLine(total);   // 8
PrintMenu("记事本");
double myBmi = CalcBmi(73.6, 1.65);
Console.WriteLine($"BMI = {myBmi:F1}");   // 27.0


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
int[] scores = { 85, 92, 78, 90, 88 };
Console.WriteLine($"数组 scores 的长度为: {scores.Length}");
Console.WriteLine($"数组 scores 的第一个元素为: {scores[0]}");
Console.WriteLine($"数组 scores 的最后一个元素为: {scores[scores.Length - 1]}");

var names = new List<string> { "Alice", "Bob", "Charlie" };
names.Add("David");
names.Remove("Bob");
Console.WriteLine($"List names 的长度为: {names.Count}");
//foreach 和 for 的分工：挨个处理用 foreach；需要知道“第几个”或要按下标改元素用 for。
foreach(string friend in names)
{
    Console.WriteLine($"List names 中的元素: {friend}");
}

var prices = new Dictionary<string, int>
{
    ["Apple"] = 3,
    ["Banana"] = 2,
    ["Orange"] = 4
};
prices["Banana"] = 5; // 键存在 修改键为 "Banana" 的值
prices["Grapes"] = 6; // 键不存在 添加新的键值对
Console.WriteLine($"Dictionary prices 的长度为: {prices.Count}");
Console.WriteLine($"Dictionary prices 中的 Apple 的价格为: {prices["Apple"]}");
foreach (var kvp in prices)
{
    Console.WriteLine($"Dictionary prices 中的元素: {kvp.Key} - {kvp.Value}");
}
if (prices.ContainsKey("Orange"))
{
    Console.WriteLine($"Dictionary prices 中包含键 'Orange'");
}
else
{
    Console.WriteLine($"Dictionary prices 中不包含键 'Orange'");
}

//动手任务
Console.WriteLine($"任务1：");
var fruits = new List<string> {  };
fruits.Add("Apple");
fruits.Add("Banana");
fruits.Add("Orange");
fruits.Remove("Banana");
foreach (string fruit in fruits)
{
    Console.WriteLine($"List fruits 中的元素: {fruit}");
}
Console.WriteLine($"任务2：");
var courseScores = new Dictionary<string, int>
{
    ["Math"] = 95,
    ["English"] = 88,
    ["Science"] = 92
};
foreach (var kvp in courseScores)
{
    Console.WriteLine($"课程: {kvp.Key}；成绩：{kvp.Value}；");
}
if (courseScores.ContainsKey("History"))
{
    Console.WriteLine($"课程 History 的成绩为: {courseScores["History"]}");
}
else
{
    Console.WriteLine($"课程 History 不存在");
}
Console.WriteLine($"任务3：");
for(int i = 0; i < scores.Length; i++)
{
    Console.WriteLine($"第 {i + 1} 个成绩为: {scores[i]}");
}
Console.WriteLine($"第六节 end");

Console.WriteLine($"第七节 start");
string text = "     Hello, C# World  C# !      ";
Console.WriteLine($"{text.Trim()}");    // 去掉首尾空格 
Console.WriteLine($"{text.Trim().ToUpper()}"); // 去掉首尾空格再转为大写
Console.WriteLine($"{text.Trim().ToLower()}"); // 去掉首尾空格再转为小写
Console.WriteLine($"{text.Contains("C#")}"); // 判断是否包含子字符串
Console.WriteLine($"{text.Replace("C#", "JavaScript")}"); // 替换子字符串
Console.WriteLine($"{text.Length}"); //    长度

string sentence = "苹果 香蕉 普通";
string[] words = sentence.Split(' '); // 按空格分割字符串
Console.WriteLine($"分割后的单词数量: {words.Length}");
Console.WriteLine($"分割后的单词: {string.Join(", ", words)}"); // 使用 Join 方法将数组元素连接为字符串
Console.WriteLine($": {words[1]}"); // 访问分割后的单词数组中的第二个元素

string userName = "小明";
Console.WriteLine($"欢迎 {userName} 来到 C# 世界！今年是 {DateTime.Now.Year} 年"); // 字符串插值

//动手任务
Console.WriteLine($"任务1：");
//string str1 = "  C# is a powerful programming language  !";
//string[] str1s = str1.Split(' ');
//Console.WriteLine($"分割后的单词数量: {str1s.Length}");
Console.WriteLine("请输入：I love C# very much");
string englishLine = Console.ReadLine() ?? "";
string[] englishWords = englishLine.Split(' ');
Console.WriteLine($"分割后的单词数量: {englishWords.Length}");

Console.WriteLine("请输入：我今天很开心!");
string originalSentence = Console.ReadLine() ?? "";
Console.WriteLine($"原始字符串: {originalSentence}");
Console.WriteLine($"我换成你: {originalSentence.Replace("我", "你")}");

Console.WriteLine("请输入：小明");
string inputName = Console.ReadLine() ?? "";
Console.WriteLine($"欢迎 {inputName} 来到 C# 世界！（共{inputName.Length} 个字）");
Console.WriteLine($"第七节 end");


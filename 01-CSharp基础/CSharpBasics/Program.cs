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
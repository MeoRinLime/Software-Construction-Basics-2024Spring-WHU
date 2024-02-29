double a, b, result;
result = 0;
char c = ' ';
Console.WriteLine("请输入第一个运算数：");
a = double.Parse(Console.ReadLine());
Console.WriteLine("请输入运算符：");
c = char.Parse(Console.ReadLine());
Console.WriteLine("请输入第二个运算数：");
b = double.Parse(Console.ReadLine());
if (c == '+') result = a + b;
if (c == '-') result = a - b;
if (c == '*') result = a * b;
if (c == '/' && b == 0)
{
    Console.WriteLine("被除数不能为0");
    result = 0;
};
if (c == '/') result = a / b;
Console.WriteLine("运算结果是：" + result);
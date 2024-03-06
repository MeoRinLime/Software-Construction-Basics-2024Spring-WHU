
int number = 0;
Console.WriteLine("请输入一个整数");
string input = Console.ReadLine();
if (input == null)
{
    Console.WriteLine("输入错误：请输入一个整数");
}
else
{
    number = int.Parse(input);
}

int checkNum = 2;

while (number > 1)
{
    if (number % checkNum == 0)
    {
        Console.Write(checkNum + " ");
        number = number / checkNum;
    }
    else
    {
        checkNum++;
    }
}
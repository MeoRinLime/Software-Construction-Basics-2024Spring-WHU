using System.Numerics;

Console.WriteLine("数组的元素有多少个？");

int sizeOfArray = int.Parse(Console.ReadLine());

Console.WriteLine("请依次输入数组元素：");

int[] nums = new int[sizeOfArray];

for (int i = 0; i < sizeOfArray; i++)
{
    int temp = int.Parse(Console.ReadLine());
    nums[i] = temp;
}

int maxNum = nums[0], minNum = nums[0], aveNum = 0, Sum = 0;
for (int i = 0;i < sizeOfArray; i++)
{
    if (nums[i] > maxNum) maxNum = nums[i];
    if (nums[i] < minNum) minNum = nums[i];
    Sum += nums[i];
}
aveNum =  Sum / sizeOfArray;

Console.WriteLine("该数组的最大值是：" + maxNum);
Console.WriteLine("该数组的最小值是：" + minNum);
Console.WriteLine("该数组的平均值是：" + aveNum);
Console.WriteLine("该数组的总和是：" + Sum);
using System.Globalization;

int[] ints =  new int[99];
int temp = 2;
for (int i = 0; i < ints.Length; i++)
{
    ints[i] = temp;
    temp++;
}

int[] primeNumbers = {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };

for (int i = 0; i < ints.Length; i++)
{
    for (int j = 0; j < primeNumbers.Length; j++)
    {
        if (ints[i] > primeNumbers[j] && ints[i] % primeNumbers[j] == 0)
        {
            ints[i] = 1;
        }
    }
}

for (int i = 0;  i < ints.Length; i++)
{
    if (ints[i] != 1)
    {
        Console.Write(ints[i] + " ");
    }
}
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11   82 -> 10   9012 -> 12

Console.Clear();

int NumDivisionSum(int number)
{
    int value = number;
    int result = 0;
    int reminder = 0;
    while (value > 1)
    {
        reminder = value % 10;
        result = result + reminder;
        value = value / 10;
    } 
    return result;
}

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine() ?? "0");
int digitsum = NumDivisionSum(num);
Console.WriteLine($"{num} -> {digitsum}");

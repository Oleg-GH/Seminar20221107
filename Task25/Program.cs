// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)      2, 4 -> 16

Console.Clear();

int NumExp(int osnovanie, int pokazatel)
{
    int result = 1;
    for (int count = 1; count <= pokazatel; count++)
    {
        result = result * osnovanie;
    }
    return result;
}

Console.WriteLine("Введите основание и показатель степени: ");
int baze = int.Parse(Console.ReadLine() ?? "0");
int exp = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"{baze}, {exp} -> {NumExp(baze, exp)}");
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран
// (в примере показаны два разных массива, создаем именно для 8 элементов)  1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

Console.Clear();

void NewArray(int[]collection)
{
    int length = collection.Length;
    for(int index = 0; index < length; index++)
    {
        collection[index] = new Random().Next(0,100);
    }
}

void PrintArray (int[] col)
{
    int count = col.Length;
    for(int position = 0; position < count; position++)
    {
        Console.Write($"{col[position]}, ");           
    }
    Console.WriteLine();
}

Console.WriteLine("Зададим новый массив из 8 случайных элементов от 0 до 100: ");

int[] array = new int[8];
NewArray(array);
PrintArray(array);

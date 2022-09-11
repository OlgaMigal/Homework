// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void Task50()
{
    int[,] array = new int[10, 10];
    FillArray(array);
    PrintArray(array);
    Console.WriteLine();
    ReturnElementByPosition(array);
}

void FillArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            collection[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            Console.Write($"{collection[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void ReturnElementByPosition(int[,] collection)
{
    Console.Write("Введите позицию элемента по строке: ");
    int m = int.Parse(Console.ReadLine());
    Console.Write("Введите позицию элемента по столбцу: ");
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine();

    if (m >= collection.GetLength(0) || n >= collection.GetLength(1))
    {
        Console.WriteLine("Такого элемента в массиве нет");
    }
    else Console.WriteLine($"Элемент ({m}, {n}) = {collection[m, n]}");
}

Task50();
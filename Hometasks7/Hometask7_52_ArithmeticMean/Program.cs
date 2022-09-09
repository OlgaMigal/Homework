// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Не стала заморачиваться поправкой счётчика столбца с 1, 
// чтобы никого не путать и самой не путаться)

void Task52()
{
    int[,] array = new int[3, 4];
    FillArray(array);
    PrintArray(array);
    Console.WriteLine();
    ArithmeticMeanOfColumn(array);
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

void ArithmeticMeanOfColumn(int[,] collection)
{
    for (int j = 0; j < collection.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < collection.GetLength(0); i++)
        {
            sum = sum + collection[i, j];
        }
        double arithmeticMean = Math.Round(Convert.ToDouble(sum / collection.GetLength(0)), 1);
        Console.WriteLine($"Среднее арифметическое по столбцу {j} = {arithmeticMean}");
    }
}

Task52();
// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void Task47()
{
    Console.Write("Введите количество строк m: ");
    int m = int.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов n: ");
    int n = int.Parse(Console.ReadLine());

    double[,] array = new double[m, n];
    FillArray(array);
    Console.WriteLine();
    PrintArray(array);
    Console.WriteLine();
}


void FillArray(double[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            collection[i, j] = Math.Round((new Random().Next(1, 100) + new Random().NextDouble()), 1);
        }
    }
}

void PrintArray(double[,] collection)
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

Task47();
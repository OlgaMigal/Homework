// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int lessNum = 1;
int higherNum = 9;

void Task54()
{
    int[,] matrix = new int[5, 10];

    FillArray(matrix);
    Console.WriteLine();
    PrintArray(matrix);
    Console.WriteLine();
    FindMinSumRow(matrix);
    Console.WriteLine();
}

// Поиск строки с меньшей суммой:
void FindMinSumRow(int[,] matr)
{
    int[] sum = new int[matr.GetLength(1)];
    int min = Int32.MaxValue;
    int minSumRow = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        sum[i] = 0;

        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum[i] += matr[i, j];
        }
        Console.WriteLine($"Сумма {i + 1} строки = {sum[i]};");
        if (sum[i] < min)
        {
            min = sum[i];
            minSumRow = i + 1;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Меньшая сумма по строке {minSumRow}");
}



// Печать:
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
            //          Console.Write($"{matr[i, j]}  \t");
        }
        Console.WriteLine();
    }
}

// Заполнение:
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(lessNum, higherNum + 1);
        }
    }
}

Task54();
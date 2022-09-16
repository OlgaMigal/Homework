// Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int lessNum = 1;
int higherNum = 9;

void Task54()
{
    int[,] matrix = new int[5, 5];

    FillArray(matrix);
    Console.WriteLine();
    PrintArray(matrix);
    Console.WriteLine();
    Order2DRows(matrix);
    PrintArray(matrix);
    Console.WriteLine();
}

// Сортировка по строкам:
int[,] Order2DRows(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1) - 1; j++)
        {
            int minPosition = j;
            for (int k = j + 1; k < matr.GetLength(1); k++)
            {
                if (matr[i, k] > matr[i, minPosition])
                {
                    minPosition = k;
                }
            }
            int temp = matr[i, j];
            matr[i, j] = matr[i, minPosition];
            matr[i, minPosition] = temp;
        }
    }
    return matr;
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
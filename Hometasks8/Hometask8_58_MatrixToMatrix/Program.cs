// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4    2*3+4*3  2*4+4*3
// 3 2 | 3 3    3*3+2*3  3*4+2*3
// Результирующая матрица будет:
// 18 20
// 15 18

int lessNum = 1;
int higherNum = 4;
int oneSize = 2;
int otherSize = 2;


void Task58()
{
    int[,] matrix = new int[oneSize, otherSize];
    int[,] array = new int[otherSize, oneSize];
    int[,] collection = new int[oneSize, otherSize];

    FillArray(matrix);
    FillArray(array);
    Console.WriteLine();
    PrintArray(matrix);
    Console.WriteLine();
    PrintArray(array);
    Console.WriteLine();
    MatrixToMatrix(matrix, array, collection);
    PrintArray(collection);
    Console.WriteLine();
}

// Умножение матриц:
int[,] MatrixToMatrix(int[,] matr, int[,] arr, int[,] col)
{
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    for (int k = 0; k<matr.GetLength(0); k++)
                    {
                    col[i, j] += matr[i, k] * arr[k, i];
                    }
                }
            }
    return col;
}



// Печать:
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}  \t");
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

Task58();
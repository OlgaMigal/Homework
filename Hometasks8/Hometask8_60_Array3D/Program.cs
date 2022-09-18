// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


void Task60()
{
    int[,,] array = new int[5, 3, 4];
    int[] numsUnic = UnicNumbers(array);
    //Console.WriteLine($"Нужно {numsUnic.Length} уникальных чисел"); // для проверки
    FillArray(array, numsUnic);
    PrintArray(array);
}

// Уникальные двузначные значения:
int[] UnicNumbers(int[,,] matr)
{
    int[] unicNums = new int[matr.GetLength(0) * matr.GetLength(1) * matr.GetLength(2)];
    for (int i = 0; i < unicNums.GetLength(0); i++)
    {
        unicNums[i] = new Random().Next(10, 100);
        int number = unicNums[i];
        if (i > 0)
        {
            for (int j = 0; j < i; j++)
            {
                while (unicNums[i] == unicNums[j])
                {
                    unicNums[i] = new Random().Next(10, 100);
                    j = 0;
                    number = unicNums[i];
                }
                number = unicNums[i];
            }
        }
        //Console.Write($"{unicNums[i]} "); // для проверки
    }
    return unicNums;
}

void FillArray(int[,,] matr, int[] unicNums)
{
    int z = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                matr[i, j, k] = unicNums[z];
                z += 1;
            }
        }
    }
}

// Печать:
void PrintArray(int[,,] matr)
{
    Console.WriteLine();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i, j, k]} ({i},{j},{k})\t");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}

Task60();
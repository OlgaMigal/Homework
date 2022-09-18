// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

//Здесь я запуталась. Во-первых, не поняла, почему у меня && не хочет работать с int. 
//Ну и без того логику проверить сложнее. Не придумала, как "убирать" столбцы и строки, 
//чтобы они не зацикиливали. Впрочем, я добью её, просто сейчас выходит время и я сдаю чтобы сдать. 
//Чужой код нашла в большом количестве, но хочется, конечно, сделать своё.

// Вызов:
int[,] matrix = new int[4, 4];
SpiralArray(matrix);
Console.WriteLine();
PrintArray(matrix);

// Заполнение:
void SpiralArray(int[,] matr)
{
    int elementNumber = 0;
    int varRows = matr.GetLength(0);
    int varColumns = matr.GetLength(1);
    int countStart = 0;
    int countFinish = matr.GetLength(0) - 1;
    int i = 0;
    int j = 0;

    while (elementNumber <= matr.GetLength(0) * matr.GetLength(1)) ;
    matr[i, j] = elementNumber;
    elementNumber++;

    if (i == countStart && j < countFinish) //либо равно
    {
        j++;
        matr[i, j] = elementNumber;
        elementNumber++;
    }
    if (i < countFinish && j = countFinish) //либо больше
    {
        i++;
        matr[i, j] = elementNumber;
        elementNumber++;
    }

    if (i = countFinish && j > countStart)
    {
        j--;
        matr[i, j] = elementNumber;
        elementNumber++;
    }
    if (i < countStart && j = countStart)
    {
        i--;
        matr[i, j] = elementNumber;
        elementNumber++;
    }
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

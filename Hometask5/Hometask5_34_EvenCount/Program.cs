// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Стараюсь привести всё в систему, поэтому разобрала семинарский вариант 
// кода Дмитрия, и собираюсь тренироваться писать так же - больно красивый у него код. 
//Понятно, что "задачную" часть пишу сама, да и остальное доработала на свой вкус.
// Круто - собрать нужные "части" в отдельном методе. Как конструктор.

void Task34()
{
    int size = new Random().Next(10, 11);
    int[] array = new int[size];
    FillArray(array, 100, 999);
    PrintArray(array);
    EvenCount(array);
}

void EvenCount (int[] array)
{
int count = 0;
     foreach (int value in array)
{
    count += value % 2 == 0 ? 1 : 0;
}
Console.WriteLine($"Количество чётных чисел в массиве: {count}" );
}

void FillArray(int[] array, int minNumber = 100, int maxNumber = 999)
{
    maxNumber++;
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minNumber, maxNumber);
    }
}

void PrintArray(int[] array)
{
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("");
}

Task34();
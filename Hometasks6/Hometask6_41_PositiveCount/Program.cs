// Задача 41. Пользователь вводит с клавиатуры М чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.


//void Task41()
//{
    Console.Write("Количество элементов будет равно ");
    int m = int.Parse(Console.ReadLine());
    int[] array = new int [m];
    FillArray(array, m);
    PrintArray(array);
    PositiveCount(array);
//}



//Метод ввода:
void FillArray(int[] array, int m)
{
    Console.WriteLine($"Введите {m} чисел");
    for (int i = 0; i < m; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
    }
}
// Метод печати:
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

// Счётчик положительных.
void PositiveCount(int[] array)
{
    int positiveCount = 0;
    foreach (int value in array)
    {
        positiveCount += value > 0 ? 1: 0;
    }
    Console.WriteLine();
    Console.WriteLine($"Введено {positiveCount} чисел больше 0");
}

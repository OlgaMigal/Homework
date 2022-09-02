// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void Task34()
{
    int size = new Random().Next(10, 11);
    int[] array = new int[size];
    FillArray(array, 1, 10);
    PrintArray(array);
    OddPositionSum(array);
}

void OddPositionSum(int[] array)
{
    int oddPosSum = 0;
    for (int i = 1; i < array.Length; i += 2)
{
    oddPosSum += array[i];
}
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях в массиве, = {oddPosSum}");
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
// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

//Вставила один костылик - лишний Math.Round на разнице min и max. 
//И рада бы без него, но почему-то раз из 10 обязательно не округляется, 
//и именно разница, а сам массив как положено. Не поняла, с чем связано.

void Task38()
{
    int size = new Random().Next(10, 11);
    double[] array = new double[size];
    FillArrayDouble(array, 1, 100);
    PrintArray(array);
    MaxMinDifference(array);
}

void MaxMinDifference(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    double diff = Math.Round(max - min, 3);
    Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {diff}");
}
// Заполнение массива вещественными числами (округлю, чтобы проще проверять):

void FillArrayDouble(double[] array, double minNumber = 100.0, double maxNumber = 999.0)
{
    maxNumber++;
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round((random.Next(Convert.ToInt32(minNumber), 
        Convert.ToInt32(maxNumber-1)) + random.NextDouble()), 3);
    }
}

void PrintArray(double[] array)
{
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "  ");
    }
    Console.WriteLine("");
}

Task38();
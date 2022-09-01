// Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

//создадим метод заполнения массива:

void FillArray(int[] collection)
{
    int length = collection.Length;
    for (int i = 0; i < length; i++)
    {
        //Сделала 2 варианта.

        // Console.Write($"Введите {i} элемент массива ");
        // collection[i] = int.Parse(Console.ReadLine());

        collection[i] = new Random().Next(1, 10);
    }
}

//теперь метод печати массива:

void PrintArray(int[] col)
{
    int count = col.Length;
    for (int pos = 0; pos < count; pos++)
    {
        Console.Write(col[pos] + " ");
    }
}

//Запускаем метод заполнения для массива array, затем метод печати.
// И перейдём на новую строку для красоты.

//Альтернатива для ввода длины массива (но задача этого не подразумевает):
// Console.Write("Введите длину массива: ");
// int size = int.Parse(Console.ReadLine());
// int[] array = new int[size];

int[] array = new int[8];
FillArray(array);
PrintArray(array);
Console.WriteLine();
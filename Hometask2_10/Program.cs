// Напишите программу, которая принимает 
// на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// не стала мучиться с проверкой корректности ввода
int Second(int num)
{
    int number = num % 100 / 10;
    return number;
}

Console.Write("Введите трёхзначное число: ");

//int number = Second(int.Parse(Console.ReadLine())); - короче, 
//но непригодно для проверки трёхзначности

//для проверки трёхзначности числа ввела дополнительную переменную inter:
int inter = int.Parse(Console.ReadLine());
int number = Second(inter);

if (inter / 100 > 0 & inter / 100 < 10)
{
    Console.WriteLine("Средняя цифра = " + number);
}
else Console.WriteLine("Ошибка ввода, перезапустите программу");
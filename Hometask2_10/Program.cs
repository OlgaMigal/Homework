// Напишите программу, которая принимает 
// на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
int Second(int num)
{
    int number = num % 100 / 10;
    return number;
}
Console.Write("Введите трёхзначное число: ");
// int inter = int.Parse(Console.ReadLine());
// int number = Second(inter);

int number = Second(int.Parse(Console.ReadLine()));
Console.WriteLine("Средняя цифра = " + number);

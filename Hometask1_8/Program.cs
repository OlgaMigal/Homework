// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N (включительно).
// Сделала только на положительные числа. На отрицательные
// тоже можно, но не стала.
Console.Write("Введите неотрицательное число: ");
int number = int.Parse(Console.ReadLine());
int count = 2;
if (number>1)
{
while (count<=number)
{
Console.Write($"{count} ");
count = count+2;
}
}
else Console.Write("Введённое число слишком мало");
Console.WriteLine();
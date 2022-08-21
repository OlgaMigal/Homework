// Задача 2: Напишите программу, которая на вход 
// принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

if (number1>number2)
{
Console.WriteLine($"Число {number1} больше {number2}");
}
if (number2>number1)
{
Console.WriteLine($"Число {number2} больше {number1}");
}
if (number2==number1) Console.WriteLine("Числа равны");
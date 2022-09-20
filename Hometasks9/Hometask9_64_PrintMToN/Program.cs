// Задача 64: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""


void Task64()
{
    int m = new Random().Next(1, 21);
    Console.WriteLine($"Число M = {m}");
    int n = new Random().Next(1, 21);
    Console.WriteLine($"Число N = {n}");
    if (m == n) Console.WriteLine(n);
    else printMToN(m, n);
}
// Вывод натуральных чисел
void printMToN(int number1, int number2)
{
    if (number1 < number2)
    {
        while (number1 <= number2)
        {
            Console.Write($"{number1} ");
            number1++;
        }
    }
    else while (number1 >= number2)
    {
        Console.Write($"{number1} ");
        number1--;
    }
    Console.WriteLine();
}

Task64();
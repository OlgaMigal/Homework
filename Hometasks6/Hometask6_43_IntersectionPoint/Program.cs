// Задача 43: Напишите программу, которая найдёт 
// точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

void IntersectionPoint(double b1, double k1, double b2, double k2)
{
    if (k1 != k2)
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Точкой пересечения прямых y = {k1} * x + {b1}, y = {k2} * x + {b2}"
        + $" является ({x}; {y})");
        Console.WriteLine();
    }
    else Console.WriteLine($"Прямые y = {k1} * x + {b1}, y = {k2} * x + {b2} параллельны");
}

IntersectionPoint(b1, k1, b2, k2);
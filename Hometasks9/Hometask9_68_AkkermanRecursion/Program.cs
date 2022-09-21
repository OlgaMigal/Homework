// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29
//          |   n+1,                m=0;
// A(m,n) = {   A(m-1,1),           m>0, n=0;
//          |    A(m-1, A(m,n-1)),   m>0; n>0.

void Task68()
{
    int number1 = 3;
    Console.WriteLine($"Число M = {number1}");
    int number2 = 4;
    Console.WriteLine($"Число N = {number2}");
    Console.WriteLine($"Функция Аккермана({number1}, {number2}) = {AkkermanRecursion(number1, number2)}");
}

int AkkermanRecursion(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return AkkermanRecursion(m - 1, 1);
    else if (m > 0 && n > 0) return AkkermanRecursion(m - 1, AkkermanRecursion(m, n - 1));
    else return -1;
}

Task68();
// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void Task66()
{
    int number1 = new Random().Next(1, 21);
    Console.WriteLine($"Число M = {number1}");
    int number2 = new Random().Next(1, 21);
    Console.WriteLine($"Число N = {number2}");
    Console.WriteLine($"Сумма чисел от {number1} до {number2} = {RecursionSumMToN(number1, number2)} ");
}

int RecursionSumMToN(int m, int n)
{
    if (m == n) return m;
    else if (m > n) return m + RecursionSumMToN(m - 1, n);
    return m + RecursionSumMToN(m + 1, n);
}

Task66();

//Заодно решила без рекурсии

// void Task66()
// {
//     int m = new Random().Next(1, 21);
//     Console.WriteLine($"Число M = {m}");
//     int n = new Random().Next(1, 21);
//     Console.WriteLine($"Число N = {n}");
//     if (m == n) Console.WriteLine($"Это и суммой не назвать, но пусть {n}");
//     else Console.WriteLine($"Сумма элементов от {m} до {n} = {SumMToN(m, n)}");
// }
// // Метод суммы:
// int SumMToN(int number1, int number2)
// {
//     int sum = 0;
//     if (number1 < number2)
//     {
//         while (number1 <= number2)
//         {
//             sum += number1;
//             number1++;
//         }
//     }
//     else while (number1 >= number2)
//         {
//             sum+= number1;
//             number1--;
//         }
//     return sum;
// }

// Task66();

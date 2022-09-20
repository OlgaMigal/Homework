void Task66()
{
    int m = new Random().Next(1, 21);
    Console.WriteLine($"Число M = {m}");
    int n = new Random().Next(1, 21);
    Console.WriteLine($"Число N = {n}");
    if (m == n) Console.WriteLine($"Это и суммой не назвать, но пусть {n}");
    else Console.WriteLine($"Сумма элементов от {m} до {n} = {SumMToN(m, n)}");
}
// Метод суммы:
int SumMToN(int number1, int number2)
{
    int sum = 0;
    if (number1 < number2)
    {
        while (number1 <= number2)
        {
            sum += number1;
            number1++;
        }
    }
    else while (number1 >= number2)
        {
            sum+= number1;
            number1--;
        }
    return sum;
}

Task66();

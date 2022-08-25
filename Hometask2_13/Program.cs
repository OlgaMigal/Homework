// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// я бы сделала без метода, просто циклом, но
// нужно же тренировать новое
// Пишем метод для нахождения третьей цифры
void CheckAll(int number)
{
    int count = 0;
    int num = number;
    int first3 = number;
    if (number / 100 > 0)
    {
        while (num > 0)
        {
            num /= 10;
            count++;
        }
        Console.WriteLine("длина числа = " + count);
        // Теперь напишем цикл, заменяющий возведение 10 в степень. Жаль, 
        // Math.Pow работает только с double, double мне здесь не нужен
        for (int index = 1; index<(count-2); index++)
        {
            first3/=10;
        }
        int answer = first3%10;
        Console.WriteLine("Третья цифра числа = " + answer);
    }
    else Console.WriteLine("Введено слишком маленькое число, перезапустите программу");
}

Console.Write("Введите число не меньше трёхзначного: ");
int inter = int.Parse(Console.ReadLine());
CheckAll(inter);
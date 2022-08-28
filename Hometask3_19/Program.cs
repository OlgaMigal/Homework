// Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число ");
int number = Convert.ToInt32(Console.ReadLine());
int num = number;
if (number < 100000 && number > 9999)
{
    int num5 = num % 10;
    num /= 10;
    int num4 = num % 10;
    num /= 100;
    int num2 = num % 10;
    num /= 10;
    int num1 = num;
    if (num1 == num5 && num2 == num4)
    {
        Console.WriteLine($"Число {number} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {number} не является палиндромом");
    }
}
else Console.WriteLine($"Число {number} не пятизначное, перезапустите программу");
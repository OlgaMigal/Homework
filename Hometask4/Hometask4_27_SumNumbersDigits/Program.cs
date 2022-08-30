// Напишите программу, которая принимает на вход 
//число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

string NumbersDigitsSum(int num)
{
    if(num<0)
    {
        return "Err";
    }
    else
    {
        int i = 0;
        int result = 0;
        while(num>0)
        {
            result+=num%10;
            num/=10;
            i+=1;
        }
        return $"Cумма цифр введённого числа = {result}";
    }
}

Console.WriteLine("Введите положительное число: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine(NumbersDigitsSum(number));
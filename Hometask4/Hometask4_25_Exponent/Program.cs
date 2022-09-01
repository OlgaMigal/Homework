// Напишите цикл, который принимает на вход 
//два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


//Спасибо за коммент, при случае затестю ввод строкой, 
//пока же просто переделала под цикл (for, как советовали)

string Exponent(int num, int expo)
{
    int result = num;
    for(int i = 1; i<expo; i++)
    {
        result*=num;
    }
    
    return $"{num} в степени {expo} = {result}";
}

Console.WriteLine("Введите число и его степень: ");
int number = int.Parse(Console.ReadLine());
int exponenta = int.Parse(Console.ReadLine());

Console.WriteLine(Exponent(number, exponenta));
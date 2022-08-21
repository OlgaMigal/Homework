// Эта программа на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
Console.Write("Введите отличное от 0 число: ");
int number = int.Parse(Console.ReadLine());
if (number==0)
{
    Console.WriteLine("Введённое число равно 0, введите другое");
}
else
{
if (number%2==0)
{
    Console.WriteLine($"Число {number} - чётное");
}
if (Math.Abs(number)%2==1)
{
    Console.WriteLine($"Число {number} - нечётное");
}
}
// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.


// Попробовала через конструкцию switch, потому что раньше через неё не пробовала

Console.Write("Введите номер дня недели: ");
int num = int.Parse(Console.ReadLine());
switch (num)
{
    case 1:
        Console.WriteLine("будний день");
        break;
    case 2:
        Console.WriteLine("будний день");
        break;
    case 3:
        Console.WriteLine("будний день");
        break;
    case 4:
        Console.WriteLine("будний день");
        break;
    case 5:
        Console.WriteLine("будний день");
        break;
    case 6:
        Console.WriteLine("выходной");
        break;
    case 7:
        Console.WriteLine("выходной");
        break;
    default:
        Console.WriteLine("Под этим номером нет дня недели");
        break;
}

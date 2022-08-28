// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.


// Попробовала через конструкцию switch, потому что раньше через неё не пробовала

Console.Write("Введите номер дня недели: ");
int num = int.Parse(Console.ReadLine());
switch (num)
{
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
        Console.WriteLine("будний день");
        break;
    case 6:
    case 7:
        Console.WriteLine("выходной");
        break;
    default:
        Console.WriteLine("Под этим номером нет дня недели");
        break;
}

// Напишите программу, которая принимает на вход 
// число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Рабочий вариант, на семинаре получили доп.задание - 
//  вывести лишь одним Console.WriteLine, не помещая в цикл. И вот:

Console.Write("Введите число: ");
int max = int.Parse(Console.ReadLine());
string result = "";
for (int i = 1; i <= max; i++)
{
    double res = Math.Pow(i, 3);
    result = result + res + " | ";
}
Console.WriteLine(result);

// Клёвый альтернативный способ, но вроде выходящий за рамки познаний:

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(String.Join(" ", Enumerable.Range(1, num).Select(num=>num*num*num)));

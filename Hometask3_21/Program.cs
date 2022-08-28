// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние 
// между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

void Distance3D()
{
    Console.WriteLine("Введите координаты первой точки");
    Console.Write("x:");
    double x1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("y:");
    double y1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("z:");
    double z1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Координаты первой точки ({x1}, {y1}, {z1})");

    Console.WriteLine("Введите координаты второй точки");
    Console.Write("x:");
    double x2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("y:");
    double y2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("z:");
    double z2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Координаты второй точки ({x2}, {y2}, {z2})");

    double dist = 0;

    dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + 
                    Math.Pow(y2 - y1, 2) + 
                    Math.Pow(z2 - z1, 2));

    Console.WriteLine($"Расстояние между точками {Math.Round(dist, 2)}");

}

Distance3D();

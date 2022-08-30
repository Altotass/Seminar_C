// Задача 21 Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


double Getdistance()
    {
    Console.Write("Введите координаты точки А x1 = ");
    double x1 = double.Parse(Console.ReadLine());
    Console.Write("Введите координаты точки А у1 = ");
    double y1 = double.Parse(Console.ReadLine());
    Console.Write("Введите координаты точки В х1 = ");
    double z1 = double.Parse(Console.ReadLine());
   
    Console.Write("Введите координаты точки В x1 = ");
    double x2 = double.Parse(Console.ReadLine());
    Console.Write("Введите координаты точки А y2 = ");
    double y2 = double.Parse(Console.ReadLine());
    Console.Write("Введите координаты точки А z2 = ");
    double z2 = double.Parse(Console.ReadLine());
        
    double a = Math.Pow(x1 - x2,2) + Math.Pow(y1 - y2,2) + Math.Pow(z1 - z2,2);
    double res = Math.Sqrt(a);
    return res;
}
try 
{
    Console.WriteLine(Getdistance());
}
catch
{
    Console.WriteLine("Надо вводить цифры");
}

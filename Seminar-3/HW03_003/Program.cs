// Задача 23
// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

//void Quadron()
//{
        Console.WriteLine("Введите число N = ");
        int N = int.Parse(Console.ReadLine());
        double x;
        for (int i = 1; i <= N; i++)
        {
            x = Math.Pow(i,3);
            Console.Write($"{x}, ");
        }
    try
    {
    //Quadron();
    }
        catch
        {
        Console.WriteLine("Введите положительное число от 1 ...");
        }
//}
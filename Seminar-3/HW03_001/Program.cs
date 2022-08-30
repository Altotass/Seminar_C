// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void Palindrom()
{
Console.WriteLine("Введите пятизначное число, х = ");
            string s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = s.Length - 1; j > 0; j--)
                {
                    if (s[i] == s[j])                         
                    Console.WriteLine("Введенная строка палиндром");
                    else                         
                    Console.WriteLine("Введенная строка не палиндром");
                return;
                }
            }
}
Palindrom();
 

// Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число1: ");
int a = Int32.Parse(Console.ReadLine());

Console.WriteLine("Введите число2: ");
int b = Int32.Parse(Console.ReadLine());

Console.WriteLine("Введите число3: ");
int c = Int32.Parse(Console.ReadLine());
int max = a;

if (b > a)
    {
        max = b;
    }
if (c > max)
{
    max = c;
}
Console.Write("Максимальное число: ");
Console.WriteLine(max);
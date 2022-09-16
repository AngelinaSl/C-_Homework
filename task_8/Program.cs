/*
Задача 8: Напишите программу, которая на вход принимает число (N), 
А на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Write("Введите число (только не вводи 1): ");
int i = Convert.ToInt32(Console.ReadLine());

for (int x = 2; x <= i; x++)
    if (x % 2 == 0)
    {
        Console.WriteLine(x);
    }
if (i == 1)
{
    Console.WriteLine ("А я предупреждала!");
}
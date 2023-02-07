// Задача 66: Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30


int GetNumberByUser(int m, int n)
{
    if (m == n)
        return n;

    return m + GetNumberByUser(m + 1, n);
}
Console.WriteLine("Введите значение m:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение n:");
int n = Convert.ToInt32(Console.ReadLine());

if (m < n)
    Console.WriteLine($"M = {m}, N = {n} -> {GetNumberByUser(m, n)}");
else
    Console.WriteLine($"n больше m");

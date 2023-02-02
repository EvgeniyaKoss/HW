// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

(double, double) IntersectionPoint(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    return (x, y);
}
double GetValue(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToDouble(Console.ReadLine());
}
double b1 = GetValue("Введите b1: ");
double k1 = GetValue("Введите k1: ");
double b2 = GetValue("Введите b2: ");
double k2 = GetValue("Введите k2: ");

var r = IntersectionPoint(b1, k1, b2, k2);
System.Console.WriteLine($"Пересечение в точке: ({r})");

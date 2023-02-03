//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

(int, int) GetNumberByUser()
{
  Console.WriteLine("Введите количество строк массива: ");
  int rows = int.Parse(Console.ReadLine());
  Console.WriteLine("Введите количество столбцов  массива: ");
  int columns = int.Parse(Console.ReadLine());
  return (rows, columns);
}

double[,] CreateMatrix(int rows, int columns)
{
  double[,] matr = new double[rows, columns];
  return matr;
}
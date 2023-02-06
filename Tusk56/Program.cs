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

int[,] FillMatrix(int row, int column)
{
  int[,] arr = new int[row, column];

  for (int r = 0; r < row; r++)
  {
    for (int c = 0; c < column; c++)
    {
      arr[r, c] = Convert.ToInt32(new Random().Next(0, 10));
      Console.Write(arr[r, c] + " ");
    }
    Console.WriteLine();
  }
  return arr;
}
string MinSumLine(int[,] matr)
{
  int tempr = 0;
  int mintemp = 0;
  for (int c = 0; c < matr.GetLength(1); c++)
  {
    mintemp += matr[0, c];
  }

  for (int r = 1; r < matr.GetLength(0); r++)
  {
    int sum = 0;
    for (int c = 0; c < matr.GetLength(1); c++)
    {
      sum += matr[r, c];
    }
    if (mintemp > sum)
    {
      mintemp = sum;
      tempr = r;
    }
  }
  Console.WriteLine($"Минимальная сумма в строке: {mintemp}");
  return $"{tempr}";
}

(int row, int column) size = GetNumberByUser();
int[,] matrix = FillMatrix(size.row, size.column);
string minsum = MinSumLine(matrix);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minsum} ");

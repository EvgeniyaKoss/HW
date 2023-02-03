//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//m = 3, n = 4.

//0,5 7 -2 -0,2

//1 -3,3 8 -9,9

//8 7,8 -7,1 9


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

void FillMatrix(double[,] matr)

    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
                Console.Write($"| {matr[i, j]} |");
            }

            Console.WriteLine();
        }
    }

(int rows, int columns) size = GetNumberByUser();
double[,] matrix = CreateMatrix(size.rows, size.columns);
FillMatrix(matrix);
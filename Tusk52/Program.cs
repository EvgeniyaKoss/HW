//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4

//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

(int, int) GetNumberByUser()
{
    Console.WriteLine("Введите количество строк массива(m): ");
    int rows = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов  массива (n): ");
    int columns = int.Parse(Console.ReadLine());
    return (rows, columns);
}

int[,] FillMatrix(int rows, int columns)
{
    int[,] arr = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[i, j] = Convert.ToInt32(new Random().Next(10));
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    return arr;
}
void Average(int[,] array)
{
    double midlNumbers = 0;
    Console.WriteLine();
    for (int j = 0; j < array.GetLength(0); j++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            midlNumbers += array[i,j];
        }
        Console.WriteLine ($"{Math.Round(midlNumbers / array.GetLength(1), 2)}");
        midlNumbers = 0;
    }
}

(int rows, int columns) size = GetNumberByUser();
int[,] matrix = FillMatrix(size.rows, size.columns);
Console.Write("Cреднее арифметическое каждого столбца: ");
Average(matrix);


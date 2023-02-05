//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.


int[,] CreateFillArray()
{
    Console.WriteLine("Введите количество строк и столбцов в таблице (ввод числа через enter): ");
    int[,] arr = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
    Console.WriteLine();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Random.Shared.Next(100);
            Console.Write($"|{arr[i, j], 3} | ");
        }
        Console.WriteLine();
    }
    return arr;
}
void GetElementArray(int[,] array)
{
    Console.Write("Введите индекс строки: ");
    int line = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите индекс столбца: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    if (line < array.GetLength(0) & colums < array.GetLength(1))
    {
        Console.WriteLine($"Элемент массива по индексу ({line},{colums}) = {array[line,colums]}");
    }
    else Console.WriteLine($"Элемента ({line},{colums}) не существует");
}
int[,] arr = CreateFillArray();
GetElementArray(arr);
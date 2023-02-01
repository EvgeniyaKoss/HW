//Задача 37: 
//Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.
//СДЕЛАТЬ МИНИМУМ ТРИ МЕТОДА

//1.Ввод данных от пользователя
int GetNumberByUser()
{
    Console.WriteLine("Введите количество элементов массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    return size;
}

//2.Создание массива
int[] CreateArray(int size)
{
    return new int[size];
}

//3.Заполнение массива
int[] FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Random.Shared.Next(10);
        Console.Write($"{arr[i]}|");
    }
    System.Console.WriteLine();
    return arr;

}

//4.Найти произведение 
int[] ArrMult(int[] array)
{
    int[] arrRezult = new int[array.Length / 2];
    for (int i = 0; i < array.Length / 2; i++)
    {
        arrRezult[i] = array[i] * array[array.Length - 1 - i];
    }
    return arrRezult;
}
//5. Средний элемент нечетного масссива
void GetNumMid(int[] arr)
{
    if (arr.Length % 2 != 0)
    {
        int arrMid = arr[arr.Length / 2];
        Console.Write(arrMid);
    }
}

//6.Печать нового массива
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}|");
    }
}



int size = GetNumberByUser();
int[] arr = CreateArray(size);
FillArray(arr);
int[] arrRezult = ArrMult(arr);
PrintArray(arrRezult);
GetNumMid(arr);

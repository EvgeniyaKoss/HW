//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

int GetNumberByUser()
{
  Console.Write("Введите значение : ");
  int num = Convert.ToInt32(Console.ReadLine());
  return num;
}

double FunctionAkerman(double m, double n)
{
  if (m == 0)
    return n + 1;
  else if (m > 0 && n == 0)
    return FunctionAkerman(m - 1, 1);
  else return FunctionAkerman(m - 1, FunctionAkerman(m, n - 1));
}
int m = GetNumberByUser();
int n = GetNumberByUser();
Console.WriteLine(FunctionAkerman(m, n));
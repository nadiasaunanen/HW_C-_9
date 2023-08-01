// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите наименьшее число: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите наибольшее число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m > n)
{
    Console.WriteLine("Cначала введите наименьшее число"); 
    return;
}

int SumElements(int m, int n)
{
  if (m == n) return m;
  else return SumElements(m + 1, n) + m;
}

Console.WriteLine($"Сумма элементов: {SumElements(m, n)}");
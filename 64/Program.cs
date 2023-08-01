// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1)
{
  Console.WriteLine("Ввдите положительное число");
  return;
}
Console.WriteLine(NaturalNumber(number, 1));


int NaturalNumber(int number, int m)
{
  if (number == m) 
  {
    return number;
  }
  else
 {
    Console.Write($"{NaturalNumber(number, m + 1)}, ");
 }
  return m;
}


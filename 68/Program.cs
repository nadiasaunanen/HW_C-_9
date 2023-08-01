// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber < 0 || secondNumber < 0)
{
    Console.WriteLine("Введите положительные числа");
    return;
}

int FunctionAkkerman(int firstNumber, int secondNumber)
{
  if (firstNumber == 0) 
  {
    return secondNumber + 1;
  }
  if (firstNumber > 0 && secondNumber == 0)
  {
    return FunctionAkkerman(firstNumber - 1, 1);
  }
  else
  {
    return FunctionAkkerman(firstNumber - 1, FunctionAkkerman(firstNumber, secondNumber - 1));
  }
}

Console.WriteLine($"Функция Аккермана({firstNumber}, {secondNumber}) = {FunctionAkkerman(firstNumber, secondNumber)}");
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

int m = InputNumbers("Введите M: ");
int n = InputNumbers("Введите N: ");

int Akkerman = Numbers(m, n);

Console.Write($"Функция Аккермана равна: {Akkerman} ");

int Numbers(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Numbers(m - 1, 1);
  else return Numbers(m - 1, Numbers(m, n - 1));
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
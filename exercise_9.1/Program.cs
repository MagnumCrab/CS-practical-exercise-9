// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.

int m = InputInt("Введите число M: ");
int n = InputInt("Введите число N: ");
if (m > n)
{
    Console.WriteLine("В промежутке от M до N нет натуральных чисел");
}
Console.WriteLine(NaturalNumber(m, n));

int NaturalNumber(int m, int n)
{
    if (m == n)
        return m;
    else
        Console.Write($"{NaturalNumber(m, n - 1)}, ");
    return n;
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
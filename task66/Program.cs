/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */


Console.WriteLine("Введите 2 числа:");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int m, int n)
{
    if (m > n) return 0;
    return m + SumNumbers(++m, n);
}

Console.WriteLine($"Сумма натуральных чисел от {m} до {n} = {SumNumbers(m, n)}");
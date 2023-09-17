/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 

       n + 1                ---  m = 0;
A(m,n) A(m-1, 1)            ---  m > 0, n = 0;
       A(m - 1, A(m, n -1)) ---  m > 0, n > 0;
*/
// Как я понял перепутал местами значения m n по сравнению с таблицей на Вики. Терпения переделывать не хватило.
Console.WriteLine("Введите 2 числа:");
long m = Convert.ToInt64(Console.ReadLine()); 
long n = Convert.ToInt64(Console.ReadLine());

long Akkerman(long m, long n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}

Console.WriteLine(Akkerman(m, n));
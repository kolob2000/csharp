// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите первое число -");
int m = Int32.Parse(Console.ReadLine());

Console.WriteLine("Введите второое число -");
int n = Int32.Parse(Console.ReadLine());

void EvenRecursive(int m, int n)
{
    {
    }
    if (m > n)
    {
        (m, n) = (n, m);
        Console.WriteLine("Меняем числа местами...");
    }

    if (m % 2 == 0)
    {
        string output = m + 1 != n ? $"{m}," : $"{m}";
        Console.Write(output);
    }

    if (m < n)
    {
        EvenRecursive(++m, n);
    }
}

EvenRecursive(m, n);

int SumRecursive(int m, int n, int flag = 1)
{
    if (flag == 1 & m == n) return m + n;

    if (m > n)
    {
        (m, n) = (n, m);
        Console.WriteLine("Меняем числа местами...");
    }

    if (m < n)
    {
        return m + SumRecursive(++m, n, 0);
    }
    else
    {
        Console.WriteLine();
        return n;
    }
}

Console.WriteLine(SumRecursive(m, n));

int Ackerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ackerman(m - 1, 1);
    }
    else
    {
        return Ackerman(m - 1, Ackerman(m, n - 1));
    }
}

Console.WriteLine(Ackerman(2, 3));
Console.WriteLine(Ackerman(3, 2));
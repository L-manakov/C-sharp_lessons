// Вычислить а^n

// Итерация
int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}
Console.WriteLine(PowerFor(2, 10)); // 1024

// Рекурсия
int PowerRec(int a, int n)
{
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
}
Console.WriteLine(PowerRec(2, 10)); // 1024

// Рекурсия - сокращенное написание
int PowerRec1(int a, int n)
{
    return n == 0 ? 1 : PowerRec(a, n - 1) * a;
}
Console.WriteLine(PowerRec1(2, 10)); // 1024

// Рекурсия - математически оптимизирована
int PowerRecMath(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n - 1) * a;
}
Console.WriteLine(PowerRecMath(2, 10)); // 1024
int Factorial(int n)
{
    if(n==1) return 1;
    else return n * Factorial(n -1);
}
for (int i = 0; i < 40; i++)
{
Console.WriteLine($"{i}! = {Factorial(i)}"); // i - аргумент факториала   
}

// при вычеслении больших факториалов (!20) int переполняется
// можно заменить на double
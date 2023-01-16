// Вид 1 - Методы, которые ничего не возвращают и не принимают.

void Method1()
{
    Console.WriteLine("Автор ...");
}
//Method1();  // Вызываются идентификатором метода с круглыми скобками



// Вид 2 - Методы, которые ничего не возвращают, но могут принимать какие-то аргументы

void Method2(string msg)
{
     Console.WriteLine(msg);
}
//Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;        // увеличении числа на +1 - инкремент
    }
}
//Method21(msg: "Текст", count: 4);   // "текст" - аргумент, 4 -количество выводов



// Вид 3 - Методы, которые что-то возвращают, но ничего не принимают

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);



// Вид 4 - Методы, которые что-то принимают и что-то возвращают

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; // изначально присваиваем результату пустую строку

    while (i < count)
    {
        result = result + text;        
        i++;
    }     
    return result;  // оператор return возвращает переменную, которую мы ожидаем получить из метода
}
string res = Method4(10, "qwerty ");
Console.WriteLine(res);



// Цикл for

string Method41(int count, string text)
{
    string result = String.Empty; // изначально присваиваем результату пустую строку
    for(int i = 0; i < count;  i++)
    {
        result = result + text;        
    }     
    return result;  // оператор return возвращает переменную, которую мы ожидаем получить из метода
}
string res41 = Method41(10, "qw ");
Console.WriteLine(res41);



// Цикл в цикле
// Пример - вывод таблицы умножения на экран

for (int i = 2; i <= 10; i++)       // внешний цикл
{
    for (int j = 0;  j <= 10;  j++) // оператор или тело метода
    {
        Console.WriteLine($"{i} x {j} = {i*j}"); // выводим через интерполяцию строк
    }
    Console.WriteLine();            // разрыв строки между циклами
}


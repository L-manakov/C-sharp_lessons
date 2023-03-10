void FillArray(int[] collection)     // FillArray - метод создания массива / collection - аргумент
{
    int length = collection.Length;  // длина массива
    int index = 0;

    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)          // PrintArray - метод печати массива на экран 
{
    int count = col.Length;
    int position = 0;

    while (position < count)
    {
        Console.Write(col[position] + " ");     // Console.Write($"{col[position]} "); - или так
        position++;
    }
}

int IndexOf(int[] collection, int find) // IndexOf - метод поиска числа 
                                        //[] - массив поиска, int find - искомое число
{
    int count = collection.Length;
    int index = 0;
    int position = -1;                  // если числа не существует, то выводится "-1"

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 7);    // array - аргумент, "7" - искомое число
Console.WriteLine(pos);
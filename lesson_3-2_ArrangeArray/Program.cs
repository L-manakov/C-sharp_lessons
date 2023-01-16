// Алгоритм сортировки методом выбора (Min и Max)

// 1. Найти позицию минимального элемента в неотсоритрованной части массива
// 2. Произвести обмен этого значения со значением первой неотсортированной позиции
// 3. Повторить пока есть не отсортированные элементы

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)    // метод вывода массива на экран
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSortUp(int[] array) // метод упорядочивания массива от min к max
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j; // поиск min
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

void SelectionSortDown(int[] array) // метод упорядочивания массива от max к min
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j; // поиск max
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

PrintArray(arr);

SelectionSortUp(arr);
PrintArray(arr);

SelectionSortDown(arr);
PrintArray(arr);
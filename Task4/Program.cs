// Задача HARD SORT необязательная. Считается за три обязательных
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.
// Например, задан массив:
// 1 4 7 2
// 5 9 10 3
// После сортировки
// 1 2 3 4
// 5 7 9 10

int Enter(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void FillArray(int[,] array, int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(min, max + 1);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],5}\t");
        Console.WriteLine();
    }
}

int[,] SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int m = 0; m < array.GetLength(0); m++)
                for (int n = 0; n < array.GetLength(1); n++)
                    if (array[i, j] < array[m, n])
                    {
                        int temp = array[i, j];
                        array[i, j] = array[m, n];
                        array[m, n] = temp;
                    }
    return array;
}

try
{
    int rows = Enter("Введите количество строк: ");
    int cols = Enter("Введите количество столбцов: ");
    int min = Enter("Введите минимально возможное число: ");
    int max = Enter("Введите максимально возможное число: ");
    int[,] array = new int[rows, cols];
    FillArray(array, min, max);
    PrintArray(array);
    Console.WriteLine();
    PrintArray(SortArray(array));
}
catch
{
    Console.WriteLine("Введено некорректное значение");
}
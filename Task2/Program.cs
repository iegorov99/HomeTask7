// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

bool SearchNumber(int[,] array, int num)
{
    bool flag = false;
    foreach (int item in array)
        if (item == num) flag = true;
    return flag;
}

int SearchIndexI(int[,] array, int num)
{
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] == num) result = i;
    return result;
}

int SearchIndexJ(int[,] array, int num)
{
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] == num) result = i;
    return result;
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
int num = Enter("Введите искомое число: ");
// SearchNumber(array, num);
if (SearchNumber(array, num))
    Console.WriteLine($"Такое число есть в ммассиве {SearchIndexI(array, num)}, {SearchIndexJ(array, num)}");
else
    Console.WriteLine("Такого числа нет в ммассиве");
}
catch
{
    Console.WriteLine("Введено некорректное значение");
}
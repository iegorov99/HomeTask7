// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int Enter(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void FillArray(double[,] array, int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = Math.Round(new Random().Next(min, max + 1) * new Random().NextDouble(), 2);
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],5}\t");
        Console.WriteLine();
    }
}

try
{
int rows = Enter("Введите количество строк: ");
int cols = Enter("Введите количество столбцов: ");
int min = Enter("Введите минимально возможное число: ");
int max = Enter("Введите максимально возможное число: ");
double[,] array = new double[rows, cols];
FillArray(array, min, max);
PrintArray(array);
}
catch
{
    Console.WriteLine("Введено некорректное значение");
}
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2  
// 5 9 2 3      
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int Enter(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);
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

void Average(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double result = 0;
        for (int i = 0; i < array.GetLength(1); i++)
            result += array[i, j];
        Console.WriteLine($"Среднее арифметическое {j + 1}-го столбца равно {result / array.GetLength(1)}");
    }
}

try
{
    int rows = Enter("Введите количество строк: ");
    int cols = Enter("Введите количество столбцов: ");
    Console.WriteLine();
    int[,] array = new int[rows, cols];
    FillArray(array);
    PrintArray(array);
    Console.WriteLine();
    Average(array);
}
catch
{
    Console.WriteLine("Введено некорректное значение");
}
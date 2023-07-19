// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int colums = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное число: ");
int minRand = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число: ");
int maxRand = Convert.ToInt32(Console.ReadLine());

int[,] array2D = GetMatrix(rows, colums, minRand, maxRand);
PrintMatrix(array2D);

int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            matrix[i, j] = new Random().Next(minRand, maxRand + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine();

double[] average = new double[array2D.GetLength(1)];

for (int i = 0; i < array2D.GetLength(1); i++)
{
    double result = 0;
    for (int j = 0; j < array2D.GetLength(0); j++)
    {
        result += array2D[j, i];
    }
    average[i] = Math.Round(result / array2D.GetLength(0), 2);
}
PrintAverage(average);

void PrintAverage(double[] array)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "; ");
    }
}

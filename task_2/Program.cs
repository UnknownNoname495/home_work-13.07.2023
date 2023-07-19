// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет

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

Console.Write("Введите номер строки: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int j = Convert.ToInt32(Console.ReadLine());

if (i < 0 | j < 0)
    Console.WriteLine("Вы ввели отрицательные значения!");
if (i > rows | j > colums)
    Console.WriteLine("Такого элемента не существует.");
else
    Console.WriteLine($"Элемент {i} строки и {j} столбца -> {array2D[i, j]} ");

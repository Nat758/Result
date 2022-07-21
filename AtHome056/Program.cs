// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с
// наименьшей суммой элементов: 1 строка

int[,] GreateMatrixRndInt(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }
    return array;
}


void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < arr.GetLength(1) - 1) Console.Write(arr[i, j] + ",");
            else Console.Write(arr[i, j] + "]");
        }
        Console.WriteLine();
    }
}

int SumLines(int[,] arra)
{
    int sum = int.MaxValue;
    int index = 0;

    for (int i = 0; i < arra.GetLength(0); i++)
    {
        int sum1 = 0;
        for (int j = 0; j < arra.GetLength(1); j++)
        {
            sum1 += arra[i, j];
        }
        if (sum1 < sum)
        {
            sum = sum1;
            index = i;
        }
    }
    return index;
}

int[,] matrix = GreateMatrixRndInt(3,4,1,10);
PrintMatrix(matrix);
SumLines(matrix);
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет


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
Console.WriteLine("Введите позицию строки:");
int index1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию столбца:");
int index2 = Convert.ToInt32(Console.ReadLine());

void ElementMatrix(int ind1, int ind2, int[,] ind)
{
    if(ind1>ind.GetLength(0) || ind2> ind.GetLength(1))
    {
    Console.WriteLine("Такого числа нет");
    }
    else
    {
        Console.WriteLine(ind[ind1,ind2] );
    }
}


int[,] matrix = GreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(matrix);
Console.WriteLine();
ElementMatrix(index1,index2,matrix );

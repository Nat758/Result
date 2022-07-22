// Задайте две матрицы. Напишите программу, которая будет находить
// произведение двух матриц.
int[,]  GreateMatrixRndInt(int m, int n, int min, int max)
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




int[,] WorkMatrix(int[,] arr1, int[,] arr2)
{
    int[,] arr3 = new int[arr1.GetLength(0), arr2.GetLength(1)];
for (int r = 0; r < arr1.GetLength(0); r++)
{
    for (int i = 0; i < arr2.GetLength(1); i++)
    {
        for (int j = 0; j < arr2.GetLength(0); j++)
        {
            arr3[r, i] += arr1[r, j] * arr2[j, i];
        }


    }
}
return arr3;
}




int[,] matrix = GreateMatrixRndInt(2, 3, 1, 10);
PrintMatrix(matrix);
Console.WriteLine();
int[,] matrix1 = GreateMatrixRndInt(3, 2, 1, 5);
PrintMatrix(matrix1);
int[,] arr0= WorkMatrix(matrix,matrix1);
Console.WriteLine();
PrintMatrix(arr0);
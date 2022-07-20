
// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

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


int[,] StreamlineMatrix(int[,] arr2)
{
for (int i = 0; i < arr2.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
         for (int k = 0; k < arr2.GetLength(1)-1; k++)
         {
            if(arr2[i,k]>arr2[i,k+1])
            {
                 int temp = arr2[i,k];
                 arr2[i,k]=arr2[i,k+1];
                 arr2[i,k+1]=temp; 
            }
            
         }
        } 
    }
    return arr2;
}

int[,] matrix =GreateMatrixRndInt(3, 4, 1, 15);
PrintMatrix(matrix);
StreamlineMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix);

//  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine("Введите колличество строк");
int ind1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов");
int ind2 = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrix(int m, int n)
{
    int[,] array = new int[m,n];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
           array[i,j]= i+j ;
        }
    }
    return array;
}

void PrintMatrix(int[,]arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j< arr.GetLength(1); j++)
        {
            if(j==0) Console.Write("[");
            if(j<arr.GetLength(1)-1) Console.Write(arr[i,j] +",");
            else Console.Write(arr[i,j] + "]");
        }
        Console.WriteLine();
    }
}

  double[] ArifmeticMeanColumn(int[,]arr)
  {
    double[] arra = new double[arr.GetLength(1)];
    for(int j = 0; j<arr.GetLength(1); j++)
    {
        double sum = 0.0;
        for(int i = 0; i < arr.GetLength(0);i++)
        {
            sum+=arr[i,j];
        }
        arra[j] = sum/arr.GetLength(1);   
    }
    return arra;
  }
   



int[,] matrixs = CreateMatrix(ind1,ind2);
PrintMatrix(matrixs); 
double[] res= ArifmeticMeanColumn(matrixs);
for(int i = 0; i < res.Length; i++)
{
 Console.Write($" {res[i]} ");
}

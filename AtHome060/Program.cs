// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.




int[,,] CreateMatrixRndInt(int m, int n, int l)
{
    int[] array = new int[m * n * l*10];
    int[,,] array3d = new int[m, n, l];
    var rnd = new Random();
    int index= 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < l; k++)
            {
                while(true)
                {
                   int num= rnd.Next(10, 100);
                   if(array.Contains(num))
                   {
                      continue;
                   }
                   else
                   {
                     array3d [i,j,k]=num;
                     array[index]= num;
                     index++;
                     break;
                   }
                }
                
            }
        }
    }
    return array3d;
}    


void PrintMatrix(int[,,] arr)
{
      for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.WriteLine($"{i} {j} {k} - {arr[i,j,k]} ");

            }
        }
    }
}

PrintMatrix(CreateMatrixRndInt(3,3,3));




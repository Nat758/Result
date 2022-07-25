// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] CreateMatrixRndInt(int m,int n,int l)
{
    int[] array= new int[m*n*l];
    var rnd= new Random();
    int index=0;
    while(index<array.Length)
    {
        array[index]= rnd.Next(10,100);
        index++;
    }
}
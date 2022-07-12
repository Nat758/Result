// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] array = new int[6];
// var rnd = new Random();
// int index = 0;
// while (index < array.Length)
// {
//     array[index] = rnd.Next(1, 100);
//     Console.Write($"{array[index]} ");
//     index++;
// }
// int sumOdd = 0;
// for (int i = 1; i < array.Length; i++)
// {
//     if (i % 2 == 1)
//         sumOdd += array[i];
// }
// Console.WriteLine();
// Console.WriteLine(sumOdd);


int[] CreateArrayRndInt(int size)
{
    int[] array = new int[size];
    var rnd = new Random();
    int index = 0;
    while (index < array.Length)
    {
        array[index] = rnd.Next(1, 100);
        index++;
    }
    return array;
}

int[] GetSumOddElem(int[] arr)
{
    int sumOdd = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (i % 2 == 1)
            sumOdd += arr[i];
    }
    return new[] {sumOdd};
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i] + "]");
    }
}



int[] array = CreateArrayRndInt(6);
PrintArray(array);
int[] getSumOddElem = GetSumOddElem(array);
Console.WriteLine();
Console.WriteLine(getSumOddElem[0]);

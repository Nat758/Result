// Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] GetRandomArray(int length)
{
    double[] result = new double[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().NextDouble() * 100;
    }

    return result;
}

void PrintArray(double[] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(Math.Round(arrayToPrint[i], 1));
        if (i != arrayToPrint.Length - 1)
        {
            Console.Write("; ");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}


void DifferenceMaxMinElem(double[] arr)
{
    double max = arr[0];
    double min = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    Console.WriteLine($"Максимальный элемент массива {Math.Round(max, 1)}");
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i]<min)
        {
            min= arr[i];
        }
    }
    Console.WriteLine($"Минимальный элемент массива {Math.Round(min, 1)}");
    double diff = max - min;
    Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна {Math.Round(diff, 1)})");

}
Console.WriteLine("Введи размер массива");
int length = Convert.ToInt32(Console.ReadLine());
double[] randomArray = GetRandomArray(length);
PrintArray(randomArray);
DifferenceMaxMinElem(randomArray);
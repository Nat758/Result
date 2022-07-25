//  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных
// элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.WriteLine("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m > n)
{
    int temp = m;
    m = n;
    n = temp;
}
int sum = SumNaturalElement(m, n);
Console.WriteLine($"{sum}");


int SumNaturalElement(int numA, int numB)
{
    int sum = 0;
    for (int i = numA; i <= numB; i++)
    {
        sum += i;
    }
    return sum;
}
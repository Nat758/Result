// Напишите программу, которая принимает на вход число
//  (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
void Cube (int a)
{
    int index = 1;
    while(index <= a)
    {
        int cube = index*index*index;
        Console.WriteLine($"{cube} ");
        index++;
    }
}
Cube(num);
//  Напишите программу, которая принимает на вход число и 
//  выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 1; i <=number; i++)
{
    sum = sum+i;
}
Console.WriteLine($"Сумма числа {sum}");
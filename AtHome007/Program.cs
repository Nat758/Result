// Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
Console.WriteLine("Введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());
int res = (num1 + num2) % 2;
if (res == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
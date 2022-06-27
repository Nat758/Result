// Напишите программу, которая на вход принимает 
// число и выдаёт, является ли число четным
// (делится ли оно на 2 без остатка).
// 4->да
// - 3->нет
// 7->нет
Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 % 2 == 0)
{
    Console.WriteLine("Четное");
}
else
{
    Console.WriteLine("Нечётное");
}
//  Напишите программу, которая принимает на вход цифру, 
//  обозначающую день недели, и проверяет, 
//  является ли этот день выходным.
Console.WriteLine("Введите номер дня недели:");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0 && num < 8)
{
    if (num == 1) Console.WriteLine("Понедельник");
    else if (num == 2) Console.WriteLine("Вторник");
    else if (num == 3) Console.WriteLine("Среда");
    else if (num == 4) Console.WriteLine("Четверг");
    else if (num == 5) Console.WriteLine("Пятница");
    else if (num == 6) Console.WriteLine("Суббота");
    else if (num == 7) Console.WriteLine("Воскресенье");
}
else Console.WriteLine("Ошибка ввода!");
if (num > 5 && num < 8)
    Console.WriteLine("Выходной:");


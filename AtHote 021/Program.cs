// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние 
// между ними в 3D пространстве.
Console.WriteLine("Ввести координаты точки х1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввести координаты точки y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввести координаты точки х2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввести координаты точки y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввести координаты точки х3: ");
int x3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввести координаты точки y3: ");
int y3 = Convert.ToInt32(Console.ReadLine());

double Distance (int a1, int b1, int c1, int a2, int b2, int c2)

{
    double res = Math.Sqrt((a1-a2)*(a1-a2)+(b1-b2)*(b1-b2)+(c1-c2)*(c1-c2));
    res = Math.Round(res,2);
    return res;
}
double result = Distance(x1, y1, x2, y2, x3, y3);
Console.WriteLine(result);
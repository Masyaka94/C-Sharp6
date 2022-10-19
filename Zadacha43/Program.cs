/*43. Напишите программу, которая найдет точку пересечения двух прямых, 
заданных уравнениями y = k1*x+b1; y = k2*x+b2; значения b1, k1, b2, k2 задаются пользователем. */

Console.Write($"Введите число b1 для задания прямой вида y1 = k1*x+b1:  ");
double b1 = double.Parse(Console.ReadLine()!);
Console.Write($"Введите число k1 для задания прямой вида y1 = k1*x+b1:  ");
double k1 = double.Parse(Console.ReadLine()!);

Console.Write($"Введите число b2 для задания прямой вида y2 = k2*x+b2:  ");
double b2 = double.Parse(Console.ReadLine()!);
Console.Write($"Введите число k2 для задания прямой вида y2 = k2*x+b2:  ");
double k2 = double.Parse(Console.ReadLine()!);

double x = (b2-b1)/(k1-k2);
System.Console.WriteLine(x);
double y = k1*x+b1;
System.Console.WriteLine(y);
if (k1==k2) 
{
    Console.Write($"Прямые параллельны");
}
else 
{
    Console.Write($"Прямые пересекаются в точке ({x};{y})");
}


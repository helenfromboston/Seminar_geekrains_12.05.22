// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями:
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

Console.WriteLine("Введите значения b1, k1, b2 и k2 для уравнений: y = k1 * x + b1, y = k2 * x + b2");
Console.Write("b1 = ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("k1 = ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("b2 = ");
double b2 = double.Parse(Console.ReadLine());
Console.Write("k2 = ");
double k2 = double.Parse(Console.ReadLine());

/* k1 * x + b1 - k2 * x - b2 = 0
x * (k1 - k2) + b1 - b2 = 0
x * (k1 - k2) = b2 - b1
x = (b2 - b1) / (k1 - k2) */

double x = (b2 - b1) / (k1 - k2);
double y = k2 * x + b2;

Console.WriteLine($"Координаты точки пересечения прямых y = {k1} * x + {b1}, y = {k2} * x + {b2} = ({Math.Round(x, 2)};{Math.Round(y, 2)})");
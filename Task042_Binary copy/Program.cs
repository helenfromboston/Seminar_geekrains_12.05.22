// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101 // 3  -> 11 // 2  -> 10

Console.WriteLine("Введите десятичное число: ");
int A = int.Parse(Console.ReadLine());

string J = string.Empty;

while (A > 0)
{
    J = A % 2 + J;
    A = A / 2;
}

Console.WriteLine(J);
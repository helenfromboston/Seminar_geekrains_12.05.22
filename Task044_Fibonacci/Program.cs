// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3 // Если N = 3 -> 0 1 1 // Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите число для вывода такого количества первых чисел Фибоначчи:");
int N = int.Parse(Console.ReadLine());

int A1 = 0;
int A2 = 1;
int sum = 0;

Console.Write(A1 + " " + A2 + " ");
for (int i = 0; i < N - 2; i++)
{
    sum = A1 + A2;
    A1 = A2;
    A2 = sum;
    Console.Write(sum + " ");
}
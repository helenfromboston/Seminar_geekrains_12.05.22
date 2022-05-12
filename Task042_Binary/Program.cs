// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101 // 3  -> 11 // 2  -> 10

Console.WriteLine("Введите десятичное число: ");
int A = int.Parse(Console.ReadLine());
int save = A;

int count = 0;
while (save > 0)
{
    save = save / 2;
    count++;
}

int[] array = new int[count];
int i = array.Length - 1;

while (A > 0)
{
    array[i] = A % 2;
    A = A / 2;
    i--;
}

for (i = 0; i < array.Length; i++)
{
    Console.Write(array[i]);
}
Console.WriteLine();
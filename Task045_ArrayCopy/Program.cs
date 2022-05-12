// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] FillArray(int size, int A, int B)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(A, B);
    }
    return array;
}

void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] mass = FillArray(10, 1, 100);

Print(mass);

int[] mass2 = new int[mass.Length]; // 2 так что для копирования массива нужно именно поэлементно копировать

for (int i = 0; i < mass2.Length; i++)
{
    mass2[i] = mass[i];
}
mass2[2] = 99;

Print(mass2);

int[] mass3 = mass; // 1 это НЕ копирование массива, а скорее "приравнивание" mass3 к mass, и при изменении mass3, меняется и mass оригинальный.
mass3[3] = 11;
Print(mass3);

Print(mass);
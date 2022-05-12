// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2 // -1, -7, 567, 89, 223 -> 3

Console.WriteLine("Укажите количество чисел, которое вы будете вводить: ");
int M = int.Parse(Console.ReadLine());
int[] array = new int[M];
Console.WriteLine("Введите числа: ");

for (int i = 0; i < M; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}

int count = 0;

for (int i = 0; i < M; i++)
{
    if (array[i] > 0) count++;
}

if (count == 0) Console.WriteLine($"Среди введённых {M} чисел нет чисел больше 0.");
else Console.WriteLine($"Из введённых {M} чисел {count} больше 0.");
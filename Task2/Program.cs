// Задайте массив на 10 целых чисел.
// Напишите программу, которая определяет
// количество чётных чисел в массиве.

int[] array = new int[10] { -2, 5, 15, -28, 13, 94, -100, 45, 82, -20 };
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        count += 1;
    }
}
Console.WriteLine(count);
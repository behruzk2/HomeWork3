// Задайте массив из вещественных чисел с
// ненулевой дробной частью. Найдите разницу между
// максимальным и минимальным элементов массива.

double[] array = new double[5] { -2, 5, 7.6, 11.6, 55.1 };

double max = array[0];
double min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (max > array[i])
    {
        max = array[i];
    }
    if (min < array[i])
    {
        min = array[i];
    }
}
double diff = max - min;
Console.WriteLine(diff);
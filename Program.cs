int[] array = new int[7];
int i = 0;

while (i < array.Length)
{
    Console.Write("Введите число: ");
    array[i] = int.Parse(Console.ReadLine());
    i++;
}

// Находим меньшее значение массива
int min = array[0];
for (i = 1; i < array.Length; i++)
{
    if (array[i] < min)
    {
        min = array[i];
    }
}

// Находим сумму и среднее значение массива
int sum = 0;
for (i = 0; i < array.Length; i++)
{
    sum += array[i];
}
double average = (double)sum / array.Length;

Console.WriteLine($"Сумма: {sum}");
Console.WriteLine($"Минимум: {min}");
Console.WriteLine($"Среднее: {average}");

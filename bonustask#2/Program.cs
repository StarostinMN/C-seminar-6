/* Дополнительная задача 2 (задача со звёздочкой): Напишите программу, которая задаёт массив из n элементов, которые необходимо заполнить случайными значениями и определить существует ли пара соседних элементов с одинаковыми значениями, при наличии такого элемента заменить его на уникакальное значение.
[1,2,3,3] -> [1,2,3,4] */
Console.Clear();
Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное допустимое значение в массиве");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное допустимое значение в массиве");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(size, min, max);
Console.WriteLine($"Исходный массив: [{string.Join(",", array)}]");

int[] FIXarray = FixArray(array);
Console.WriteLine($"Исправленный массив: [{string.Join(",", FIXarray)}]");

int[] FillArray(int sizeArray, int minValue, int maxValue)
{
    Random random = new Random();
    int[] resultArray = new int[sizeArray];
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = random.Next(minValue, maxValue + 1);
    }
    return resultArray;
}

int[] FixArray(int[] InputArray)
{
    int[] FixArray = new int[InputArray.Length];
    for (int i = 0; i < InputArray.Length; i++)
    {
        FixArray[i] = InputArray[i];
    }
    for (int i = 0; i < FixArray.Length - 1; i++)
    {
        if (FixArray[i + 1] == FixArray[i]) { FixArray[i + 1] = FixArray[i + 1] + 1; }
    }
    return FixArray;
}
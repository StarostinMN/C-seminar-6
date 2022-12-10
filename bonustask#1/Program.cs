/* Дополнительная задача (задача со звёздочкой): Напишите программу, которая задаёт массив из n элементов, которые необходимо заполнить случайными значениями и сдвинуть элементы массива влево, или вправо на 1 позицию.
[8, 5, 1, 7, 0] - [5, 1, 7, 0, 8] - сдвиг влево
[8, 5, 1, 7, 0] - [0, 8, 5, 1, 7] - сдвиг вправо */
Console.Clear();
Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное допустимое значение в массиве");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное допустимое значение в массиве");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(size, min, max);
Console.WriteLine($"Исходный массив: [{string.Join(",", array)}]");

int[] LEFTSHIFTarray = LeftShiftArray(array);
Console.WriteLine($"Массив со сдвигом влево: [{string.Join(",", LEFTSHIFTarray)}]");

int[] RIGHTSHIFTarray = RightShiftArray(array);
Console.WriteLine($"Массив со сдвигом вправо: [{string.Join(",", RIGHTSHIFTarray)}]");

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

int[] LeftShiftArray(int[] InputArray)
{
    int[] LeftShiftArray = new int[InputArray.Length];
    for (int i = 0; i < InputArray.Length - 1; i++)
    {
        LeftShiftArray[i] = InputArray[i + 1];
    }
    LeftShiftArray[InputArray.Length - 1] = InputArray[0];
    return LeftShiftArray;
}

int[] RightShiftArray(int[] InputArray)
{
    int[] RightShiftArray = new int[InputArray.Length];
    for (int i = 0; i < InputArray.Length - 1; i++)
    {
        RightShiftArray[i+1] = InputArray[i];
    }
    RightShiftArray[0] = InputArray[InputArray.Length - 1];
    return RightShiftArray;
}


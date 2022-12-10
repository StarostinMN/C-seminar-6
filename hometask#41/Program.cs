/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2;
1, -7, 567, 89, 223-> 3 */
Console.Clear();

int[] FillArrayFromKeybord()
{
    Console.Write("Введите требуемое количество элементов массива: ");
    int M = Convert.ToInt32(Console.ReadLine());
    int[] InputArrayFromKeybord = new int[M];
    for (int index = 0; index < M; index++)
    {
        Console.Write($"Введите {index + 1}-е число: ");
        InputArrayFromKeybord[index] = Convert.ToInt32(Console.ReadLine());
    }
    return InputArrayFromKeybord;
}

int CountPositiveNumbersOfArray(int[] inputArray)
{
    int CountPositiveNumbers = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i]>0) CountPositiveNumbers++;
    }
    return CountPositiveNumbers;
}

Console.WriteLine($"Количество введенных положительных чисел: {string.Join(",", CountPositiveNumbersOfArray(FillArrayFromKeybord()))}");

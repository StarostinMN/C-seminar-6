// Задача 39:  Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)

//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

Console.Clear();

Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное допустимое значение в массиве");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное допустимое значение в массиве");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(size,min,max);

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

int[] ReverseArray(int[] inputArray){
    int[] reverseArray = new int[inputArray.Length];
    for(int i = 0; i < inputArray.Length; i++){
      reverseArray[i] = inputArray[inputArray.Length - 1 - i];
    }
    return reverseArray;
}

Console.WriteLine($"Исходный массив: {string.Join(",",array)}");
Console.WriteLine($"Результатирующий массив: {string.Join(",",ReverseArray(array))}");
Console.WriteLine($"Результатирующий массив, вариант 2: {string.Join(",",array.Reverse())}");
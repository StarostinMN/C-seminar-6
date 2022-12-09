/* Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */
Console.Clear();
Console.WriteLine("Введите количество выводимых чисел Фибоначчи:");
int N = Convert.ToInt32(Console.ReadLine());

int[] FibonacciNumberArray = ComputeFibonacciNumber(N);

Console.WriteLine($"Последовательность {N} чисел Фибоначчи: {string.Join(",", FibonacciNumberArray)}");

int[] ComputeFibonacciNumber(int n)
{
    int[] FibonacciArray = new int[n];
    FibonacciArray[0] = 0;
    FibonacciArray[1] = 1;
    for (int i = 0; i < n - 2; i++)
    {
        FibonacciArray[i + 2] = FibonacciArray[i + 1] + FibonacciArray[i];
    }
    return FibonacciArray;
}

/* 
Вариант группы (по сути то же самое)
Console.Clear();
Console.WriteLine("Введите количество чисел Фибоначчи");
int n = Convert.ToInt32(Console.ReadLine());

int[] GetFibonacci(int size)
{
int[] result = new int[size];
result[0]=0;
result[1]=1;
for (int i=2;i<size;i++)
{
result[i] =result[i-1]+result[i-2];
}
return result;
}

Console.WriteLine($"Последовательность Фибоначчи: {string.Join(" ", GetFibonacci(n))}");
//int PrintFibonacci (int[] arr1)
//Console.Write($"{result} "); */
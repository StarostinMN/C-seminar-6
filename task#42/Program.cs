/* Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101, 3  -> 11, 2  -> 10 */
Console.Clear();
Console.WriteLine("Введите десятичное число: ");
int DecimalNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Двоичное число: {string.Join("", ConvertDecimalToBinary(DecimalNumber))}");

int[] ConvertDecimalToBinary(int decimalNumber)
{
    int size = 0, quotientDecimalNumber = DecimalNumber;
    for (int i = 0; quotientDecimalNumber >= 1; i++)
    {
        quotientDecimalNumber = quotientDecimalNumber / 2;
        size++;
    }
    int[] binaryNumber = new int[size];
    for (int index = 0; index < size; index++)
    {
        binaryNumber[size - 1 - index] = decimalNumber % 2;
        decimalNumber = decimalNumber / 2;
    }
    return binaryNumber;
}

/* Вариант группы:
Console.Clear();
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(DivideNumber(num));

string DivideNumber(int a)
{
    //int[] array = new int[]
    string b = String.Empty;
   
    while (a>0)
    {
        b=Convert.ToString(a%2)+b;
        a = a/2;
    }
return b;
}
Console.WriteLine(Convert.ToString(num,2)); */
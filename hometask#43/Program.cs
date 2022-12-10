/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */
Console.Clear();

double[] k = new double[2];
double[] b = new double[2];

for (int i = 0; i < 2; i++)
{
    Console.Write($"Введите угловой коэффициент k{i + 1} {i + 1}-й прямой: ");
    k[i] = Convert.ToDouble(Console.ReadLine());
    Console.Write($"Введите константу b{i + 1} {i + 1}-й прямой: ");
    b[i] = Convert.ToDouble(Console.ReadLine());
}

GetPointOfIntersectionOfStraightLines(k, b);

(double, double) GetPointOfIntersectionOfStraightLines(double[] ArrayK, double[] ArrayB)
{
    double x0 = 0;
    double y0 = 0;
    if (ArrayK[0] == ArrayK[1] && ArrayB[0] == ArrayB[1])
    {
        Console.WriteLine("Прямые совпадают (бесконечное число точек пересечения)");
    }
    else if (ArrayK[0] == ArrayK[1] && ArrayB[0] != ArrayB[1])
    {
        Console.WriteLine("Прямые парараллельны (не пересекаются)");
    }
    else
    {
        x0 = Math.Round((ArrayB[1] - ArrayB[0]) / (ArrayK[0] - ArrayK[1]), 4);
        y0 = Math.Round(ArrayK[0] * x0 + ArrayB[0], 4);
        Console.WriteLine($"Прямые пересекаются в точке с координатами ({x0}; {y0})");
    }
    return (x0, y0);
}
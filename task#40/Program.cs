/* Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
	Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон. */
Console.Clear();
Console.Write("Введите длину стороны A: ");
double A = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите длину стороны B: ");
double B = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите длину стороны C: ");
double C = Convert.ToDouble(Console.ReadLine());

if (IsTriangulumExist(A, B, C) == true)
{
    Console.WriteLine($"Треугольник со сторонами {A}, {B}, {C} существует.");
}
else
{
    Console.WriteLine($"Треугольник со сторонами {A}, {B}, {C} не существует.");
}

bool IsTriangulumExist(double a, double b, double c)
{
    bool TriangulumExist = (a < (b + c)) && (b < (a + c)) && (c < (a + b));
    return TriangulumExist;
}
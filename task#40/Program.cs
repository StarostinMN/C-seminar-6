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

/* Вариант Александра Ковтуна. Интересен применением тернарной операции 

Console.Clear();

Console.WriteLine("Введите размер первой стороны треугольника");
int oneNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер второй стороны треугольника");
int twoNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер третьей стороны треугольника");
int treeNum = Convert.ToInt32(Console.ReadLine());

bool getTriangle (int one, int two, int tree)
{
    if  (one + two > tree && two + tree > one && one + tree > two)
    {
        return true;
    }
    else return false;

}

Console.WriteLine(getTriangle(oneNum, twoNum, treeNum) ? "Такой треугольник может существовать" : "Такой треугольник не может существовать"); */
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
try
{
Console.Write("Введите число k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
double x = 0;
double y = 0;

if (k1 == k2 && b1 == b2) Console.WriteLine("Прямые совпадают.");
else if (k1 == k2) Console.WriteLine("Прямые параллельны. Точек пересечения у данных прямых нет.");
else
{
    Console.WriteLine("Прямые пересекаются.");
    Intersection(x,y);
}

void Intersection (double x, double y)
{
    x = (b2 - b1) / (k1 - k2);
    y = (k1 * (b2 - b1)) / (k1 - k2) + b1;
    Console.WriteLine($"Точка пересечения уравнений y = {k1}*x + {b1} и y = {k2}*x + {b2} является ({x}; {y}).");
}

}

catch
{
    Console.WriteLine("Ошибка! Введите число.");
}
Console.Clear();
double k1 = InputNumber("Введите k1: ");
double b1 = InputNumber("Введите b1: ");
double k2 = InputNumber("Введите k2: ");
double b2 = InputNumber("Введите b2: ");
double x = FindX(b1, b2, k1, k2);
double y = FindY(b1, k1, x);
if (b1 == b2 && k1 == k2) Console.WriteLine($"Прямые параллельны");
else Console.WriteLine($"Пересечение в точке: ({x};{y})");

static double InputNumber(string message)
{
    try
    {
        Console.Write(message);
        return (double.Parse(Console.ReadLine() ?? ""));
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return 0;
    }
}

double FindX(double b1, double b2, double k1, double k2)
{
    x = -(b1 - b2) / (k1 - k2);
    x = Math.Round(x, 3);
    return x;
}

double FindY(double b1, double k1, double x)
{
    y = k1 * x + b1;
    y = Math.Round(y, 3);
    return y;
}




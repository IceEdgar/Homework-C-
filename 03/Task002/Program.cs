Console.Clear();
int x1 = InputNumber("Введите первую координату точки один - ");
int y1 = InputNumber("Введите вторую координату точки один - ");
int z1 = InputNumber("Введите третью координату точки один - ");
int x2 = InputNumber("Введите первую координату точки два - ");
int y2 = InputNumber("Введите вторую координату точки два - ");
int z2 = InputNumber("Введите третью координату точки два - ");

Console.WriteLine($"Расстояние между точками один ({x1}, {y1}, {z1}) и два ({x2}, {y2}, {z2}) = {CalculateDistance(x1, y1, z1, x2, y2, z2)}");


static int InputNumber(string message)
{
    try
    {
        Console.Write(message);
        return (int.Parse(Console.ReadLine() ?? ""));
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return 0;
    }
}

static double CalculateDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Pow((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2) * 1.0), 0.5);
}
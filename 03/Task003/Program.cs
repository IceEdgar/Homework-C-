Console.Clear();
int number = InputNumber("Введите число - ");
CubeOfNumbers(number);

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

static void CubeOfNumbers(int number)
{
    int index = 1;
    double kub = 0;

    while (index <= number)
    {
        kub = Math.Pow(index, 3);
        Console.WriteLine($"Число {kub} - является кубом числа {index}");
        index++;
    }
}
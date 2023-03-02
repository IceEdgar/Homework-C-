Console.Clear();
int number = InputNumber("Введите пятизначное число -");
CheckingNumber(number);

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

static void CheckingNumber(int number)
{
    int index = number.ToString().Length;
    int x1 = number / 10000;
    int x2 = (number % 10000) / 1000;
    int x3 = (number % 100) / 10;
    int x4 = number % 10;
    if (index == 5)
    {
        if ((x1 == x4) && (x2 == x3)) Console.Write($"Число {number} -  палиндром");
        else Console.Write($"Число {number} - не палиндром");
    }
    else Console.Write("Вы ввели не пятизначное число");
}
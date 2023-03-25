Console.Clear();
int m = InputNumber("Введите неотрицательное число m - ", "Ошибка ввода данных!");
int n = InputNumber("Введите неотрицательное число n -  ", "Ошибка ввода данных!");
if (m <= 2) Console.Write($"A({m},{n})={AckermanFunction(m, n)}");
else if (m == 3 && n < 12) Console.Write($"A({m},{n})={AckermanFunction(m, n)}");
else if (m == 4 && n < 1) Console.Write($"A({m},{n})={AckermanFunction(m, n)}");
else Console.Write($"A({m},{n}) = Переполнение фунции Аккермана, введите числа меньше");

static int InputNumber(string message, string errormessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect) return userNumber;
        Console.WriteLine(errormessage);
    }
}

int AckermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0 && m > 0) return AckermanFunction(m - 1, 1);
    else return (AckermanFunction(m - 1, AckermanFunction(m, n - 1)));
}
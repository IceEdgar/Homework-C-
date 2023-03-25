Console.Clear();
int m = InputNumber("Введите натуральное неотрицательное число M -  ", "Ошибка ввода данных!");
int n = InputNumber("Введите натуральное неотрицательное число N -  ", "Ошибка ввода данных!");
if (m <= 0 || n <= 0 || m > n) Console.WriteLine("Неверное число для ввода");
else Console.Write($"Сумма натуральных элементов в промежутке от {m} до {n} => {SumNumbers(m - 1, n)}");


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

int SumNumbers(int m, int n)
{
    int result = m;
    if (m == n) return 0;
    else
    {
        m++;
        result = m + SumNumbers(m, n);
        return result;
    }
}
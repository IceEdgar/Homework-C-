Console.Clear();
int num = InputLengthMassiv("Введите длинну массива - ", "Ошибка ввода данных!");
int[] array = GetArray(num);
Console.WriteLine($"[{String.Join(", ", array)}]");
int NumberEvenNumbers = SumNumbersNegPos(array, num);
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях = {NumberEvenNumbers}");

static int InputLengthMassiv(string message, string errormessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errormessage);
    }
}

int[] GetArray(int size)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(-99, 99);
    }
    return res;
}

int SumNumbersNegPos(int[] array, int length)
{
    int sum = 0;
    for (int element = 0; element < length; element++)
    {
        if ((element % 2) == 0) sum = sum + array[element];
    }
    return sum;
}

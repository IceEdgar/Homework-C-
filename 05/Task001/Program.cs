Console.Clear();
int num = InputLengthMassiv("Введите длинну массива - ", "Ошибка ввода данных!");
int[] array = GetArray(num);
Console.WriteLine($"[{String.Join(", ", array)}]");
int NumberEvenNumbers = EvenNumbers(array);
Console.WriteLine($"Колличество положительных цыфр в массиве = {NumberEvenNumbers}");

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
        res[i] = new Random().Next(100, 999);
    }
    return res;
}

int EvenNumbers(int[] array)
{
    int evenNums = 0;
    foreach (int element in array)
    {
        if ((element % 2) == 0) evenNums++;
    }
    return evenNums;
}

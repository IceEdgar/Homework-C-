//input
int num = InputNumber("Введите не отрицательное число ", "Ошибка ввода данных!");

//Logic
int sumNambers = GetSumNumbers(num);

//Output
Console.WriteLine($"{num} -> {sumNambers}");


int GetSumNumbers(int number)
{
    int itog = 0;
    if (number == 0)
        return 0;

    while (number > 0)
    {
        itog = itog + (number % 10);
        number = number / 10;
    }

    return itog;
}
static int InputNumber(string message, string errormessage)
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
//input
int num1 = InputNumber("Введите не отрицательное число ", "Ошибка ввода данных!");
int num2 = InputNumber("Введите не отрицательное число ", "Ошибка ввода данных!");

//Logic
int sumNambers = GetSumNumbers(num1,num2);

//Output
Console.WriteLine($"{num1} {num2} -> {sumNambers}");


int GetSumNumbers(int number1, int number2)
{
    int itog = number1;
    int index = 1;
    if (number1 == 0)
        return 0;

    while (number2 > index)
    {
        itog = itog * number1;
        index++;
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
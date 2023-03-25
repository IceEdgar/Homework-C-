Console.Clear();
int number = InputNumber("Введите не отрицательное число - ", "Ошибка ввода данных!");
if (number <= 0) Console.WriteLine("Неверное число для ввода");
else Console.WriteLine($"{number} => {NaturalToLow(number)}");


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

string NaturalToLow(int number)
{
    if (number == 1)
    {
        return number.ToString();
    }
    else return number + ", " + NaturalToLow(number - 1);
}

int ReadNumber() //функция ввода числа
{
    return Convert.ToInt32(Console.ReadLine());
}

int ThirdNumber(int num)//функция поиска третьей цифры
{
    int result = 0;
    while (num > 999)
    {
        num = num / 10;
    }
    result = (num % 10);
    return result;
}


Console.Write("Введите число - ");
int number = ReadNumber();
int index = number.ToString().Length;

if (index < 3) Console.WriteLine("НЕТ ТРЕТЬЕЙ ЦИФРЫ");
else Console.WriteLine($"Третья цифра - {ThirdNumber(number)}");
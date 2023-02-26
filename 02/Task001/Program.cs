int ReadNumber()
{
    return Convert.ToInt32(Console.ReadLine());
}

int SecondNumber(int num)
{
    int result = ((num / 10) % 10);
    return result;
}

Console.Write("Введите трехзначное число - ");
int number = ReadNumber();
int index = number.ToString().Length;

if (index < 3 || index > 3) Console.WriteLine("Это не трехзначное число!!!!");
else Console.WriteLine($"Вторая цифра - {SecondNumber(number)}");

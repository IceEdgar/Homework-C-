Console.Clear();
int rows = InputNumber("Введите количество строк массива ", "Ошибка ввода данных!");
int columns = InputNumber("Введите количество столбцов массива ", "Ошибка ввода данных!");
double[,] array = new double[rows, columns];
FillArray(array);
PrintArray(array);


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

void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " | ");
        }
        Console.WriteLine("");
    }
}
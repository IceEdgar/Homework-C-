Console.Clear();
int rows = InputNumber("Введите количество строк массива ", "Ошибка ввода данных!");
int columns = InputNumber("Введите количество столбцов массива ", "Ошибка ввода данных!");
int[,] array = new int[rows, columns];
FillArray(array);
PrintArray(array);
ArithmeticMean(array);


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

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToInt32(new Random().Next(1, 10));
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("  " + array[i, j]);
        }
        Console.WriteLine("");
    }
}


void ArithmeticMean(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        Console.WriteLine($"Cреднее арифметическое элементов столбца №{j + 1} = {Math.Round(sum / array.GetLength(0), 2)} ");
    }
}
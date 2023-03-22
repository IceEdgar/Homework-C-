Console.Clear();
Console.WriteLine("Матрицу 1 можно умножить на матрицу 2 только в том случае, если число столбцов матрицы 1 равняется числу строк матрицы 2.");
int rows1 = InputNumber("Введите количество строк первой матрицы ", "Ошибка ввода данных!");
int columns1 = InputNumber("Введите количество столбцов первой матрицы ", "Ошибка ввода данных!");
int[,] array1 = new int[rows1, columns1];
int rows2 = InputNumber("Введите количество строк второй матрицы ", "Ошибка ввода данных!");
int columns2 = InputNumber("Введите количество столбцов второй матрицы ", "Ошибка ввода данных!");
int[,] array2 = new int[rows2, columns2];
FillArray(array1);
PrintArray(array1);
Console.WriteLine();
FillArray(array2);
PrintArray(array2);
Console.WriteLine();
if (columns1 == rows2)
{
    int[,] resultArray = new int[rows1, columns2];
    ProductOfMatrix(array1, array2, resultArray);
    Console.WriteLine("Произведение двух матриц = ");
    PrintArray(resultArray);

}
else Console.WriteLine("Данные матрицы нельзы перемножить, не соблюдено условие");

void ProductOfMatrix(int[,] array1, int[,] array2, int[,] resultarray)
{
    for (int i = 0; i < resultarray.GetLength(0); i++)
    {
        for (int j = 0; j < resultarray.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                sum += array1[i, k] * array2[k, j];
            }
            resultarray[i, j] = sum;
        }
    }
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
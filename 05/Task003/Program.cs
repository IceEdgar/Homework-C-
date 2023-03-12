Console.Clear();
int num = InputNumber("Введите длинну массива ", "Ошибка ввода данных!");
int[] array = new int[num];
FillArray(array, num);
Console.WriteLine($"[{String.Join(",", array)}]");
int max = FindMaxIndex(array, num);
int min = FindMinIndex(array, num);
int result = max - min;
Console.WriteLine($"Разница между максимальным ({max}) и минимальным ({min}) элементов массива = {result}");



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


void FillArray(int[] collection, int i)
{
    int index = 0;
    while (index < i)
    {
        try
        {
            Console.Write("Введите число массива -");
            array[index] = Convert.ToInt32(Console.ReadLine());
            index++;
        }
        catch (Exception exc)
        {
            Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        }
    }
}


int FindMaxIndex(int[] arrayA, int lengthA)
{
    int max = arrayA[0];
    for (int i = 1; i < lengthA; i++)
    {
        if (arrayA[i] > max) max = arrayA[i];
    }
    return max;
}

int FindMinIndex(int[] arrayB, int lengthB)
{
    int min = arrayB[0];
    for (int i = 1; i < lengthB; i++)
    {
        if (arrayB[i] < min) min = arrayB[i];
    }
    return min;
}
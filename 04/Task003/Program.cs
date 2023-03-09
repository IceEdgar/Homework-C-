int[] array = new int[8];
FillArray(array);
Console.WriteLine($"[{String.Join(",", array)}]");



void FillArray(int[] collection)
{
    int index = 0;
    while (index < 8)
    {
        
        try
        {
            Console.Write("Введите число -");
            array [index]=Convert.ToInt32(Console.ReadLine());
            index++;
        }
        catch (Exception exc)
        {
            Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        }
    }
}


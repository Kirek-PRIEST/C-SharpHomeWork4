int[] arg = { 3, 2, 5, 7, 1, 4, 9, 8 };

void PrintArray(int[] array)
{
    int lenght = array.Length;
    for (int k = 0; k < lenght; k++)
    {
        Console.Write($"{array[k]} ");
    }
    Console.WriteLine();
}
PrintArray(arg);

void NewArrayMin(int[] array)
{
    int lenght = array.Length;
    for (int i = 0; i < lenght; i++)
    {
        int minPos = i;
        for (int j = i + 1; j < lenght; j++)
        {
            if (array[j] < array[minPos])
            {
                minPos = j;

            }

        }

        int temp = array[i];
        array[i] = array[minPos];
        array[minPos] = temp;
        Console.Write($"{array[i]} ");
    }
Console.WriteLine();
}
NewArrayMin(arg);
void NewArrayMax(int[] array)
{
    int lenght = array.Length;
    for (int i = 0; i < lenght; i++)
    {
        int minPos = i;
        for (int j = i + 1; j < lenght; j++)
        {
            if (array[j] > array[minPos])
            {
                minPos = j;

            }

        }

        int temp = array[i];
        array[i] = array[minPos];
        array[minPos] = temp;
        Console.Write($"{array[i]} ");
    }
Console.WriteLine();
}
NewArrayMax(arg);
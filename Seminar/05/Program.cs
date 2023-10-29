int[] CreateMassive(int length) //Метод для создания массива определённой длины
{
    int[] array = new int[length];//создаём массив заданной длинны
    int i = 0;
    while (i < array.Length) //счётчик менее длины массива
    {
        array[i] = new Random().Next(1, 10); //заполнение поля массива случайным числом
        i++;
    }
    return array; //возврат массва из функции
}
void printMassive(int[] massive) //метод ля вывода массива
{
    foreach (var item in massive)/*оператор для вывода массива (каждый элемент в массиве massive называется item (в данном случае) )
                                    и для каждого элемента выполняется описаное ниже действие, пока не закончится массив)*/
    {
        Console.Write(item + " ");

    }
    Console.WriteLine();
}

void NewArrayMin(int[] array)
{
    int lenght = array.Length;
    for (int i = 0; i < lenght; i++)
    {
        int locMin = minArray(i, array);
        int temp = array[locMin];
        array[locMin] = array[i];
        array[i] = temp;
    }
    printMassive(array);
}
int minArray(int start, int[] array) // поиск индекса минимума, начиная с элемента start
{
    int mimPos = start;
    for (int i = start; i < array.Length; i++) //
    {
        if (array[i] < array[mimPos])
        {
            mimPos = i;
        }
    }
    return mimPos;
}
int[] massive = CreateMassive(8);
printMassive(massive);
Console.WriteLine();
NewArrayMin(massive);
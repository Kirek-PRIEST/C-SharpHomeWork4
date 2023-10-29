// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

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
}
int[] massive = CreateMassive(8);
printMassive(massive);
Console.WriteLine();
NewArrayMin(massive);
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int ReadIn(string msg)
{
    Console.WriteLine(msg);
    string a = Console.ReadLine();
    return int.Parse(a);
}
int[] CreateMassive(int length) //Метод для создания массива определённой длины
{
    int[] array = new int[length];//создаём массив заданной длинны
    int i = 0;
    while (i < array.Length) //счётчик менее длины массива
    {
        array[i] = new Random().Next(10); //заполнение поля массива случайным числом
        i++;
    }
    return array; //возврат массва из функции
}
void printMassive(int[] massive) //метод ля вывода массива
{
    Console.Write("[");
    int i = 0;
    while (i < massive.Length-1)
    {
        
        Console.Write( + massive[i] + ", ");
        i++;
    }
    Console.Write(massive[i]);
    Console.WriteLine("]");
}

printMassive(CreateMassive(ReadIn("Введите длинну массива")));

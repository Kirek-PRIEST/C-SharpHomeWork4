// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int ReadIn(string msg)
{
    Console.WriteLine(msg);
    string a = Console.ReadLine();
    return int.Parse(a);
}
int first = ReadIn("Введите число 1:");
int second = ReadIn("Введите число 2:");

int Vol(int fir, int sec)
{
    int result = 1;
    for (int i = 0; i < sec; i++)
    {
        result *= fir;
        Console.WriteLine(result);
    }
    return result;
}
bool verif(int second)
{
    if (second < 0)
    {
        Console.WriteLine("Число 2 должно быть больше 0");
    return false;
    }
    return true;
}
if (verif(second))
{
Console.WriteLine(Vol(first, second));
}
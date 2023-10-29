// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120
int ReadIn(string msg)
{
    Console.WriteLine(msg);
    string b = Console.ReadLine();
    return int.Parse(b);
}

int searchFactorial(int incoming)
{
    int result = 1;
    int temp = 1;
    while (incoming > 0)
    {
        result = result * temp;
        temp++;
        incoming--;
    }
    return result;
}

Console.WriteLine(searchFactorial(ReadIn("Введите число")));
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadIn(string msg)
{
    Console.WriteLine(msg);
    string a = Console.ReadLine();
    return int.Parse(a);
}

int Sum(int num)
{
    int temp = num;
    int result = 0;
    for (int i = temp; i > 0; i--)
    {
        result = result + temp%10;
        temp = temp / 10;
    }
    return result;
}
int Pluas(int num)
{
    if (num < 0)
    {
        int result = num * -1;
        return result;
    }
    return num;
}
int chislo = Pluas(ReadIn("Введите число:"));
Console.WriteLine(Sum(chislo));


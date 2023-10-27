// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int ReadIn(string msg)
{
    Console.WriteLine(msg);
    string b = Console.ReadLine();
    return int.Parse(b);
}
int num(int inner)
{
    int a = 0;
    int temp = inner;
   
        while (temp > 0)
        {
            temp = temp / 10;
            a++;
        }
    
return a;
}

Console.WriteLine(num(ReadIn("Введите число")));
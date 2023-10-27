// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int ReadIn(string msg){
    Console.WriteLine(msg);
    string b = Console.ReadLine();
    return int.Parse(b);
}

int sum (int inner)
{
    int result = 0;
    for (int i = 1; i<inner+1; i++)
    {
     result = result+i;
    }
return result;
}

Console.WriteLine(sum(ReadIn("ввдите число:")));
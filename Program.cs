// task 25

int Func_(int x, int y)
{
    int val = x;
    for (int i = 1; i < y; i++)
    {
        val = val * x;
    }
    return val;
}

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение степени");
int degree = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($" {num} в степени {degree} = {Func_(num, degree)}");
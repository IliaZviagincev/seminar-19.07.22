// Задача 25: Напишите цикл, 
// который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int getPow(int x, int y)
{
    int temp = x;
    for (int i = 1; i < y; i++)
    {
        temp = temp * x;
    }
    return temp;
}
Console.Write("Введите число:  ");
int number = int.Parse(Console.ReadLine());
Console.Write("Введите степень возведения:  ");
int stepen = int.Parse(Console.ReadLine());
Console.WriteLine($"\nчисло {number} в степени {stepen} \nбудет: {getPow(number, stepen)} ");
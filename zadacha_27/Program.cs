// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int getSum(int x)
{
    int result = 0;
    int x_temp = x;
    int x_len = 0;
    for (int k = 1; x_temp > 0; k++)
    {
        x_temp /= 10;
        x_len = k;
    }

    int[] temp = new int[x_len];

    for (int i = 0; i < x_len; i++)
    {
        temp[i] = x % 10;
        x /= 10;
        result += temp[i];
    }

    return result;
}

Console.Write("Введите число:   ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма чисел {number} равна {getSum(number)} ");
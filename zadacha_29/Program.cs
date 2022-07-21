// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void arrayPrint(string[] arr)
{
    int[] temp = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        temp[i] = int.Parse(arr[i]);
        Console.Write($"{temp[i]}   ");
    }
}
Console.Write("Введите через пробел числа для заполнения массива: ");
string[] array = Console.ReadLine().Split();
arrayPrint(array);

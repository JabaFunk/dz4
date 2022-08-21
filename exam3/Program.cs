// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Write("Введите размер массива: ");
int lenght = Convert.ToInt32(Console.ReadLine());

int[] RandArray(int len)
{
    int[] arrays = new int [len];
    for (int i = 0; i < arrays.Length; i++)
    {
        arrays[i] = new Random().Next(0,10);
    }
    return arrays;
}

int[] res = RandArray(lenght);

void PrintArray(int[] res1)
{
    Console.Write($"[");
    for (int i = 0; i < res1.Length; i++)
    {
        Console.Write($"{res1[i]} ");
    }
    Console.Write($"]");
}

PrintArray(res);
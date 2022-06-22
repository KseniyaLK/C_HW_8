// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.

// создание массива
int[,] GetArray(int a, int b)
{
    int[,] array = new int[a, b];
    Random rndNum = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rndNum.Next(0, 10);
        }
    }
    return array;
}

// вывод массива на печать
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] arr = GetArray(5, 5);
PrintArray(arr);
Console.WriteLine();



int MaxSumRow(int[,] array)
{
    int result = 0;
    int count = 0;
    int numberMaxRow = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        count++;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
            
        }

        if (sum > result)
        {
            result = sum;
            numberMaxRow = count;
        }
        
    }

    return numberMaxRow;
}

int rez = MaxSumRow(arr);
Console.WriteLine($"Номер строки с максимальной суммой {rez}"); //номер, не индекс

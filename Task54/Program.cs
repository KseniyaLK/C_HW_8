// Задача 54: Задайте двумерный массив. Напишите программу, которая
//упорядочит по убыванию элементы каждой строки двумерного массива.


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

int[,] arr = GetArray(5, 7);
PrintArray(arr);
Console.WriteLine();



int[,] SortingArray(int[,] array)
{
    int a = array.GetLength(0);
    int b = array.GetLength(1);

    int[,] tempArray = new int[a, b];
    for (int i = 0; i < a; i++)
    {
        for (int k = 0; k < b; k++)
        {
            for (int j = 0; j < b - 1; j++)
            {
                if (array[i, j + 1] > array[i, j])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = temp;
                    tempArray[i, j] = array[i, j + 1];
                }
                else tempArray[i, j] = array[i, j];
            }    
        }
    }
    return tempArray;
}

int[,] arrSort = SortingArray(arr);
PrintArray(arr);


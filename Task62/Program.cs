//Задача 62: Заполните спирально массив 4 на 4.


// создание массива
int[,] GetArray(int a, int b)
{

int[,] array = new int[a, b];

int number = 1;
int i = 0;
int j = 0;

while (number <= (a * b))
{
  array[i, j] = number;
  number++;
    if (i <= j + 1 && i + j < array.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= array.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > array.GetLength(1) - 1)
    j--;
  else
    i--;
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
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int[,] arr = GetArray(4, 4);

PrintArray(arr);
Console.WriteLine();

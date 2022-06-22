// Задача 60: Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.

// создание массива
int[,,] GetArray(int a, int b, int c)
{
    int[,,] array = new int[a, b, c];
    Random rndNum = new Random();
    int count = 0;
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            for (int k = 0; k < c; k++)
            {
                int num = rndNum.Next(10, 20);
                for (int n = 0; n < a; n++)
                {
                    for (int l = 0; l < b; l++)
                    {
                        for (int m = 0; m < c; m++)
                            if (num != array[n, l, m])
                            {
                                array[n, l, m] = num;
                                num++;
                            }
                            else if (count == a * b * c)
                            {
                                count = 0;
                            }
                            else
                            {
                                count = 0;
                                k = k - 1;
                                continue;
                            }
                    }
                }

            }

        }

    }
    return array;
}


// вывод массива на печать
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}  [{i},{j},{k}]   ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}


int[,,] rez = GetArray(3, 3, 3);
PrintArray(rez);

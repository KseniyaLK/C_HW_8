// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.

// условием перемножения двух матриц является то, чтобы кол-во столбцов 
// в первой матрице было равно кол-ву строк второй матрицы
// каждый эл-т результ.матр = сумма элеметов i-ой строки 1 матрицы на сумму эл-в j-ого столбца 2 матрицы 

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

int[,] arr1 = GetArray(3, 3);
int[,] arr2 = GetArray(3, 3);

PrintArray(arr1);
Console.WriteLine();
PrintArray(arr2);
Console.WriteLine();





int[,] arrRez = new int[3, 3];

void ProductArrays (int [,] array1, int [,] array2, int [,] arrayRez )
{

    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                sum += array1[i, k] * array2[k, j];
            }
              arrayRez[i, j] = sum;
        }
    }


}

ProductArrays(arr1, arr2, arrRez);
PrintArray(arrRez);
Console.WriteLine();
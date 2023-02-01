// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] CreateArrayRndDoudle(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round((rnd.NextDouble() * (max - min) + min), 2);
    }
    return array;
}


void PrintArrayDouble(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}


double GetMin(double[] arrayNumb)
{
    double result = arrayNumb[0];
    for (int i = 0; i < arrayNumb.Length; i++)
    {
        double currentItem = arrayNumb[i];
        if (currentItem < result)
        {
            result = currentItem;
        }
    }
    return result;
}


double GetMax(double[] arrayNumb)
{
    double result = arrayNumb[0];
    for (int i = 0; i < arrayNumb.Length; i++)
    {
        double currentItem = arrayNumb[i];
        if (currentItem > result)
        {
            result = currentItem;
        }
    }
    return result;
}


double[] arrayNumb = CreateArrayRndDoudle(10, 0, 100);
PrintArrayDouble(arrayNumb);
double min = GetMin(arrayNumb);
double max = GetMax(arrayNumb);
Console.WriteLine(" -> " + Math.Round((max - min), 2));

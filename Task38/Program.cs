// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

// Массив вещественных чисел
double[] CreateArrayRndDoudle(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.NextDouble() *(max - min) + min;
    }
    return array;
}
 
//  Массив вывода вещественных чисел
void PrintArreyDouble (double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
       if(i < array.Length - 1) Console.Write($"{array[i]}, ");
       else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}
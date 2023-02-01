// Задача 32: 
// Напишите программу замена элементов массива: 
// положительные элементы замените на 
// соответствующие отрицательные, и наоборот.

// [-4, -8, 8, 2] -> [4, 8, -8, -2]

//  Метод создания массива
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

// Метод вывода массива
void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
       if(i < array.Length - 1) Console.Write($"{array[i]}, ");
       else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

// Инверсия массива
void InverseArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = -arr[i];
    }
}

// Программа
int[] arrayNumb = CreateArrayRndInt(10, -10, 10);
PrintArray(arrayNumb);
InverseArray(arrayNumb);
PrintArray(arrayNumb);
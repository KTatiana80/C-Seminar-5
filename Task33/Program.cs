// Задача 33: 
// Задайте массив. 
// Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да,

//  Метод создания массива
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arrayRnd = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arrayRnd[i] = rnd.Next(min, max + 1);
    }
    return arrayRnd;
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

// Метод поиска числа в массиве
bool FindNumber(int[] array, int find)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == find)
        {
            return true;
        }
    }
    return false;
}

// Создание массива, ввод числа пользователем, вызов функции.
Console.WriteLine("Укажите длину массива и число для поиска:");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] arrayNumb = CreateArrayRndInt(sizeArray, -9, 9);
PrintArray(arrayNumb);

Console.WriteLine("Укажите число для поиска:");
int numberToFind = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(FindNumber(arrayNumb, numberToFind) ? "Да" : "Нет");

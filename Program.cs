// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] CreateArrayRndInt(int size) // Метод создания массива
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1} значение массива:");
        array[i] = Console.ReadLine();
    }
    return array;
}
void PrintArray(string[] array) // Метод вывода массива
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write(array[i]);
    }
    Console.Write("]");
    Console.WriteLine();
}
string[] ArrayStrings3Characters(string[] array) // Метод создания массива из строк, содержащих не более 3 символов включительно
{
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array[size] = array[i];
            size++;
        }
    }
    Array.Resize(ref array, size);
    return array;
}

Console.WriteLine("Введите размер массива (целое положительное число):");
int n = Convert.ToInt32(Console.ReadLine());

string[] arr = CreateArrayRndInt(n);
Console.WriteLine("Исходный массив:");
PrintArray(arr);

string[] arr3 = ArrayStrings3Characters(arr);
Console.WriteLine("Преобразованный массив:");
PrintArray(arr3);

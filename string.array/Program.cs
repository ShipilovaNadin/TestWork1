// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальным массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.


Console.WriteLine("Введите строки для включения в первоначальный массив через пробел");
string text = Console.ReadLine();
string[] Array = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
string[] result = new string[Array.Length];

void FullResult(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= 3) arr2[count] = arr1[i];
        count++;
    }

}
void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ", 4);
    }
    Console.WriteLine();
}

FullResult(Array, result);
Console.WriteLine("Mассив из строк, длина которых меньше либо равна 3 символа: ");
PrintArray(result);

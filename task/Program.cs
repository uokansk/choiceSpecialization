//////////////////////////
// Написать программу, которая из имеющегося массива строк формирует 
// массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать 
// на старте выполнения алгоритма.
///////////////////////////

string[] givArray = { "1234", "1567", "-2", "computer science" };
string[] shortArray = new string[givArray.Length];
int maxElement = 3;

// метод формирования нового массива
string[] ShortElementArray(string[] givArray, string[] shortArray)
{
    int count = 0;
    for (int i = 0; i < givArray.Length; i++)
    {
        if (givArray[i].Length <= maxElement)
        {
            shortArray[count] = givArray[i];
            count++;
        }
    }
    Array.Resize(ref shortArray, count);
    return shortArray;
}

// метод вывода результата
void PrintArray(string[] array)
{
    if (array.Length == 0)
    {
        Console.Write("[]");
    }
    else
    {
        Console.Write("[");
        for (int i = 0; i < array.Length - 1; i++)
        {
            Console.Write($"'{array[i]}', ");
        }
        Console.Write($"'{array[array.Length - 1]}'");
        Console.Write("]");
    }
}

string[] Arr = ShortElementArray(givArray, shortArray);
PrintArray(Arr);
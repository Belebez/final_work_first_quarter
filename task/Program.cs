// Написать программу, которая из имеющего массива строк формирует массив из строк, длина которых
// меньше либо равно 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. 


int numElem = new Random().Next(2, 6);

string[] array = GetArray(numElem);
Console.WriteLine($"Полученный массив -- [{String.Join(" ", array)}]");

string[] GetArray(int num)  // функция заполнения массива
{
    string[] result = new string[num];
    Console.WriteLine($"Массив состоит из {num} элементов: ");
    Console.WriteLine("Заполните массив любыв видом данных(число, строка и т.д): ");
    
    for (int i = 0; i < result.Length; i++)
    {
       result[i] = Console.ReadLine()!;
    }
    return result;
}
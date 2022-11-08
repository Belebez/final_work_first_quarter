// Написать программу, которая из имеющего массива строк формирует массив из строк, длина которых
// меньше либо равно 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. 


int numElem = new Random().Next(2, 6);

string[] array = GetArray(numElem);
Console.WriteLine($"Полученный массив -- [{String.Join(" ", array)}]");
string[] array1 = arrSetLenElem(array);
Console.WriteLine($"Преобразованный массив -- [{String.Join(" ", array1)}]");

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

string[] arrSetLenElem(string[] array)  // функция принимает массив и выдаёт новый массив с элементами, которые равны или меньше 3 символов.
{   
    var resultList = array.ToList();
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i].Length > 3)
       {
            resultList.Remove(array[i]);
       }
    }
    var result = resultList.ToArray();  

    return result;
}

// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.


string[] GetArrayStringConsole (string inConsolSymbol)
{
    string[] arraySymbol = new string[inConsolSymbol.Length];
    arraySymbol = inConsolSymbol.Split(",");
    return arraySymbol;
}
string[] GetArrayThreeSymbol (string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        string symbol = array[i];
        if (symbol.Length <= 3)
        {
            count++;
        }
    }
    string[] arrayThreeSymbol = new string[count];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        string symbol = array[i];
        if (symbol.Length <= 3)
        {
            arrayThreeSymbol[j] = symbol;
            j++;
        }
    }
    return arrayThreeSymbol;
}
void Print (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}
Console.Write("Введите набор символов через знак (,) - ");
string inStringSymbol = Console.ReadLine();
string[] arraySymbol = GetArrayStringConsole(inStringSymbol);
Console.WriteLine();
Console.Write("Введенные символы длинной меньше либо равны 3 - ");
Print(GetArrayThreeSymbol(arraySymbol));
Console.WriteLine();
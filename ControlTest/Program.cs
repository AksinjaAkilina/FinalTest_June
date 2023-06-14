
int size = ReadInt("Введите количество элементов массива: ");
string [] array = new string [size];
System.Console.Write($"[{string.Join(", ", FillArray(size))}]");


string [] FillArray (int m)
{
    string [] arr = new string [m];
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.WriteLine("Введите значение элемента массива: ");
        arr[i] = Console.ReadLine()!;
    }
    return arr;
}


int ReadInt(string argument)
{
    Console.Write(argument);
    int i;
    while (!int.TryParse(Console.ReadLine(), out i))
    {
        System.Console.WriteLine("Это не число!");
        Console.Write(argument);
    }
    return i;
}
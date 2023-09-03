int elements = 5;
string [] startingArray = CreateArray(elements);
string[] resultArray = new string [0];
foreach (var item in startingArray)
{
    if (item.Length <= 3)
    {
    Array.Resize(ref resultArray, resultArray.Length + 1);
    resultArray [resultArray.Length-1] = item;
    }
}
Console.WriteLine($"[{String.Join(", ", startingArray.Select(s => $"\"{s}\""))}]");
Console.WriteLine($"[{String.Join(", ", resultArray.Select(s => $"\"{s}\""))}]");




string[] CreateArray(int m)
{
    string [] array = new string[m];
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine("Введите значение элемента массива: ");
        array[i] = Console.ReadLine()!;
    }
    return array;
}
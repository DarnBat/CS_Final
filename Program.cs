int GetOutputLength(string[] input)
{
    int x = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= 3) x++;
    }
    return x;
}
string[] CompileOutput(string[] input)
{
    string[] output = new string[GetOutputLength(input)];
    int j = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= 3)
        {
            output[j] = input[i];
            j++;
        }
    }
    return output;
}
Console.Clear();
Console.WriteLine("Введите элементы массива через пробел");
string[] input = Console.ReadLine().Split(' ');
Console.WriteLine($"[{String.Join(' ', CompileOutput(input))}]");
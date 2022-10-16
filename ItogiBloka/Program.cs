string[] Promt(string message)
{
    System.Console.WriteLine(message);
    string[] result = Console.ReadLine().Split(" ");
    return result;
}

int n = 3;

string[] GetSNewArray(string[] array)
{
    int length = array.Length;
    string[] result = new string[length];
    int count = 0;

    for (int i = 0; i < length; i++)
    {
        if (array[i].Length <= n)
        {
            result[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref result, count);

    return result;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}
string[] array = Promt("Введите значения через пробел  ");
string[] newArray = GetSNewArray(array);
PrintArray(newArray);
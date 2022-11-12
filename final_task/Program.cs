int size = 5;
int number = 3;
string [] arrayFirst = new string [size];
Console.WriteLine($"Введите {size} элементов массива");
// FillArray (arrayFirst);
FillArrayRandom(arrayFirst);
Console.Clear();
PrintArray (arrayFirst);
Console.WriteLine();
Console.WriteLine($"Итоговый массив: ");
if (GetSecondArray(arrayFirst) == 0)
{
    Console.WriteLine("Искомых элементов в массиве нет");
}
else
{
    string[] arraySecond = TransferElements(arrayFirst);
    PrintArray (arraySecond);
}

void FillArrayRandom(string[] arr)
{
    Random sign = new Random();
    string AllSign = "'!\"#$%&\'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ^_`abcdefghijklmnopqrstuvwxyz{|}~'";
    for (int i = 0; i < size; i++)
    {
        int randSize = sign.Next(1, 6);
        for (int j = 0; j < randSize; j++)
        {
            arr[i] += AllSign[sign.Next(0, AllSign.Length)];
        }
    }
}

void FillArray (string[] arr)
{
    for (int i = 0; i < size; i++)
    {
        arr[i] = Console.ReadLine();
    }
}

int GetSecondArray (string[] arr)
{
    int sizeSecond = 0;
    for (int i = 0; i < size; i++)
    {
        if (arr[i].Length <= number)
        {
            sizeSecond++;
        }
    }
    return sizeSecond;
}

string[] TransferElements(string[] arr)
{
    string[] arraySecond = new string[GetSecondArray(arrayFirst)];
    for (int i = 0, j = 0; i < size; i++)
    {
        if (arr[i].Length <= number)
        {
            arraySecond[j] = arr[i];
            j++;
        }
    }
    return arraySecond;
}

void PrintArray (string[] arr)
{
    int arrLength = arr.Length;
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.Write("]");
}

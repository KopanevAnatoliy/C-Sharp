void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] printableArray)
{
    int count = printableArray.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(printableArray[position] + " ");
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;

    }
    return position;
}

int[] arr = new int[10];

FillArray(arr);
PrintArray(arr);
int pos = IndexOf(arr, 3);
Console.WriteLine();
Console.WriteLine(pos);
string[] CreateArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input element {i + 1}: ");
        array[i] = Convert.ToString(Console.ReadLine());
    }
    return array;
}

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " | ");
    }
}

int CountElements(string[] massive, int elementSize)
{
    int count = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i].Length <= elementSize)
            count++;
    }
    return count;
}

void ModifyMassive(string[] massive, int elementSize)
{
    int newSize = 0;
    for (int index = 0; index < massive.Length; index++)
    {
        if (massive[index].Length <= elementSize)
            newSize++;
    }

    string[] newMassive = new string[newSize];
    int i = 0;
    int j = 0;

    while (j < newSize)
    {
        while (i < massive.Length)
        {
            if (massive[i].Length <= elementSize)
            {
                newMassive[j] = massive[i];
                j++;
            }
            i++;
        }
    }
    ShowArray(newMassive);
}

Console.Clear();
Console.WriteLine("Enter size of the massive: ");
int arraySize = int.Parse(Console.ReadLine());
string [] myArray = CreateArray(arraySize);
Console.WriteLine();
ModifyMassive(myArray, 3);

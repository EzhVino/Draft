
// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int [] arr = RandomArray(size);
// ShowArray(arr);
// Console.WriteLine();
// SwapArray(arr);


// void EvenArray(int[,] array)
// {

//     for (int i = 2; i < array.GetLength(0); i++)
//     {
//         for (int j = 2; j < array.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//                 array[i, j] *= array[i, j];
//         }
//     }
// }

// int[,] SwapArray2(int [,] array)
// {
//         int[,] arrayNew = new int[array.GetLength(0), array.GetLength(1)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             arrayNew [j, i] = array [i, j];
//         }
//     }
//     return arrayNew;

// }


string[] CreateArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input element {i + 1} of the massive: ");
        array[i] = Convert.ToString(Console.ReadLine());
    }
    return array;
}

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
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

string [] ModifyMassive(string[] massive, int elementSize)
{
    int newSize = CountElements(massive, elementSize);
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
    return newMassive;
}

Console.Clear();
string [] myArray = CreateArray(4);

ShowArray(ModifyMassive(myArray, 3));



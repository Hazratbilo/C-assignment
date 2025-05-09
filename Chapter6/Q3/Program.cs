char[] array1 = new char[length1];
char[] array2 = new char[length2];

for(int i = 0; i < length1; i++)
{
    Console.Write($"Array1[{i}]: ");
    array1[i] = Convert.ToChar(Console.ReadLine());
}

for (int j = 0; j < array2.Length; j++)
{
    Console.Write($"Array2[{j}]: ");
    array2[j] = Convert.ToChar(Console.ReadLine());
}

int minLength = Math.Min(length1, length2);

for (int i = 0; i < minLength; i++)
{
    if (array1[i] > array2[i])
    {
        result = 1;
    }
    else if(array2[i] > array1[i])
    {
        result = -1;
    }
    else
    {
        if(array1.Length > array2.Length)
        {
            result = 1;
        }
        else if(array2.Length > array1.Length)
        {
            result = -1;
        }
    }
}

if (result != 0)
{
    if (result == 1)
    {
        Console.WriteLine("Array2 comes first in Lexicographic order");
    }
    else if (result == -1)
    {
        Console.WriteLine("Array1 comes first in Lexicographic order");
    }
}
else
{
    Console.WriteLine("Array1 and Array2 are equal");
}
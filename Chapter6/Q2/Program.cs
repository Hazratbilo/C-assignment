Console.Write("Enter the length of the array1: ");
int length1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the length of the array2: ");
int length2 = Convert.ToInt32(Console.ReadLine());

int[] array1 = new int[length1];
int[] array2 = new int[length2];

for(int i = 0; i < length1; i++)
{
    Console.Write($"Array1[{i}]: ");
    array1[i] = Convert.ToInt32(Console.ReadLine());
}

for (int j = 0; j < array2.Length; j++)
{
    Console.Write($"Array2[{j}]: ");
    array2[j] = Convert.ToInt32(Console.ReadLine());
}

int result = 0;

if(array1.Length == array2.Length)
{
    for(int i = 0; i < length1; i++)
    {
        if (array1[i] > array2[i])
        {
            result = 1;
        }
        else if (array1[i] < array2[i])
        {
            result = -1;
        }
    }
}
else
{
    result = -1;
}
if (result != 0)
{
    Console.WriteLine($"Array1 and Array2 are not equal");
}
else
{
    Console.WriteLine($"Array1 and Array2 are equal");
}



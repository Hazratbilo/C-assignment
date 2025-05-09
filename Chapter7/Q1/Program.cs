Console.WriteLine("Enter Rows num");
int rows =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter columns num");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array= new int [rows, columns];
for (int i = 0; i < rows; i++)
 {
    for (int j = 0;j  < columns; j++)
    {
    Console.Write($"array{i},{j}:");
    array [i, j] = Convert.ToInt32(Console.ReadLine());
    }
}
for (int i = 0;i < rows;i++)
{
    for (int j = 0;j  < columns; j++) 
    {
        Console.Write($"{array[i, j]} \t");
    }
}
int sum = 0;
for (int i = 0;i<rows ; i++)
{
    for (int j = 0;j  < columns; j++)
    {
        sum += array [i, j];
    }
}
Console.WriteLine ( $" Sum of all elements {sum}");
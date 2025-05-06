int temp =1;
int sum = 1;
Console.Write("Enter n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter x: ");
    int x = Convert.ToInt32(Console.ReadLine());
    
    for (int i = 1; i <= n; i++)
    {
        temp *= i / x;
        sum += temp;
    }    
    
    Console.WriteLine("Result is {0}", sum);

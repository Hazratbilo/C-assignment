    Console.WriteLine("Enter number");
        int max = int.MinValue;
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter number: ");
            int num =Convert.ToInt32(Console.ReadLine());

            if (num > max)
                max = num;
        }
        Console.WriteLine($"Greatest = {max}");
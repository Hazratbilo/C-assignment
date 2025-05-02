 int sum = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter number: ");
            bool valid = int.TryParse(Console.ReadLine(), out int num);
            if (!valid)
            
                Console.WriteLine("Invalid. Try again:");
                            
            sum += num;
        
        Console.WriteLine("Sum = {sum}");
    }

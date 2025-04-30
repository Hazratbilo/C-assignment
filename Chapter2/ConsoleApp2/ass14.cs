//   Console.Write("Enter a number (1 < n < 100): ");
//         int n = int.Parse(Console.ReadLine());

//         if (n <= 1 || n >= 100)
//         {
//             Console.WriteLine("Number must be greater than 1 and less than 100.");
//             return;
//         }

//         bool isPrime = true;

//         for (int i = 2; i <= Math.Sqrt(n); i++)
//         {
//             if (n % i == 0)
//             {
//                 isPrime = false;
//                 break;
//             }
//         }

//         if (isPrime)
//             Console.WriteLine($"{n} is a prime number.");
//         else
//             Console.WriteLine($"{n} is not a prime number.");
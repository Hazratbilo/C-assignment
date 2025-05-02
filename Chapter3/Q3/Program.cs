using System.Transactions;

Console.WriteLine("Enter first number");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter third number");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

int max = firstNumber;
if (secondNumber > max && secondNumber > thirdNumber)
{
    max = secondNumber;
}
else{
    if (thirdNumber > max && thirdNumber > secondNumber)
    {
        max = thirdNumber;
    }
}
Console.WriteLine($"The greatest number is : {max}");
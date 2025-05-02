Console.WriteLine("Enter first number");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int oldFirst = firstNumber;
if (firstNumber > secondNumber)
{
    firstNumber = secondNumber;
    secondNumber = oldFirst;
}
Console.WriteLine("First number" , firstNumber);
Console.WriteLine("second number" ,secondNumber);

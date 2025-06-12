void CalculateNumbers(int[] numbers, int target)
{
    int count = 0;
    foreach (int number in numbers)
    {
        if (number == target)
        {
            count++;
        }
    }
    Console.WriteLine($"The number {target} appears {count} times in the array.");
}

void SubtractNumbers(int a, int b)
{
    int result = a - b;
    Console.WriteLine($"The result of subtracting {b} from {a} is {result}.");
}
void AddNumbers(int a, int b)
{
    int result = a + b;
    Console.WriteLine($"The result of adding {a} and {b} is {result}.");
}
void MultiplyNumbers(int a, int b)
{
    int result = a * b;
    Console.WriteLine($"The result of multiplying {a} and {b} is {result}.");
}
void DivideNumbers(int a, int b)
{
    if (b == 0)
    {
        Console.WriteLine("Division by zero is not allowed.");
        return;
    }
    double result = (double)a / b;
    Console.WriteLine($"The result of dividing {a} by {b} is {result}.");
}

void ShowMemberInfo(string firstName, string lastName, string role, string email, string phoneNumber)
{
    Console.WriteLine($"First Name: {firstName}");
    Console.WriteLine($"Last Name: {lastName}");
    Console.WriteLine($"Role: {role}");
    Console.WriteLine($"Email: {email}");
    Console.WriteLine($"Phone Number: {phoneNumber}");
}   
void Main()
{
    int[] numbers = { 1, 2, 3, 4, 5, 1, 2, 3 };
    int target = 1;

    CalculateNumbers(numbers, target);
    AddNumbers(5, 3);
    SubtractNumbers(10, 4);
    MultiplyNumbers(6, 7);
    DivideNumbers(20, 4);

    // Example usage of ShowMemberInfo
    ShowMemberInfo("Alice", "Smith", "Developer", "alice.smith@example.com", "123-456-7890");
}

Main();
// This code defines several mathematical operations and a function to count occurrences of a number in an array.

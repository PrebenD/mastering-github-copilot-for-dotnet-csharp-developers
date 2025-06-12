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
// Example usage
int[] numbers = { 1, 2, 3, 4, 5, 3, 2, 1 };
int target = 3;
CalculateNumbers(numbers, target);
// Output: The number 3 appears 2 times in the array.
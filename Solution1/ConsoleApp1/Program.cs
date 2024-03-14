// See https://aka.ms/new-console-template for more information

Console.WriteLine("Initial commit");
Console.WriteLine("Change 1");
Console.WriteLine("Change 2");
Console.WriteLine("Change 3");

int[] arr = { 1, 2, 3, 4 };

Console.WriteLine(AverageCalculator(arr));

static double AverageCalculator(int[] numbers)
{
    int sum = 0;
    foreach (int number in numbers)
    {
        sum += number;
    }

    return (double)sum / numbers.Length;
}
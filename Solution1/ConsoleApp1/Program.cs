
Console.WriteLine("Initial commit");
Console.WriteLine("Change 1");
Console.WriteLine("Change 2");
Console.WriteLine("Change 3");

int[] arr = { 1, 2, 3, 4 };

Console.WriteLine(AverageCalculator(arr));

Console.WriteLine(MaxChanged(arr));

static double AverageCalculator(int[] numbers)
{
    int sum = 0;
    foreach (int number in numbers)
    {
        sum += number;
    }

    return (double)sum / numbers.Length;
}




static double MaxChanged(int[] numbers)
{
    int max = numbers[0];
    foreach (int number in numbers)
        if (max < number)
        {
            max = number;
        }
    return max;
}




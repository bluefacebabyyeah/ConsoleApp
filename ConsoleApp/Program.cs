namespace Names;

public static class Program 
{

    public static void Main(string[] args)
    {
        double[] digits = { 4, 0, 3, 19, 492, -10, -10 };
        Console.WriteLine(Function(digits));
    }

    public static double Function(double[] digits)
    {
        if (digits.Length < 2)
            throw new ArgumentException("Array's Size must be more than 1");

        double minOne = digits[0];
        double minSecond = digits[1];
        if (minOne < minSecond)
        {
            double temp = minOne;
            minOne = minSecond;
            minSecond = temp;
        }

        for (long i = 2; i < digits.Length; i++)
        {
            if (digits[i] < minOne)
            {
                if (digits[i] > minSecond)
                    minOne = digits[i];
                else
                {
                    minOne = minSecond;
                    minSecond = digits[i];
                }

            }

        }
        return minOne + minSecond;
    } 
}
        
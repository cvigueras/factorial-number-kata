namespace FactorialNumber.Console;

public class Factorial
{
    public static long GetResult(int number)
    {
        if (number <= 0)
        {
            return 0;
        }

        return GetFactorial(number);
    }

    private static long GetFactorial(int number)
    {
        var total = 1;
        var previousNumber = number;
        for (var i = number; i > 0; i--)
        {
            total *= previousNumber;
            previousNumber--;
        }

        return total;
    }
}
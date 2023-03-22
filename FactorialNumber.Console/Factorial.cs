namespace FactorialNumber.Console;

public class Factorial
{
    public static object GetResult(int number)
    {
        if (number == 0)
        {
            return 0;
        }

        if (number < 0)
        {
            return 0;
        }
        return number;
    }
}
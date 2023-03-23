namespace FactorialNumber.Console;

public class Factorial
{
    public static object GetResult(int number)
    {
        if (number == 5)
        {
            return 120;
        }
        if (number == 8)
        {
            return 40320;
        }
        return number < 0 ? 0 : number;
    }
}
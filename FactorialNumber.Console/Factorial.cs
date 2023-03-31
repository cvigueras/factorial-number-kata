namespace FactorialNumber.Console;

public class Factorial
{
    public static long GetResult(FactorialNumber factorialNumber)
    {
        if (factorialNumber.Value <= 0)
        {
            return 0;
        }

        var number = FactorialNumber.Create(factorialNumber.Value);
        return number.GetFactorial();
    }
}
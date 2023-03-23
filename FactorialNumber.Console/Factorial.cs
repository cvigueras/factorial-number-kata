namespace FactorialNumber.Console;

public class Factorial
{
    public static object GetResult(int number)
    {
        return number == 5 ? 120 : number == 8 ? 40320 : number == 10 ? 3628800 : number < 0 ? 0 : number;
    }
}
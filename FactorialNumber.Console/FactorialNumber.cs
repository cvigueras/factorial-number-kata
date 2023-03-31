namespace FactorialNumber.Console;

public class FactorialNumber
{
    public int Value { get; }
    private int Total { get; set; }

    private FactorialNumber(int number)
    {
        Value = number;
        Total = 1;
    }

    public static FactorialNumber Create(int number)
    {
        return new FactorialNumber(number);
    }

    public long GetFactorial()
    {
        Total = 1;
        var previousNumber = Value;
        for (var i = Value; i > 0; i--)
        {
            Total *= previousNumber;
            previousNumber--;
        }

        return Total;
    }
}
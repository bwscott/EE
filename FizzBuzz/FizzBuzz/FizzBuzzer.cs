public class FizzBuzzer
{  
    public FizzBuzzer(int startValue, int endValue)
    {
        StartValue = startValue;
        EndValue = endValue;
    }

    private int StartValue;
    private int EndValue;

    public string FizzBuzzify()
    {
        string result = string.Empty;

        for (int i = StartValue; i <= EndValue; i++)
        {
            result += ProcessNumber(i);
        }
        return result.Trim();
    }

    private bool FizzBuzzable(int value)
    {
        return value % 15 == 0;
    }

    private bool Fizzable(int value)
    {
        return value % 3 == 0;
    }

    private bool Buzzable(int value)
    {
        return value % 5 == 0;
    }

    private string ProcessNumber(int i)
    {
        if (FizzBuzzable(i))
        {
            return string.Concat(" " + "fizzbuzz");
        }
        else
        {
            if (Fizzable(i))
            {
                return string.Concat(" ", "fizz");
            }

            if (Buzzable(i))
            {
                return string.Concat(" ", "buzz");
            }

            return string.Concat(" ", i);
        }
    }
}

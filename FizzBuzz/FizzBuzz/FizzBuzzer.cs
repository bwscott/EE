public class FizzBuzzer
{  
    public FizzBuzzer(int startValue, int endValue)
    {
        StartValue = startValue;
        EndValue = endValue;
    }

    private int StartValue;
    private int EndValue;

    private int FizzCount = 0;
    private int BuzzCount = 0;
    private int FizzBuzzCount = 0;
    private int LuckyCount = 0;
    private int IntCount = 0;

    public string FizzBuzzify()
    {
        string result = string.Empty;

        for (int i = StartValue; i <= EndValue; i++)
        {
            result += ProcessNumber(i);
        }

        result += $" fizz:{FizzCount} buzz: {BuzzCount} fizzbuzz: {FizzBuzzCount} lucky: {LuckyCount} integer: {IntCount}";
        return result.Trim();
    }

    private bool ContainsThree(int value)
    {
        return value.ToString().Contains("3");
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
        if (ContainsThree(i))
        {
            LuckyCount++;
            return string.Concat(" ", "lucky");
        }

        if (FizzBuzzable(i))
        {
            FizzBuzzCount++;
            return string.Concat(" " + "fizzbuzz");
        }
        else
        {
            if (Fizzable(i))
            {
                FizzCount++;
                return string.Concat(" ", "fizz");
            }

            if (Buzzable(i))
            {
                BuzzCount++;
                return string.Concat(" ", "buzz");
            }

            IntCount++;
            return string.Concat(" ", i);
        }
    }
}

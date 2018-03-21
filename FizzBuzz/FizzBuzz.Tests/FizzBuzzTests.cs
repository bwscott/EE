using NUnit.Framework;

[TestFixture]
public class FizzBuzzTests
{
    [Test]    
    public void FizzBuzzer_Can_Return_Numbers_Without_Manipulation()
    {
        var startValue = 1;
        var endValue = 2;
       
        var fizzBuzzer = new FizzBuzzer(startValue, endValue);
        var result = fizzBuzzer.FizzBuzzify();

        var expectedResult = "1 2";

        Assert.IsNotNull(result);        
        Assert.AreEqual(expectedResult, result);        
    }

    [Test]
    public void FizzBuzzer_Can_Handle_Fizz()
    {
        var startValue = 6;
        var endValue = 7;

        var fizzBuzzer = new FizzBuzzer(startValue, endValue);
        var result = fizzBuzzer.FizzBuzzify();

        var expectedResult = "fizz 7";

        Assert.IsNotNull(result);        
        Assert.AreEqual(expectedResult, result);
    }
    [Test]
    public void FizzBuzzer_Can_Handle_Buzz()
    {
        var startValue = 5;
        var endValue = 6;

        var fizzBuzzer = new FizzBuzzer(startValue, endValue);
        var result = fizzBuzzer.FizzBuzzify();

        var expectedResult = "buzz fizz";

        Assert.IsNotNull(result);        
        Assert.AreEqual(expectedResult, result);
    }

    [Test]
    public void FizzBuzzer_Can_Handle_Lucky()
    {
        var startValue = 1;
        var endValue = 3;

        var fizzBuzzer = new FizzBuzzer(startValue, endValue);
        var result = fizzBuzzer.FizzBuzzify();

        var expectedResult = "1 2 lucky";

        Assert.IsNotNull(result);
        Assert.AreEqual(expectedResult, result);
    }

    [Test]
    public void FizzBuzzer_Can_Handle_FizzBuzz()
    {
        var startValue = 14;
        var endValue = 16;

        var fizzBuzzer = new FizzBuzzer(startValue, endValue);
        var result = fizzBuzzer.FizzBuzzify();

        var expectedResult = "14 fizzbuzz 16";

        Assert.IsNotNull(result);
        Assert.AreEqual(expectedResult, result);
    }

    [Test]
    public void FizzBuzzer_Can_Handle_All_Variations()
    {
        var startValue = 1;
        var endValue = 20;

        var fizzBuzzer = new FizzBuzzer(startValue, endValue);
        var result = fizzBuzzer.FizzBuzzify();
        
        var expectedResult = "1 2 lucky 4 buzz fizz 7 8 fizz buzz 11 fizz lucky 14 fizzbuzz 16 17 fizz 19 buzz";

        Assert.IsNotNull(result);
        Assert.AreEqual(expectedResult, result);
    }
}

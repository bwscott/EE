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
        var startValue = 1;
        var endValue = 3;

        var fizzBuzzer = new FizzBuzzer(startValue, endValue);
        var result = fizzBuzzer.FizzBuzzify();

        var expectedResult = "1 2 lucky";

        Assert.IsNotNull(result);        
        Assert.AreEqual(expectedResult, result);
    }
    [Test]
    public void FizzBuzzer_Can_Handle_Buzz()
    {
        var startValue = 1;
        var endValue = 5;

        var fizzBuzzer = new FizzBuzzer(startValue, endValue);
        var result = fizzBuzzer.FizzBuzzify();

        var expectedResult = "1 2 lucky 4 buzz";

        Assert.IsNotNull(result);        
        Assert.AreEqual(expectedResult, result);
    }

    [Test]
    public void FizzBuzzer_Can_Handle_Lucky_And_FizzBuzz()
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

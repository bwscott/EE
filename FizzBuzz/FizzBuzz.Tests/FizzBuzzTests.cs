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

        var expectedIntCount = 2;
        var expectedFizzCount = 0;
        var expectedBuzzCount = 0;
        var expectedFizzBuzzCount = 0;
        var expectedLuckyCount = 0;

        var expectedResult = $"1 2 fizz:{expectedFizzCount} buzz: {expectedBuzzCount} fizzbuzz: {expectedFizzBuzzCount} lucky: {expectedLuckyCount} integer: {expectedIntCount}";

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

        var expectedIntCount = 2;
        var expectedFizzCount = 0;
        var expectedBuzzCount = 0;
        var expectedFizzBuzzCount = 0;
        var expectedLuckyCount = 1;

        var expectedResult = $"1 2 lucky fizz:{expectedFizzCount} buzz: {expectedBuzzCount} fizzbuzz: {expectedFizzBuzzCount} lucky: {expectedLuckyCount} integer: {expectedIntCount}";

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

        var expectedIntCount = 0;
        var expectedFizzCount = 1;
        var expectedBuzzCount = 1;
        var expectedFizzBuzzCount = 0;
        var expectedLuckyCount = 0;

        var expectedResult = $"buzz fizz fizz:{expectedFizzCount} buzz: {expectedBuzzCount} fizzbuzz: {expectedFizzBuzzCount} lucky: {expectedLuckyCount} integer: {expectedIntCount}";

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

        var expectedIntCount = 2;
        var expectedFizzCount = 0;
        var expectedBuzzCount = 0;
        var expectedFizzBuzzCount = 0;
        var expectedLuckyCount = 1;

        var expectedResult = $"1 2 lucky fizz:{expectedFizzCount} buzz: {expectedBuzzCount} fizzbuzz: {expectedFizzBuzzCount} lucky: {expectedLuckyCount} integer: {expectedIntCount}";

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

        var expectedIntCount = 2;
        var expectedFizzCount = 0;
        var expectedBuzzCount = 0;
        var expectedFizzBuzzCount = 1;
        var expectedLuckyCount = 0;

        var expectedResult = $"14 fizzbuzz 16 fizz:{expectedFizzCount} buzz: {expectedBuzzCount} fizzbuzz: {expectedFizzBuzzCount} lucky: {expectedLuckyCount} integer: {expectedIntCount}";

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

        var expectedIntCount = 10;
        var expectedFizzCount = 4;
        var expectedBuzzCount = 3;
        var expectedFizzBuzzCount = 1;
        var expectedLuckyCount = 2;

        var expectedResult = $"1 2 lucky 4 buzz fizz 7 8 fizz buzz 11 fizz lucky 14 fizzbuzz 16 17 fizz 19 buzz fizz:{expectedFizzCount} buzz: {expectedBuzzCount} fizzbuzz: {expectedFizzBuzzCount} lucky: {expectedLuckyCount} integer: {expectedIntCount}";

        Assert.IsNotNull(result);
        Assert.AreEqual(expectedResult, result);
    }
}

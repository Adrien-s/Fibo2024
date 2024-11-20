namespace Leonardo.Tests;

public class UnitTest1
{
    [Fact]
    public async Task Test1()
    {
        var results = await Fibonacci.RunAsync(new string[]{"41"});
        Assert.Equal(165580141, results[0].Result);
    }
}
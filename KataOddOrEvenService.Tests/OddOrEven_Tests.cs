using System.Collections.Generic;
using Xunit;

namespace KataOddOrEvenService.Tests;

public class OddOrEven_Tests
{
    [Fact]
    public void DoNothing()
    {
        Assert.False(false);
    }

    [Fact]
    public void ShouldReturnEvenIfEmptyList()
    {
        Assert.Equal("even", new OddOrEven().Ask(new List<int>{ }));
    }

    [Fact]
    public void ShouldReturnOddIfOneElementListIsOdd()
    {
        Assert.Equal("odd", new OddOrEven().Ask(new List<int> { 1 }));
    }

    [Fact]
    public void ShouldReturnOddIfOneElementListIsEven()
    {
        Assert.Equal("even", new OddOrEven().Ask(new List<int> { 2 }));
    }

    [Fact]
    public void ShouldReturnOddIfElementsListSumIsEven()
    {
        Assert.Equal("even", new OddOrEven().Ask(new List<int> { 3, 7 }));
    }

    [Fact]
    public void ShouldReturnOddIfElementsListSumIsOdd()
    {
        Assert.Equal("odd", new OddOrEven().Ask(new List<int> { 3, 8 }));
    }

    [Fact]
    public void ShouldReturnOddIfElementsListSumIsOddWithNegativeNumbers()
    {
        Assert.Equal("odd", new OddOrEven().Ask(new List<int> { 3, -8, -2 }));
    }

    //***** Possible refactor of the tests

    [Theory]
    [InlineData(3, -8, -2)]
    [InlineData(-4, -6, -11)]
    [InlineData(-2, 1, 0)]
    public void ShouldReturnOdd(int number1, int number2, int number3)
    {
        Assert.Equal("odd", new OddOrEven().Ask(new List<int> { number1, number2, number3 }));
    }
}
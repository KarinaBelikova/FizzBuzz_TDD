using FluentAssertions;

namespace FizzBuzz.Tests;

public class UnitTest1
{
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(7)]
    public void GivenANumberNotDivisibleBy3or5_ThenReturnsNumberAsString(int number)
    {
        string result = FizzBuzzGame.Play(number);

        result.Should().Be(number.ToString());
    }

    [Theory]
    [InlineData(5)]
    [InlineData(10)]
    [InlineData(20)]
    public void GivenANumberDivisibleBy5_ThenReturnsBuzz(int number)
    {
        string result = FizzBuzzGame.Play(number);

        result.Should().Be("Buzz");
    }

    [Theory]
    [InlineData(3)]
    [InlineData(6)]
    [InlineData(9)]
    public void GivenANumberDivisibleBy3_ThenReturnsFizz(int number)
    {
        string result = FizzBuzzGame.Play(number);

        result.Should().Be("Fizz");
    }

    [Theory]
    [InlineData(15)]
    [InlineData(30)]
    [InlineData(45)]
    public void GivenANumberDivisibleBy3or5_ThenReturnsFizzBuzz(int number)
    {
        string result = FizzBuzzGame.Play(number);

        result.Should().Be("FizzBuzz");
    }
}

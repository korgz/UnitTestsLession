using Xunit;

namespace UnitTestsLession.Tests
{
    /// <summary>
    /// FizzBuzz
    /// 1. ja skaitls dalas tad atgriez 3 tad atgriez "Fizz"
    /// 2. ja skaitls dalas tad atgriez 5 tad atgriez "Bizz"
    /// 3. ja skaitls dalas tad atgriez 3 un 5 tad atgriez "FizzBuzz"
    /// 4. citadi atgriez pasu skaitli.
    /// 
    /// Method name_When_Then
    /// </summary>
    public class FizzBuzzTests
    {
        [Fact]
        public void GetFizzBuzzString_WhenNumberDividesBy3_ThenReturnsFizz()
        {
            string response = FizzBuzz.GetFizzBuzzString(3);

            Assert.Equal("Fizz", response);
        }

        [Fact]
        public void GetFizzBuzzString_WhenNumberDividesBy5_ThenReturnsBuzz()
        {
            string response = FizzBuzz.GetFizzBuzzString(5);

            Assert.Equal("Buzz", response);
        }

        [Fact]
        public void GetFizzBuzzString_WhenNumberDividesBy3and5_ThenReturnsFizzBuzz()
        {
            string response = FizzBuzz.GetFizzBuzzString(15);

            Assert.Equal("FizzBuzz", response);
        }

        [Fact]
        public void GetFizzBuzzString_WhenNumberDoesNotDividesBy3and5_ThenReturnsNumber()
        {
            string response = FizzBuzz.GetFizzBuzzString(7);

            Assert.Equal("7", response);
        }
    }
}
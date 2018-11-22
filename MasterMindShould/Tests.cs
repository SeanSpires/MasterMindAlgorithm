
using MasterMind;
using Xunit;

namespace MasterMindShould
{
    public class Tests
    {
        [Fact]
        public void ShouldCountTheNumberOfWellPlacedColors()
        {
            var guess = new Guess();
            var secret = new[] {"blue","red","green","pink"};
            var playerGuess = new[] {"blue", "blue"};
            var result = guess.NumberOfWellPlacedColors(playerGuess, secret);
            const int expectedResult = 1;
            
            Assert.Equal(expectedResult,result);
        }

        [Fact]
        public void ShouldCountTheNumberOfMisPlacedColors()
        {
            var guess = new Guess();
            var secret = new[] {"blue","red","green","pink"};
            var playerGuess = new[] {"red", "blue"};
            var result = guess.NumberOfMisPlacedColors(playerGuess, secret);
            const int expectedResult = 2;
            
            Assert.Equal(expectedResult,result);
        }


        [Fact]
        public void ShouldReturnCorrectResultForAGuess()
        {
            var guess = new Guess();
            var secret = new[] {"red","yellow"};
            var playerGuess = new[] {"blue", "red"};
            var result = guess.ResultOfGuess(playerGuess, secret);
            var expectedResult = new[] {0,1};
            
            Assert.Equal(expectedResult,result);
        }

    }

}
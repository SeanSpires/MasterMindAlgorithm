using System.Linq;

namespace MasterMind
{
    public class Guess
    {
        public int NumberOfWellPlacedColors(string[] playerGuess, string[] secret)
        {
            var allWellPlacedColors = 
                playerGuess.Where((guess, indexOfGuess) => IsWellPlaced(guess, indexOfGuess, secret));

            var numberOfWellPlacedColors = allWellPlacedColors.Count();

            return numberOfWellPlacedColors;
        }

        private bool IsWellPlaced(string guess, int indexOfGuess, string[] secret)
        {
            return secret[indexOfGuess] == guess;
        }

        public int NumberOfMisPlacedColors(string[] playerGuess, string[] secret)
        {
            var allMisPlacedColors =
                playerGuess.Where((guess, indexOfGuess) => IsMisPlaced(guess, indexOfGuess, secret));

            var numberOfMisPlacedColors = allMisPlacedColors.Count();

            return numberOfMisPlacedColors;
        }

        private bool IsMisPlaced(string guess, int indexOfGuess, string[] secret)
        {
            return secret.Contains(guess) && !IsWellPlaced(guess, indexOfGuess, secret);
        }

        public int[] ResultOfGuess(string[] playerGuess, string[] secret)
        {
            var numberOfWellPlaced = NumberOfWellPlacedColors(playerGuess, secret);
            var numberOfMisPlaced = NumberOfMisPlacedColors(playerGuess, secret);

            return new[] {numberOfWellPlaced, numberOfMisPlaced};
        }
    }
}
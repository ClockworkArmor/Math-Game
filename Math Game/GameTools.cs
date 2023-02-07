namespace Math_Game
{
    internal class GameTools
    {
        static List<string> gameHistory = new();
        internal static void GetGames()
        {
            Console.Clear();
            Console.WriteLine("Game History");
            Console.WriteLine("---------------------------------");
            foreach (var game in gameHistory)
            {
                Console.WriteLine(game);
            }
            Console.WriteLine("---------------------------------");
        }
        internal static int[] GetDivisionNumbers()
        {
            var randomNumber = new Random();
            var firstNumber = randomNumber.Next(1, 99);
            var secondNumber = randomNumber.Next(1, 99);
            var result = new int[2];

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = randomNumber.Next(1, 99);
                secondNumber = randomNumber.Next(1, 99);
            }

            result[0] = firstNumber;
            result[1] = secondNumber;


            return result;
        }
        internal static void AddToHistory(int playerScore, string gameType)
        {
            gameHistory.Add($"{DateTime.Now} - {gameType}: {playerScore} Points");
        }
    }
}

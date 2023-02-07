namespace Math_Game
{
    internal class GameCore
    {
        internal void AdditionPractice()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("You have chosen Addition, I hope you are ready!");
            Console.WriteLine("---------------------------------");

            var randomNumber = new Random();
            int firstNumber;
            int secondNumber;
            int playerScore = 0;

            for (int i = 0; i < 5; i++)
            {
                firstNumber = randomNumber.Next(0, 99);
                secondNumber = randomNumber.Next(0, 99);
                Console.WriteLine($"{firstNumber} + {secondNumber} = ??");
                Console.WriteLine("---------------------------------");

                var playerAnswer = Console.ReadLine().Trim();

                if (int.Parse(playerAnswer) == firstNumber + secondNumber)
                {
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Good Job! Your answer is correct!");
                    Console.WriteLine("---------------------------------");
                    playerScore++;
                }
                else
                {
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Sorry, your answer is incorrect. Better luck next time!");
                    Console.WriteLine("---------------------------------");
                }
            }
            GameTools.AddToHistory(playerScore, "Addition");
        }
        internal void SubtractionPractice()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("You have chosen Subtraction, I hope you are ready!");
            Console.WriteLine("---------------------------------");

            var randomNumber = new Random();
            int firstNumber;
            int secondNumber;
            int playerScore = 0;

            for (int i = 0; i < 5; i++)
            {
                firstNumber = randomNumber.Next(0, 99);
                secondNumber = randomNumber.Next(0, 99);
                Console.WriteLine($"{firstNumber} - {secondNumber} = ??");
                Console.WriteLine("---------------------------------");

                var playerAnswer = Console.ReadLine().Trim();

                if (int.Parse(playerAnswer) == firstNumber - secondNumber)
                {
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Good Job! Your answer is correct!");
                    Console.WriteLine("---------------------------------");
                    playerScore++;
                }
                else
                {
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Sorry, your answer is incorrect. Better luck next time!");
                    Console.WriteLine("---------------------------------");
                }
            }
            GameTools.AddToHistory(playerScore, "Subtraction");
        }
        internal void MultiplicationPractice()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("You have chosen Multiplication, I hope you are ready!");
            Console.WriteLine("---------------------------------");

            var randomNumber = new Random();
            int firstNumber;
            int secondNumber;
            int playerScore = 0;

            for (int i = 0; i < 5; i++)
            {
                firstNumber = randomNumber.Next(0, 9);
                secondNumber = randomNumber.Next(0, 9);
                Console.WriteLine($"{firstNumber} x {secondNumber} = ??");
                Console.WriteLine("---------------------------------");

                var playerAnswer = Console.ReadLine().Trim();

                if (int.Parse(playerAnswer) == firstNumber * secondNumber)
                {
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Good Job! Your answer is correct!");
                    Console.WriteLine("---------------------------------");
                    playerScore++;
                }
                else
                {
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Sorry, your answer is incorrect. Better luck next time!");
                    Console.WriteLine("---------------------------------");
                }
            }
            GameTools.AddToHistory(playerScore, "Multiplication");
        }
        internal void DivisionPractice()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("You have chosen Division, I hope you are ready!");
            Console.WriteLine("---------------------------------");

            int playerScore = 0;

            for (int i = 0; i < 5; i++)
            {
                var divisionNumbers = GameTools.GetDivisionNumbers();
                var firstNumber = divisionNumbers[0];
                var secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber} = ??");
                Console.WriteLine("---------------------------------");

                var playerAnswer = Console.ReadLine().Trim();

                if (int.Parse(playerAnswer) == firstNumber / secondNumber)
                {
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Good Job! Your answer is correct!");
                    Console.WriteLine("---------------------------------");
                    playerScore++;
                }
                else
                {
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Sorry, your answer is incorrect. Better luck next time!");
                    Console.WriteLine("---------------------------------");
                }
            }
            GameTools.AddToHistory(playerScore, "Division");
        }
        internal void RandomPractice()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("You have chosen Random, I hope you are ready for a surprise!");
            Console.WriteLine("---------------------------------");

            var randomNumber = new Random().Next(1, 4);
            switch (randomNumber)
            {
                case 1:
                    AdditionPractice();
                    break;
                case 2:
                    SubtractionPractice();
                    break;
                case 3:
                    MultiplicationPractice();
                    break;
                case 4:
                    DivisionPractice();
                    break;
            }
        }
    }
}

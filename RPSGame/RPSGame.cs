  using System;

namespace RPSGame
{
    public class RPSGame
    {
        public Player HumanPlayer { get; set; }
        public Player Computer { get; set; }
        public Random Random { get; set; }

        public RPSGame(string playerName)
        {
            HumanPlayer = new Player(playerName);
            Computer = new Player("Computer");
            Random = new Random();
        }

        public void PlayGame()
        {
            while (HumanPlayer.Score < 3 && Computer.Score < 3)
            {
                string playerMove = HumanPlayer.ChooseMove();
                string aiMove = GenerateAIMove();


                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("====================================");
                Console.WriteLine($"{HumanPlayer.Name} chose {playerMove}");
                Console.WriteLine($"{Computer.Name} chose {aiMove}");
                Console.WriteLine("====================================\n");

                Console.ForegroundColor = ConsoleColor.Cyan;

                int result = CompareMoves(playerMove, aiMove);
                if (result == 1)
                {
                    Console.WriteLine($"{HumanPlayer.Name} wins this round!");
                    HumanPlayer.Score++;
                }
                else if (result == -1)
                {
                    Console.WriteLine($"{Computer.Name} wins this round!");
                    Computer.Score++;
                }
                else
                {
                    Console.WriteLine("This round is a draw!");
                }

                DisplayScores();
            }

            DeclareWinner();
        }

        private string GenerateAIMove()
        {
            int choice = Random.Next(1, 4);
            return choice switch
            {
                1 => "Rock",
                2 => "Paper",
                3 => "Scissors",
                _ => throw new Exception("Invalid move")
            };
        }

        private int CompareMoves(string playerMove, string aiMove)
        {
            if (playerMove == aiMove) return 0;

            return (playerMove, aiMove) switch
            {
                ("Rock", "Scissors") => 1,
                ("Paper", "Rock") => 1,
                ("Scissors", "Paper") => 1,
                ("Rock", "Paper") => -1,
                ("Paper", "Scissors") => -1,
                ("Scissors", "Rock") => -1,
                _ => 0
            };
        }

        private void DisplayScores()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("====================================");
            Console.WriteLine($"Scores:\n{HumanPlayer.Name}: {HumanPlayer.Score}\n{Computer.Name}: {Computer.Score}");
            Console.WriteLine("====================================");
        }

        private void DeclareWinner()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            if (HumanPlayer.Score > Computer.Score)
            {
                Console.WriteLine($"{HumanPlayer.Name} wins the game!");
            }
            else
            {
                Console.WriteLine($"{Computer.Name} wins the game!");
            }
        }
    }

}

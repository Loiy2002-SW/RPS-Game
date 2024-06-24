
namespace RPSGame
{
    public class Player
    {
            public string Name { get; set; }
            public int Score { get; set; }

            public Player(string name)
            {
                Name = name;
                Score = 0;
            }


            public string ChooseMove() {

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n====================================");
            Console.WriteLine("Choose a move:\n 1: Rock\n 2: Paper\n 3: Scissors");

            while (true)
            {
                string reslut = Console.ReadLine();

                if (reslut == "1" || reslut == "2" || reslut == "3")
                    return reslut switch
                    {
                        "1" => "Rock",
                        "2" => "Paper",
                        "3" => "Scissors"
                    };

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input, please enter a correct move:");
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
            }

        }
    }
}

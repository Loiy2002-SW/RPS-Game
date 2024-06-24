
namespace RPSGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("====================================");
            Console.WriteLine("Welcome to Rock, Paper, Scissors!");
            Console.WriteLine("====================================\n\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter your name: ");

            string playerName = askTheUserForHisName();

           
           

            RPSGame game = new RPSGame(playerName);
            game.PlayGame();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Thanks for playing!");

        }

        private static string askTheUserForHisName()
        {

            string name = "";
            while (true)
            {

                name = Console.ReadLine();

                

                if (name.Length < 2) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a valid name");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                    
                else
                    return name;

            }

        }
    }
}

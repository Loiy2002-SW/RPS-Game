
namespace RPSGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Rock, Paper, Scissors!");

            Console.Write("Enter your name: ");

            string playerName = askTheUserForHisName();

           
           

            RPSGame game = new RPSGame(playerName);
            game.PlayGame();

            Console.WriteLine("Thanks for playing!");

        }

        private static string askTheUserForHisName()
        {

            string name = "";
            while (true)
            {

                name = Console.ReadLine();

                if (name.Length < 2)
                    Console.WriteLine("Please enter a valid name");
                else
                    return name;

            }

        }
    }
}

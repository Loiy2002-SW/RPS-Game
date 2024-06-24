namespace RPSGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Player p = new Player("Loai");

            Console.WriteLine(p.ChooseMove());

        }
    }
}

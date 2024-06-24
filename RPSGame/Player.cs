using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSGame
{
    internal class Player
    {
        string name;
        int score;

        public Player(string name)
        {
            this.name = name;
            this.score = 0;
        }


        public string ChooseMove() {


            Console.WriteLine("Choose a move:\n 1: Rock\n 2: Paper\n 3: Scissors");

            while (true)
            {
                string reslut = Console.ReadLine();

                if (reslut == "1" || reslut == "2" || reslut == "3")
                    return reslut;

                else
                    Console.WriteLine("Invalid input, please enter a correct move:");
            }

        }
    }
}

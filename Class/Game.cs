using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu_Morpion.Class
{
    internal class Game
    {
        private Board board;
        private Player player1;
        private Player player2;
        private Player currentPlayer;

        public Game()
        {
            board = new Board();
            player1 = new Player('O');
            player2 = new Player('X');
            currentPlayer = GetRandomPlayer();
        }

        public void Start()
        {
            Console.WriteLine("Jouez =) C'est le morpion");
            Console.WriteLine($"{currentPlayer.CrossOrCircle} COMMENCE + RATIO.\n");

            bool gameWon = false;

            while (!gameWon && !board.IsFull())
            {
                board.Display();
                Console.WriteLine($"\nJoueur {currentPlayer.CrossOrCircle}, CHOISI :");
                string choice = Console.ReadLine();

                if (board.PlayMove(choice, currentPlayer.CrossOrCircle))
                {
                    gameWon = board.CheckWinner(currentPlayer.CrossOrCircle);
                    if (!gameWon)
                    {
                        SwitchPlayer();
                    }
                }
                else
                {
                    Console.WriteLine("Case invalide, Rejoue ou CONSEQUENCES.");
                }
            }

            board.Display();

            if (gameWon)
            {
                Console.WriteLine($"\nLe joueur {currentPlayer.CrossOrCircle} a gagné ! L'autre t'es NUL");
            }
            else
            {
                Console.WriteLine("\nC'EST NULL ! Personne n'a gagné.");
            }
        }

        private Player GetRandomPlayer()
        {
            Random random = new Random();
            return random.Next(0, 2) == 0 ? player1 : player2;
        }

        private void SwitchPlayer()
        {
            currentPlayer = currentPlayer == player1 ? player2 : player1;
        }
    }

}


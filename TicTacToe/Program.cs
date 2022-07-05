using System;

namespace TicTacToe
{
    class Program
    {
        static int[] board = new int[9];
        static void Main(string[] args)
        {

            board[0] = 0;
            board[1] = 0;
            board[2] = 0;
            board[3] = 0;
            board[4] = 0;
            board[5] = 0;
            board[6] = 0;
            board[7] = 0;
            board[8] = 0;

            printboard();

            int player1Turn = -1;
            //int computerTurn=-1;
            int player2Turn = -1;
            //Random r = new Random();



            while (checkForWinner() == 0)
            {


                while (player1Turn == -1 || board[player1Turn] != 0)
                {
                    Console.WriteLine("Please enter a number 0 to 8");
                    player1Turn = int.Parse(Console.ReadLine());
                    Console.WriteLine("You typed " + player1Turn);
                }
                board[player1Turn] = 1;
                printboard();
                if (checkForWinner() != 0)
                {
                    break;
                }
                if (board[0] != 0 && board[1] != 0 && board[2] != 0 && board[3] != 0 && board[4] != 0 && board[5] != 0 && board[6] != 0 && board[7] != 0 && board[8] != 0)
                {
                    Console.WriteLine("Draw"); break;
                }

                // Console.ForegroundColor = ConsoleColor.Green;

                while (player2Turn == -1 || board[player2Turn] != 0)
                {

                    Console.WriteLine("Please enter a number 0 to 8");
                    player2Turn = int.Parse(Console.ReadLine());

                    Console.WriteLine("player2 chooses: " + player2Turn);

                }
                board[player2Turn] = 2;
                printboard();
                if (board[0] != 0 && board[1] != 0 && board[2] != 0 && board[3] != 0 && board[4] != 0 && board[5] != 0 && board[6] != 0 && board[7] != 0 && board[8] != 0)
                {
                    Console.WriteLine("Draw"); break;
                }
                //else continue;

            }
            //if (checkForWinner() == 0)
            //{
            //    Console.WriteLine("Draw"); 
            //}
            if (checkForWinner() == 1)
            {
                Console.WriteLine("Player 1 won the game");
            }
            if (checkForWinner() == 2)
            {
                Console.WriteLine("Player 2 won the game");
            }
            // Console.WriteLine("Player " + checkForWinner()+ " won the game");

        }
        private static void printboard()
        {
            for (int i = 0; i < board.Length; i++)
            {
                if (board[i] == 0)
                {
                    Console.Write(".");
                }
                if (board[i] == 1)
                {
                    Console.Write("x");
                }
                if (board[i] == 2)
                {
                    Console.Write("o");
                }
                if (i == 2 || i == 5 || i == 8)
                {
                    Console.WriteLine();
                }
            }
        }
        private static int checkForWinner()
        {
            if (board[0] == board[1] && board[1] == board[2])
            {
                return board[0];
            }
            if (board[3] == board[4] && board[4] == board[5])
            {
                return board[3];
            }
            if (board[6] == board[7] && board[7] == board[8])
            {
                return board[6];
            }
            if (board[0] == board[4] && board[4] == board[8])
            {
                return board[0];
            }
            if (board[0] == board[3] && board[3] == board[6])
            {
                return board[0];
            }
            if (board[1] == board[4] && board[4] == board[7])
            {
                return board[1];
            }
            if (board[2] == board[5] && board[5] == board[8])
            {
                return board[2];
            }

            if (board[2] == board[4] && board[4] == board[6])
            {
                return board[2];
            }
            return 0;
        }
    }
}

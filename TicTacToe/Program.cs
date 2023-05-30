﻿using System;

namespace TicTacToe
{
    class Program
    {
        // the playfield
        static char[,] playField =
        {
            {'1', '2', '3'}, // row 1
            {'4', '5', '6'}, // row 2
            {'7', '8', '9'}, // row 3
        };

        static int turns = 0;

        static void Main(string[] args)
        {
            int player = 2; // Player 1 starts
            int input = 0;
            bool inputCorrect = true;


            // Run code as long as the program runs
            do
            {
                if (player == 2)
                {
                    player = 1;
                    EnterXorO('O', input);
                }
                else if (player == 1)
                {
                    player = 2;
                    EnterXorO('X', input);
                }

                SetField();

                #region
                // Check winning condition
                char[] playerChars = { 'X', 'O'};

                foreach (char playerChar in playerChars)
                {
                    if (((playField[0, 0] == playerChar) && (playField[0, 1] == playerChar) && (playField[0, 2] == playerChar))
                        || ((playField[1, 0] == playerChar) && (playField[1, 1] == playerChar) && (playField[1, 2] == playerChar))
                        || ((playField[2, 0] == playerChar) && (playField[2, 1] == playerChar) && (playField[2, 2] == playerChar))
                        || ((playField[0, 0] == playerChar) && (playField[1, 0] == playerChar) && (playField[2, 0] == playerChar))
                        || ((playField[0, 1] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 1] == playerChar))
                        || ((playField[0, 2] == playerChar) && (playField[2, 1] == playerChar) && (playField[2, 2] == playerChar))
                        || ((playField[0, 0] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 2] == playerChar))
                        || ((playField[0, 2] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 0] == playerChar)))
                    {
                        if (playerChar == 'X')
                        {
                            Console.WriteLine("\nPlayer 2 has won!");
                        }
                        else
                        {
                            Console.WriteLine("\nPlayer 1 has won");
                        }
                        Console.WriteLine("Please press anykey to reset game!");
                        Console.ReadKey();
                        ResetField();


                        // Todo reset field
                        break;
                    }
                    else if (turns == 10)
                    {
                        Console.WriteLine("\nDRAAW!");
                        Console.WriteLine("Please press anykey to reset game!");
                        Console.ReadKey();
                        ResetField();
                        break;
                    }
                }
                #endregion

                #region
                // Test if field is already raken
                do
                {
                    Console.WriteLine($"\n Player {player}: Choose your field!");
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Please enter a number!");
                        
                    }

                    if ((input == 1) && (playField[0, 0] == '1'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 2) && (playField[0, 1] == '2'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 3) && (playField[0, 2] == '3'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 4) && (playField[1, 0] == '4'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 5) && (playField[1, 1] == '5'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 6) && (playField[1, 2] == '6'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 7) && (playField[2, 0] == '7'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 8) && (playField[2, 1] == '8'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 9) && (playField[2, 2] == '9'))
                    {
                        inputCorrect = true;
                    }
                    else
                    {
                        Console.WriteLine("\nIncorrect input! Please use another field!");
                        inputCorrect = false;
                    }

                } while (!inputCorrect);
                #endregion

            } while (true);
        
        }

        public static void ResetField()
        {
            char[,] playFieldInitial =
            {
                {'1', '2', '3'}, // row 0
                {'4', '5', '6'}, // row 1
                {'7', '8', '9'} // row 2
             };
            playField = playFieldInitial;
            SetField();
            turns = 0;
        }

        public static void SetField()
        {
            Console.Clear();
            Console.WriteLine("     |     |    ");
            Console.WriteLine($"  {playField[0,0]}  |  {playField[0, 1]}  |  {playField[0, 2]}");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |    ");
            Console.WriteLine($"  {playField[1,0]}  |  {playField[1, 1]}  |  {playField[1, 2]}");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |    ");
            Console.WriteLine($"  {playField[2, 0]}  |  {playField[2, 1]}  |  {playField[2, 2]}");
            Console.WriteLine("     |     |    ");
            turns++;
        }

        public static void EnterXorO(char playerSign, int input)
        {

            switch (input)
            {
                case 1:
                    playField[0, 0] = playerSign;
                    break;
                case 2:
                    playField[0, 1] = playerSign;
                    break;
                case 3:
                    playField[0, 2] = playerSign;
                    break;
                case 4:
                    playField[1, 0] = playerSign;
                    break;
                case 5:
                    playField[1, 1] = playerSign;
                    break;
                case 6:
                    playField[1, 2] = playerSign;
                    break;
                case 7:
                    playField[2, 0] = playerSign;
                    break;
                case 8:
                    playField[2, 1] = playerSign;
                    break;
                case 9:
                    playField[2, 2] = playerSign;
                    break;
            }
        }

    }
}
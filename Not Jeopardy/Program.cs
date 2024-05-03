using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Not_Jeopardy
{
    class Program
    {
        public static int[,] Play   = new int[5,5];
        public static int[,] Select = new int[5,5];

        public static int CX;
        public static int CY;
        
        public static int X = 0;
        public static int Y = 0;       
       
        static void Main(string[] args)
        {
            bool again;
            bool selecting = true;
       
            Console.CursorVisible = false;
       
            Select[Y, X] = 1;
       
            PreGame();
            StartGame();
            do
            {
                BuildBoard();
                while (selecting)
                {
                    selecting = Selecting();
                    BuildBoard();
                }
                Console.Clear();
                Questions.QHandeler();
                selecting = true;
                again = AGAIN(Playing());
            } while (again);
        }

        public static void PreGame()
        {
            Console.WriteLine("Welcome to Jeopardy!\n");
            Console.WriteLine("Use the arrow keys to move the selector.");
            Console.WriteLine("Press Enter or Space to Select");
            Console.WriteLine("Press Esc to leave.\n");
            Console.WriteLine("Press any key to continue...");
            if(Console.ReadKey(true).Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
                //Console.Clear();
                //AGAIN(true);
            }
            Console.Clear();
        }
        
        public static void StartGame()
        {
            for(int i = 0; i < Play.GetLength(0); ++i)
            {
                for(int j = 0; j < Play.GetLength(1); ++j)
                {
                    Play[i, j] = 1;
                }
            }
        }

        public static void Changer(int i, int j)
        {
            CX = (j * 10);
            CY = (i * 5);           
        }

        public static void BuildBoard()
        {
            for (int i = 0; i < Play.GetLength(0); ++i)
            {
                for (int j = 0; j < Play.GetLength(1); ++j)
                {
                    if (Select[i, j] == 1)
                    {
                        Board.BoardWhite();
                        Changer(i, j);
                        Board.BuildTile();
                        Board.BoardBlack();
                    }
                    else
                    {
                        Changer(i, j);
                        Board.BuildTile();
                    }
                }
            }
        }

        public static bool Selecting()
        {
            Select[Y, X] = 0;

            ConsoleKey userinput = Console.ReadKey(true).Key;

            if ((userinput == ConsoleKey.UpArrow || userinput == ConsoleKey.W) && Y != 0)
            {
                Y--;
            }
            if ((userinput == ConsoleKey.DownArrow || userinput == ConsoleKey.S) && Y != 4)
            {
                Y++;
            }
            if ((userinput == ConsoleKey.LeftArrow || userinput == ConsoleKey.A) && X != 0)
            {
                X--;
            }
            if ((userinput == ConsoleKey.RightArrow || userinput == ConsoleKey.D) && X != 4)
            {
                X++;
            }
            if (userinput == ConsoleKey.Enter || userinput == ConsoleKey.Spacebar)
            {
                if (Play[Y, X] == 1)
                {
                    Console.Clear();
                    Select[Y, X] = 1;
                    return false;
                }
                if (Play[Y, X] != 1)
                {
                    Console.Clear();
                    Console.WriteLine("You've already picked that question.\n");
                    Console.WriteLine("Press any key to continue...");

                    ConsoleKey ui = Console.ReadKey(true).Key;

                    if (ui == ConsoleKey.Escape)
                    {
                        Environment.Exit(0);
                    }
                    Console.Clear();
                }
            }
            if (userinput == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }

            Select[Y, X] = 1;

            return true;
        }

        public static bool AGAIN(bool Go)
        {
            bool lop = true;
            bool selected = false;
            int INDX = 1;

            if (Go)
            {
                ConsoleKey userinput = ConsoleKey.N;

                Console.WriteLine("Congradulations! You completed the game with $" + Questions.Points + "!\n\n");
                if (Questions.Points == 7500)
                {
                    Console.WriteLine("YOU GOT ALL THE QUESTIONS RIGHT??? YOU ARE AS COOL AS I AM!");
                }
                else if (Questions.Points == 0)
                {
                    Console.WriteLine("That's impressive. You got no Monies. Can you even do that?");
                }
                else if (Questions.Points == -7500)
                {
                    Console.WriteLine("Secretly a genius? Or just Extreme bad luck?");
                }
                else if (Questions.Points < 0)
                {
                    Console.WriteLine("IQ = 2. You could have gotten a total of $7,500. but you got less than you started with.");
                }
                else
                {
                    Console.WriteLine("Good job. But you could have gotten $7,500\n\n");
                }               
                Console.WriteLine("Would you like to play again?\n");

                while (!selected)
                {
                    Console.SetCursorPosition(0, 7);
                    if ((userinput == ConsoleKey.DownArrow || userinput == ConsoleKey.S) && INDX != 2)
                    {
                        INDX++;
                        lop = false;
                    }
                    if ((userinput == ConsoleKey.UpArrow || userinput == ConsoleKey.W) && INDX != 1)
                    {
                        INDX--;
                        lop = true;
                    }
                    if (userinput == ConsoleKey.Enter || userinput == ConsoleKey.Spacebar)
                    {
                        selected = true;
                        StartGame();
                    }
                    if (userinput == ConsoleKey.Escape)
                    {
                        Environment.Exit(0);
                    }

                    switch (INDX)
                    {
                        case 1:
                            Console.Write(" > Yes\n");
                            Console.Write("   No");
                            break;
                        case 2:
                            Console.Write("   Yes\n");
                            Console.Write(" > No");
                            break;
                    }
                    if (selected == false)
                    {
                        userinput = Console.ReadKey(true).Key;
                    }
                }               
            }
            Console.Clear();
            return lop;
        }

        public static bool Playing()
        {
            for(int i = 0; i < Play.GetLength(0); i++)
            {
                for (int j = 0; j < Play.GetLength(1); j++)
                {
                    if (Play[i,j] == 1)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
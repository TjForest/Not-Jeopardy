using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Welcome to not Jeopardy! This is a simple console game that is a mock of the popular game show Jeopardy.
/// Created by TJ Forest as a final project in Programming 1 at Full Sail University.
/// This branch is rafactored with my current knowledge of C# and follows better practices and has some new features, and actaul comments explaining things.

namespace Not_Jeopardy {
	class Program {
		#region Global Variables
		/// <summary>
		/// The play board is used to keep track of what questions have been answered<br></br>
		/// <c>true</c> (1) if the question has not been answered<br></br>
		/// <c>false</c> (0) if the question has been answered
		/// </summary>
		public static bool[,] PlayBoard = new bool[5, 5];
		/// <summary>
		/// The select array is used to select tiles on the board<br></br>
		/// <c>true</c> (1) if the tile is selected<br></br>
		/// <c>false</c> (0) if the tile is not selected
		/// </summary>
		public static bool[,] SelectBoard = new bool[5, 5];

		/// <summary>
		/// Stores the console cursor coordinate for the X axis
		/// </summary>
		public static int CoordX;
		/// <summary>
		/// Stores the console cursor coordinate for the Y axis
		/// </summary>
		public static int CoordY;

		/// <summary>
		/// Stores the current X coordinate of the selector
		/// </summary>
		public static int m_X = 0;
		/// <summary>
		/// Stores the current Y coordinate of the selector
		/// </summary>
		public static int m_Y = 0;
		#endregion

		/// <summary>
		/// The entry point for the application.
		/// </summary>
		static void Main(string[] args) {
			Console.CursorVisible = false;

			PreGame(); // Display the pregame message to orient the player
			InitGame(); // start the game
			do {
				BuildBoard(); // Display the game board
				while(Selecting()) { // The player is selecting a tile
					BuildBoard(); // refresh the board
				} // the player selected a tile
				Console.Clear(); // clear the console
				Questions.QHandeler(); // ask the question
			} while(AGAIN(Playing())); // Check if the game is over and then if the player wants to play again
		}

		#region Setup Functions
		/// <summary>
		/// Preamble to orient the player
		/// </summary>
		private static void PreGame() {
			Console.WriteLine("Welcome to Jeopardy!\n");
			Console.WriteLine("Use the arrow keys to move the selector.");
			Console.WriteLine("Press Enter or Space to Select");
			Console.WriteLine("Press Esc to leave.\n");
			Console.WriteLine("Press any key to continue...");
			if(Console.ReadKey(true).Key == ConsoleKey.Escape) {
				Environment.Exit(0);
			}
			Console.Clear();
		}

		/// <summary>
		/// Initializes the game board
		/// </summary>
		private static void InitGame() {
			for(int x = 0; x < PlayBoard.GetLength(0); ++x) { // iterate horizontally
				for(int y = 0; y < PlayBoard.GetLength(1); ++y) { // iterate vertically
					PlayBoard[x, y] = true; // set all tiles to true (Unanswered)
				}
			}
			SelectBoard[m_Y, m_X] = true; // Select the first tile
		}

		/// <summary>
		/// Converts array coordinates to console cursor coordinates
		/// </summary>
		/// <param name="i">Y</param>
		/// <param name="j">X</param>
		private static void CoordConvert(int i, int j) {
			CoordX = (j * 10);
			CoordY = (i * 5);
		}

		/// <summary>
		/// Builds the game board
		/// </summary>
		private static void BuildBoard() {
			for(int i = 0; i < PlayBoard.GetLength(0); ++i) {
				for(int j = 0; j < PlayBoard.GetLength(1); ++j) {
					if(SelectBoard[i, j] == true) {
						Board.BoardWhite();
						CoordConvert(i, j);
						Board.BuildTile();
						Board.BoardBlack();
					} else {
						CoordConvert(i, j);
						Board.BuildTile();
					}
				}
			}
		}
		#endregion

		#region Game Functions
		/// <summary>
		/// Allows the player to select a tile on the board
		/// </summary>
		/// <returns><c>false</c> if the player has selected a tile</returns>
		private static bool Selecting() {
			SelectBoard[m_Y, m_X] = false; // Deselect the current tile

			ConsoleKey userinput = Console.ReadKey(true).Key;

			if((userinput == ConsoleKey.UpArrow || userinput == ConsoleKey.W) && m_Y != 0) { // if the user moves the selector up and it's not at the top of the board
				m_Y--;
			}
			if((userinput == ConsoleKey.DownArrow || userinput == ConsoleKey.S) && m_Y != 4) { // if the user moves the selector down and it's not at the bottom of the board
				m_Y++;
			}
			if((userinput == ConsoleKey.LeftArrow || userinput == ConsoleKey.A) && m_X != 0) { // if the user moves the selector left and it's not at the left edge of the board
				m_X--;
			}
			if((userinput == ConsoleKey.RightArrow || userinput == ConsoleKey.D) && m_X != 4) { // if the user moves the selector right and it's not at the right edge of the board
				m_X++;
			}
			if(userinput == ConsoleKey.Enter || userinput == ConsoleKey.Spacebar) { // If the user selects the tile
				if(PlayBoard[m_Y, m_X] == true) { // If the tile has not been selected previously
					Console.Clear();
					SelectBoard[m_Y, m_X] = true; // Select the new tile
					return false; // Player has selected a tile
				}
				else { // If the tile has been selected previously
					Console.Clear();
					Console.WriteLine("You've already picked that question.\n"); // inform the player they answered that question
					Console.WriteLine("Press any key to continue...");

					ConsoleKey ui = Console.ReadKey(true).Key; // wait for user input

					Console.Clear();
				}
			}
			if(userinput == ConsoleKey.Escape) {
				Environment.Exit(0);
			}

			SelectBoard[m_Y, m_X] = true; // Select the new tile

			return true; // Player is still selecting
		}

		/// <summary>
		/// Asks the player if they would like to play again
		/// </summary>
		/// <param name="Go">Bool for if all the questions are answered or not</param>
		/// <returns><c>True</c> if the player wants to keep playing<br></br><c>false</c> if the player does not</returns>
		private static bool AGAIN(bool Go) {
			bool lop = true; // return variable for later

			if(Go) { // If all the questions have been answered
				ConsoleKey userinput = ConsoleKey.N;

				Console.WriteLine("Congradulations! You completed the game with $" + Questions.GetScore() + "!\n\n"); // display the player's score
				// Display a message based on the player's score
				if(Questions.GetScore() == 7500) {
					Console.WriteLine("YOU GOT ALL THE QUESTIONS RIGHT??? YOU ARE SUPER COOL!");
				} else if(Questions.GetScore() == 0) {
					Console.WriteLine("That's impressive. You have exactly 0 dollars. Can you even do that? I think this is the highest IQ way to play the game!");
				} else if(Questions.GetScore() == -7500) {
					Console.WriteLine("Secretly a genius? Or just Extreme bad luck?");
				} else if(Questions.GetScore() < 0) {
					Console.WriteLine("IQ = 2. You could have gotten a total of $7,500. but you got less than you started with.");
				} else {
					Console.WriteLine("Good job. But you could have gotten $7,500\n\n");
				}
				Console.WriteLine("Would you like to play again?\n"); // prompt the player to play again

				bool selected = false;
				int INDX = 1;
				while(!selected) { // while the player has not selected an option
					Console.SetCursorPosition(0, 7);
					if((userinput == ConsoleKey.DownArrow || userinput == ConsoleKey.S) && INDX != 2) { // if the player moves the selector down and it's not at the bottom
						INDX++;
						lop = false;
					}
					if((userinput == ConsoleKey.UpArrow || userinput == ConsoleKey.W) && INDX != 1) { // if the player moves the selector up and it's not at the top
						INDX--;
						lop = true;
					}
					if(userinput == ConsoleKey.Enter || userinput == ConsoleKey.Spacebar) { // if the player selects an option
						selected = true; // the player has selected an option, end the loop
						InitGame(); // reset the game
					}
					if(userinput == ConsoleKey.Escape) { // if the player exits the game
						Environment.Exit(0);
					}

					switch(INDX) { // display the options based
						case 1:
						Console.Write(" > Yes\n");
						Console.Write("   No");
						break;
						case 2:
						Console.Write("   Yes\n");
						Console.Write(" > No");
						break;
					}
					if(selected == false) { // if the player has not selected an option
						userinput = Console.ReadKey(true).Key; // wait for user input, then loop
					}
				}
			}
			Console.Clear();
			return lop; // return the players choice
		}

		/// <summary>
		/// Checks all tiles to see if they have been answered
		/// </summary>
		/// <returns><c>false</c> if there are still questions to answer<br></br><c>ture</c> if the board is empty</returns>
		private static bool Playing() {
			for(int i = 0; i < PlayBoard.GetLength(0); i++) { // iterate horizontally
				for(int j = 0; j < PlayBoard.GetLength(1); j++) { // iterate vertically
					if(PlayBoard[i, j] == true) { // if a tile has not been answered
						return false; // there are still questions to answer
					}
				}
			}
			return true; // all questions have been answered, game is over
		}
		#endregion
	}
}
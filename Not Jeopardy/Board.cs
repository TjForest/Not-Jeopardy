using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Not_Jeopardy {
	class Board {
		/// <summary>
		/// Sets the console colors to black background and white text
		/// </summary>
		public static void BoardBlack() {
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.White;
		}
		/// <summary>
		/// Sets the console colors to white background and black text
		/// </summary>
		public static void BoardWhite() {
			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Black;
		}

		/// <summary>
		/// Builds a tile on the game board
		/// </summary>
		public static void BuildTile() {
			string num;
			num = "    ";
			int BX = 0;
			int BY = 0;

			BX = XSwitcher(BX);
			BY = YSwitcher(BY);

			if(Program.PlayBoard[BY, BX] == true) {
				switch(Program.CoordY) {
					case 0:
					num = "$100";
					break;
					case 5:
					num = "$200";
					break;
					case 10:
					num = "$300";
					break;
					case 15:
					num = "$400";
					break;
					case 20:
					num = "$500";
					break;
				}
			}
			Console.SetCursorPosition(Program.CoordX, Program.CoordY);
			Console.Write("o--------o");
			Console.SetCursorPosition(Program.CoordX, (Program.CoordY + 1));
			Console.Write("|        |");
			Console.SetCursorPosition(Program.CoordX, (Program.CoordY + 2));
			Console.Write("|  " + num + "  |");
			Console.SetCursorPosition(Program.CoordX, (Program.CoordY + 3));
			Console.Write("|        |");
			Console.SetCursorPosition(Program.CoordX, (Program.CoordY + 4));
			Console.Write("o--------o");
		}

		/// <summary>
		/// Changes Y cursor coordinates into array coordinates
		/// </summary>
		/// <param name="BY">Y cursor coordinates</param>
		/// <returns>Y array coorinates</returns>
		public static int YSwitcher(int BY) {
			switch(Program.CoordY) {
				case 0:
				BY = 0;
				break;
				case 5:
				BY = 1;
				break;
				case 10:
				BY = 2;
				break;
				case 15:
				BY = 3;
				break;
				case 20:
				BY = 4;
				break;
			}
			return BY;
		}
		/// <summary>
		/// Changes Y cursor coordinates into array coordinates
		/// </summary>
		/// <param name="BY">Y cursor coordinates</param>
		/// <returns>Y array coorinates</returns>
		public static int XSwitcher(int BX) {
			switch(Program.CoordX) {
				case 0:
				BX = 0;
				break;
				case 10:
				BX = 1;
				break;
				case 20:
				BX = 2;
				break;
				case 30:
				BX = 3;
				break;
				case 40:
				BX = 4;
				break;
			}
			return BX;
		}
	}
}
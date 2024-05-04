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
		public static void BuildTile(int x, int y) {
			string num;
			num = "    ";

			if(Program.GetAnswered(YSwitcher(y), XSwitcher(x)) == true) {
				switch(y) {
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
			Console.SetCursorPosition(x, y);
			Console.Write("o--------o");
			Console.SetCursorPosition(x, ++y);
			Console.Write("|        |");
			Console.SetCursorPosition(x, ++y);
			Console.Write("|  " + num + "  |");
			Console.SetCursorPosition(x, ++y);
			Console.Write("|        |");
			Console.SetCursorPosition(x, ++y);
			Console.Write("o--------o");
		}

		/// <summary>
		/// Changes Y cursor coordinates into array coordinates
		/// </summary>
		/// <param name="BY">Y cursor coordinates</param>
		/// <returns>Y array coorinates</returns>
		public static int YSwitcher(int y) {
			switch(y) {
				case 0:
				return 0;
				case 5:
				return 1;
				case 10:
				return 2;
				case 15:
				return 3;
				case 20:
				return 4;
			}
			return 0;
		}
		/// <summary>
		/// Changes Y cursor coordinates into array coordinates
		/// </summary>
		/// <param name="BY">Y cursor coordinates</param>
		/// <returns>Y array coorinates</returns>
		public static int XSwitcher(int x) {
			switch(x) {
				case 0:
				return 0;
				case 10:
				return 1;
				case 20:
				return 2;
				case 30:
				return 3;
				case 40:
				return 4;
			}
			return 0;
		}
	}
}
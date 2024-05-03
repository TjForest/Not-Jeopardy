using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Not_Jeopardy
{
    internal class Questions
    {
        public static int Points = 0;      

        public static void QHandeler()
        {
            Program.Play[Program.Y, Program.X] = 0;

            QFlow();
            Console.Clear();
        }
        public static void QFlow()
        {
            switch (Program.Y)
            {
                case 0:
                    switch (Program.X)
                    {
                        case 0:
                            Q00();
                            break;
                        case 1:
                            Q01();
                            break;
                        case 2:
                            Q02();
                            break;
                        case 3:
                            Q03();
                            break;
                        case 4:
                            Q04();
                            break;
                    }
                    break;
                case 1:
                    switch (Program.X)
                    {
                        case 0:
                            Q10();
                            break;
                        case 1:
                            Q11();
                            break;
                        case 2:
                            Q12();
                            break;
                        case 3:
                            Q13();
                            break;
                        case 4:
                            Q14();
                            break;
                    }
                    break;
                case 2:
                    switch (Program.X)
                    {
                        case 0:
                            Q20();
                            break;
                        case 1:
                            Q21();
                            break;
                        case 2:
                            Q22();
                            break;
                        case 3:
                            Q23();
                            break;
                        case 4:
                            Q24();
                            break;
                    }
                    break;
                case 3:
                    switch (Program.X)
                    {
                        case 0:
                            Q30();
                            break;
                        case 1:
                            Q31();
                            break;
                        case 2:
                            Q32();
                            break;
                        case 3:
                            Q33();
                            break;
                        case 4:
                            Q34();
                            break;
                    }
                    break;
                case 4:
                    switch (Program.X)
                    {
                        case 0:
                            Q40();
                            break;
                        case 1:
                            Q41();
                            break;
                        case 2:
                            Q42();
                            break;
                        case 3:
                            Q43();
                            break;
                        case 4:
                            Q44();
                            break;
                    }
                    break;
            }
        }

        public static int Qselect(string Q1, string Q2)
        {
            int sel = 1;
            bool seling = true;
            string seled = " > ";
            string unseled = "   ";

            while (seling)
            {
                switch (sel)
                {
                    case 1:
                        Console.SetCursorPosition(0, 3);

                        Console.Write(seled + Q1);
                        Console.WriteLine();
                        Console.Write(unseled + Q2);
                        break;
                    case 2:
                        Console.SetCursorPosition(0, 3);

                        Console.Write(unseled + Q1);
                        Console.WriteLine();
                        Console.Write(seled + Q2);
                        break;                   
                }

                ConsoleKey ui = Console.ReadKey(true).Key;

                if ((ui == ConsoleKey.UpArrow || ui == ConsoleKey.W) && sel != 1)
                {
                    sel--;
                }
                if ((ui == ConsoleKey.DownArrow || ui == ConsoleKey.S) && sel != 2)
                {
                    sel++;
                }
                if (ui == ConsoleKey.Enter || ui == ConsoleKey.Spacebar)
                {
                    return sel;
                }
                if (ui == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
            }
            return 0;
        }
        public static int Qselect(string Q1, string Q2, string Q3)
        {
            int sel = 1;
            bool seling = true;
            string seled = " > ";
            string unseled = "   ";

            while (seling)
            {
                switch (sel)
                {
                    case 1:
                        Console.SetCursorPosition(0, 3);

                        Console.Write(seled + Q1);
                        Console.WriteLine();
                        Console.Write(unseled + Q2);
                        Console.WriteLine();
                        Console.Write(unseled + Q3);
                        break;
                    case 2:
                        Console.SetCursorPosition(0, 3);

                        Console.Write(unseled + Q1);
                        Console.WriteLine();
                        Console.Write(seled + Q2);
                        Console.WriteLine();
                        Console.Write(unseled + Q3);
                        break;
                   case 3:
                        Console.SetCursorPosition(0, 3);

                        Console.Write(unseled + Q1);
                        Console.WriteLine();
                        Console.Write(unseled + Q2);
                        Console.WriteLine();
                        Console.Write(seled + Q3);
                        break;
                }

                ConsoleKey ui = Console.ReadKey(true).Key;

                if ((ui == ConsoleKey.UpArrow || ui == ConsoleKey.W) && sel != 1)
                {
                    sel--;
                }
                if ((ui == ConsoleKey.DownArrow || ui == ConsoleKey.S) && sel != 3)
                {
                    sel++;
                }
                if (ui == ConsoleKey.Enter || ui == ConsoleKey.Spacebar)
                {
                    return sel;
                }
                if (ui == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
            }
            return 0;
        }
        public static int Qselect(string Q1, string Q2, string Q3, string Q4)
        {
            int sel = 1;
            bool seling = true;
            string seled = " > ";
            string unseled = "   ";

            while (seling)
            {
                switch (sel)
                {
                    case 1:
                        Console.SetCursorPosition(0, 3);

                        Console.Write(seled + Q1);
                        Console.WriteLine();
                        Console.Write(unseled + Q2);
                        Console.WriteLine();
                        Console.Write(unseled + Q3);
                        Console.WriteLine();
                        Console.Write(unseled + Q4);
                        break;
                    case 2:
                        Console.SetCursorPosition(0, 3);

                        Console.Write(unseled + Q1);
                        Console.WriteLine();
                        Console.Write(seled + Q2);
                        Console.WriteLine();
                        Console.Write(unseled + Q3);
                        Console.WriteLine();
                        Console.Write(unseled + Q4);
                        break;
                    case 3:
                        Console.SetCursorPosition(0, 3);

                        Console.Write(unseled + Q1);
                        Console.WriteLine();
                        Console.Write(unseled + Q2);
                        Console.WriteLine();
                        Console.Write(seled + Q3);
                        Console.WriteLine();
                        Console.Write(unseled + Q4);
                        break;
                    case 4:
                        Console.SetCursorPosition(0, 3);

                        Console.Write(unseled + Q1);
                        Console.WriteLine();
                        Console.Write(unseled + Q2);
                        Console.WriteLine();
                        Console.Write(unseled + Q3);
                        Console.WriteLine();
                        Console.Write(seled + Q4);
                        break;
                }

                ConsoleKey ui = Console.ReadKey(true).Key;

                if ((ui == ConsoleKey.UpArrow || ui == ConsoleKey.W) && sel != 1)
                {
                    sel--;
                }
                if ((ui == ConsoleKey.DownArrow || ui == ConsoleKey.S) && sel != 4)
                {
                    sel++;
                }
                if (ui == ConsoleKey.Enter || ui == ConsoleKey.Spacebar)
                {
                    return sel;
                }
                if (ui == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
            }
            return 0;
        }

        public static void Correct()
        {
            Console.WriteLine("Correct!\n");
            Console.WriteLine("You have $" + Points);
        }
        public static void Wrong(string answer)
        {
            Console.WriteLine("Wrong!\n");
            Console.WriteLine("The correct answer was " + answer + "\n");
            Console.WriteLine("You have $" + Points);

        }

        public static void Q00()
        {
            Console.WriteLine("Two plus two equals what?");
            Console.WriteLine("\n\n");

            int answer = Qselect("5", "8", "2", "4");

            Console.Clear();

            if (answer == 4)
            {
                Points += 100;
                Correct();
            }
            else
            {
                Points +=  -100;
                Wrong("4");
            }
            Console.WriteLine("Press any key to continue...\n");

            ConsoleKey ui = Console.ReadKey(true).Key;

            if (ui == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }
        public static void Q01()
        {
            Console.WriteLine("How do you make green?");
            Console.WriteLine("\n\n");

            int answer = Qselect("Red + Yellow", "Yellow + Blue", "Orange + Teal", "Pink + Green");

            Console.Clear();

            if (answer == 2)
            {
                Points += 100;
                Correct();
            }
            else
            {
                Points += -100;
                Wrong("Yellow + Blue");
            }
            Console.WriteLine("Press any key to continue...\n");

            ConsoleKey ui = Console.ReadKey(true).Key;

            if (ui == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }
        public static void Q02()
        {
            Console.WriteLine("What is earth's gravitational acceloration?");
            Console.WriteLine("\n\n");

            int answer = Qselect("5Mps", "60Mph", "9.8Mps", "9.8Kps");

            Console.Clear();

            if (answer == 3)
            {
                Points += 100;
                Correct();
            }
            else
            {
                Points += -100;
                Wrong("9.8Mps");
            }
            Console.WriteLine("Press any key to continue...\n");

            ConsoleKey ui = Console.ReadKey(true).Key;

            if (ui == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }
        public static void Q03()
        {
            Console.WriteLine("Which animal jumped over the moon?");
            Console.WriteLine("\n\n");

            int answer = Qselect("cat", "cow", "kangaroo", "dog");

            Console.Clear();

            if (answer == 2)
            {
                Points += 100;
                Correct();
            }
            else
            {
                Points += -100;
                Wrong("Cow");
            }
            Console.WriteLine("Press any key to continue...\n");

            ConsoleKey ui = Console.ReadKey(true).Key;

            if (ui == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }
        public static void Q04()
        {
            Console.WriteLine("How many letters in the alphabet?");
            Console.WriteLine("\n\n");

            int answer = Qselect("16", "26", "22", "30");

            Console.Clear();

            if (answer == 2)
            {
                Points += 100;
                Correct();
            }
            else
            {
                Points += -100;
                Wrong("26");
            }
            Console.WriteLine("Press any key to continue...\n");

            ConsoleKey ui = Console.ReadKey(true).Key;

            if (ui == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }
        public static void Q10()
        {
            Console.WriteLine("What is the average outcome of rolling 2 D6 Dice?");
            Console.WriteLine("\n\n");

            int answer = Qselect("6", "6.5", "7", "8");

            Console.Clear();

            if (answer == 3)
            {
                Points += 200;
                Correct();
            }
            else
            {
                Points += -200;
                Wrong("7");
            }
            Console.WriteLine("Press any key to continue...\n");

            ConsoleKey ui = Console.ReadKey(true).Key;

            if (ui == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }
        public static void Q11()
        {
            Console.WriteLine("What letter comes before K?");
            Console.WriteLine("\n\n");

            int answer = Qselect("J", "R", "L", "U");

            Console.Clear();

            if (answer == 1)
            {
                Points += 200;
                Correct();
            }
            else
            {
                Points += -200;
                Wrong("J");
            }
            Console.WriteLine("Press any key to continue...\n");

            ConsoleKey ui = Console.ReadKey(true).Key;

            if (ui == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }
        public static void Q12()
        {
            Console.WriteLine("In the hit book series\"Harry Potter\", Who does snape kill?");
            Console.WriteLine("\n\n");

            int answer = Qselect("Hermione", "Dobby", "Dumbledoor", "Draco");

            Console.Clear();

            if (answer == 3)
            {
                Points += 200;
                Correct();
            }
            else
            {
                Points += -200;
                Wrong("Dumbledoor");
            }
            Console.WriteLine("Press any key to continue...\n");

            ConsoleKey ui = Console.ReadKey(true).Key;

            if (ui == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }
        public static void Q13()
        {
            Console.WriteLine("How many bits in a byte?");
            Console.WriteLine("\n\n");

            int answer = Qselect("4", "8", "16", "64");

            Console.Clear();

            if (answer == 2)
            {
                Points += 200;
                Correct();
            }
            else
            {
                Points += -200;
                Wrong("8");
            }
            Console.WriteLine("Press any key to continue...\n");

            ConsoleKey ui = Console.ReadKey(true).Key;

            if (ui == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }
        public static void Q14()
        {
            Console.WriteLine("What is my name?");
            Console.WriteLine("\n\n");

            int answer = Qselect("My name jeff", "I like turtles", "hide your kids, hide your wives", "I'm the one who knocks");

            Console.Clear();

            if (answer == 1)
            {
                Points += 200;
                Correct();
            }
            else if (answer == 2)
            {
                Points += 200;
                Correct();
            }
            else
            {
                Points += -200;
                Wrong("My name jeff And I like turtles was correct because I want them to be");
            }
            Console.WriteLine("Press any key to continue...\n");

            ConsoleKey ui = Console.ReadKey(true).Key;

            if (ui == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }
        public static void Q20()
        {
            Console.WriteLine("Best selling Videogame console?");
            Console.WriteLine("\n\n");

            int answer = Qselect("Xbox 360", "Atari 2600", "Nintendo DS", "Playstation 2");

            Console.Clear();

            if (answer == 4)
            {
                Points += 300;
                Correct();
            }
            else
            {
                Points += -300;
                Wrong("Playstation 2");
            }
            Console.WriteLine("Press any key to continue...\n");

            ConsoleKey ui = Console.ReadKey(true).Key;

            if (ui == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }
        public static void Q21()
        {
            Console.WriteLine("What year was the original Doom released?");
            Console.WriteLine("\n\n");

            int answer = Qselect("1994", "1999", "1983", "1993");

            Console.Clear();

            if (answer == 4)
            {
                Points += 300;
                Correct();
            }
            else
            {
                Points += -300;
                Wrong("1993");
            }
            Console.WriteLine("Press any key to continue...\n");

            ConsoleKey ui = Console.ReadKey(true).Key;

            if (ui == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }
        public static void Q22()
        {
            Console.WriteLine("Freebie");
            Console.WriteLine("\n\n");

            int answer = Qselect("Nah I don't need points", "Plz no" , "");

            Console.Clear();

            if (answer == 1)
            {
                Points += 300;
                Correct();
            }
            else if (answer == 2)
            {
                Points += 300;
                Correct();
            }
            else
            {
                Points += -300;
                Wrong("It was NO!!! dont be greedy!");
            }
            Console.WriteLine("Press any key to continue...\n");

            ConsoleKey ui = Console.ReadKey(true).Key;

            if (ui == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }
        public static void Q23()
        {
            Console.WriteLine("Who are the big 4 american metal bands?");
            Console.WriteLine("\n\n");

            int answer = Qselect("Death : GWAR : Iron Maiden : Avenge Sevenfold", "Metalica : Slayer : Anthrax : Megadeth", "Deathklok : Mushroomhead : 3 Inches of Blood : Powerwolf", "ManOwar : Black Sabath : Iced Earth : Babymetal");

            Console.Clear();

            if (answer == 2)
            {
                Points += 300;
                Correct();
            }
            else
            {
                Points += -300;
                Wrong("Metalica : Slayer : Anthrax : Megadeth");
            }
            Console.WriteLine("Press any key to continue...\n");

            ConsoleKey ui = Console.ReadKey(true).Key;

            if (ui == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }
        public static void Q24()
        {
            Console.WriteLine("What is the comosition of water?");
            Console.WriteLine("\n\n");

            int answer = Qselect("H2O", "CO2", "H2O2", "SPF");

            Console.Clear();

            if (answer == 1)
            {
                Points += 300;
                Correct();
            }
            else
            {
                Points += -300;
                Wrong("H2O");
            }
            Console.WriteLine("Press any key to continue...\n");

            ConsoleKey ui = Console.ReadKey(true).Key;

            if (ui == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }
        public static void Q30()
        {
            Console.WriteLine("What was the first SCP created?");
            Console.WriteLine("\n\n");

            int answer = Qselect("SCP 001", "SCP 682", "SCP 096", "SCP 173");

            Console.Clear();

            if (answer == 4)
            {
                Points += 400;
                Correct();
            }
            else
            {
                Points += -400;
                Wrong("SCP 173");
            }
            Console.WriteLine("Press any key to continue...\n");

            ConsoleKey ui = Console.ReadKey(true).Key;

            if (ui == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }
        public static void Q31()
        {
            Console.WriteLine("What's the atomic weight of uranium?");
            Console.WriteLine("\n\n");

            int answer = Qselect("92", "235", "238", "146");

            Console.Clear();

            if (answer == 3)
            {
                Points += 400;
                Correct();
            }
            else
            {
                Points += -400;
                Wrong("238.02891");
            }
            Console.WriteLine("Press any key to continue...\n");

            ConsoleKey ui = Console.ReadKey(true).Key;

            if (ui == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }
        public static void Q32()
        {
            Console.WriteLine("(!(!True == True) && (!False || False)) == ((!False == True) && (true == !false && !false == false))");
            Console.WriteLine("\n\n");

            int answer = Qselect("True", "False");

            Console.Clear();

            if (answer == 2)
            {
                Points += 400;
                Correct();
            }
            else
            {
                Points += -400;
                Wrong("False");
            }
            Console.WriteLine("Press any key to continue...\n");

            ConsoleKey ui = Console.ReadKey(true).Key;

            if (ui == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }
        public static void Q33()
        {
            Console.WriteLine("What do each of the set of 2 numbers in a Hex code color stand for? an example is, #649bc5 is  blue-ish");
            Console.WriteLine("\n\n");

            int answer = Qselect("GBR", "BGR", "RGB");

            Console.Clear();

            if (answer == 3)
            {
                Points += 400;
                Correct();
            }
            else
            {
                Points += -400;
                Wrong("RGB");
            }
            Console.WriteLine("Press any key to continue...\n");

            ConsoleKey ui = Console.ReadKey(true).Key;

            if (ui == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }
        public static void Q34()
        {
            Console.WriteLine("What is the Coodinates for the Great Pyrimid of Giza");
            Console.WriteLine("\n\n");

            int answer = Qselect("29.9773 N, 31.1325 E", "29.9792 N, 31.1342 E", "29.9753 N, 31.1376 E", "29.8713 N, 31.2165 E");

            Console.Clear();

            if (answer == 2)
            {
                Points += 400;
                Correct();
            }
            else
            {
                Points += -400;
                Wrong("29.9792 N, 31.1342 E");
            }
            Console.WriteLine("Press any key to continue...\n");

            ConsoleKey ui = Console.ReadKey(true).Key;

            if (ui == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }
        public static void Q40()
        {
            Console.WriteLine("What does Gnarly actaully mean?");
            Console.WriteLine("\n\n");

            int answer = Qselect("Guy Nearly Ate Roaches", "Guess Nobody Actually Really Likes You", "Gaffney's Numerical Assessment of Radness", "Girls Never Associate Reality");

            Console.Clear();

            if (answer == 3)
            {
                Points += 500;
                Correct();
            }
            else
            {
                Points += -500;
                Wrong("Gaffney's Numerical Assessment of Radness");
            }
            Console.WriteLine("Press any key to continue...\n");

            ConsoleKey ui = Console.ReadKey(true).Key;

            if (ui == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }
        public static void Q41()
        {
            Console.WriteLine("How many times have people said \"Your mom\"");
            Console.WriteLine("\n\n");

            int answer = Qselect("9687666", "7234225", "426374475", "33396889");

            Console.Clear();

            if (answer == 1)
            {
                Points += 500;
                Correct();
            }
            else
            {
                Points += -500;
                Wrong("9687666");
            }
            Console.WriteLine("Press any key to continue...\n");

            ConsoleKey ui = Console.ReadKey(true).Key;

            if (ui == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }
        public static void Q42()
        {
            Console.WriteLine("What is the only king in a deck of cards without a mustache");
            Console.WriteLine("\n\n");

            int answer = Qselect("Diamonds", "Clubs", "Spades", "Hearts");

            Console.Clear();

            if (answer == 4)
            {
                Points += 500;
                Correct();
            }
            else
            {
                Points += -500;
                Wrong("Hearts");
            }
            Console.WriteLine("Press any key to continue...\n");

            ConsoleKey ui = Console.ReadKey(true).Key;

            if (ui == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }
        public static void Q43()
        {
            Console.WriteLine("01010111 01101000 01100001 01110100 00100111 01110011 00100000 01110100 01101000 01100101 00100000 01100011 01101100 01101111 01110011 01100101 01110011 01110100 00100000 01110011 01110100 01100001 01110010 00100000 01110011 01111001 01110011 01110100 01100101 01101101 00111111");
            Console.WriteLine("\n\n");

            int answer = Qselect("01010100 01100001 01110101 00100000 01000011 01100101 01110100 01101001 00100000 01010011 01111001 01110011 01110100 01100101 01101101 ", "01010011 01101111 01101100 00100000 01010011 01111001 01110011 01110100 01100101 01101101 ", "01000001 01101100 01110000 01101000 01100001 00100000 01000011 01100101 01101110 01110100 01100001 01110101 01110010 01101001 ", "01010011 01101001 01110010 01101001 01110101 01110011 00100000 01010011 01111001 01110011 01110100 01100101 01101101 ");

            Console.Clear();

            if (answer == 3)
            {
                Points += 500;
                Correct();
            }
            else
            {
                Points += -500;
                Wrong("Alpha Centauri");
            }
            Console.WriteLine("Press any key to continue...\n");

            ConsoleKey ui = Console.ReadKey(true).Key;

            if (ui == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }
        public static void Q44()
        {
            Console.WriteLine("This Statement is false");
            Console.WriteLine("\n\n");

            int answer = Qselect("True", "False", "");

            Console.Clear();

            if (answer == 3)
            {
                Points += 500;
                Correct();
            }
            else
            {
                Points += -500;
                Wrong("It's a paradox Neither are true");
            }
            Console.WriteLine("Press any key to continue...\n");

            ConsoleKey ui = Console.ReadKey(true).Key;

            if (ui == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }
    }
}
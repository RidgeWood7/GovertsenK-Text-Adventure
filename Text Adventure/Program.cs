using Microsoft.VisualBasic;
using System;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

namespace Text_Adventure //Entamaphobia
{
    /*static struct PlayerData
    {
        public int rightChoices;
        public float mana;
        public bool alive;
    }
    */
    internal class Program
    {
        /*
        static 
        */

        static TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

        static void end()
        {
            Thread.Sleep(900);
            Console.Write("\n");
        }//900
        static void comma()
        {
            Thread.Sleep(500);
        }//500
        static void lbl(string text, int delay = 48)//regular w/ dark grey color of text ALL ARE 48 Speed
        {
            text = textInfo.ToTitleCase(text);

            for (int i = 0; i < text.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write(text[i]);
                Thread.Sleep(delay);
            }
        }
        static void plainlbl(string text, int delay = 48)//no color change
        {
            text = textInfo.ToTitleCase(text);

            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);
                Thread.Sleep(delay);
            }
        }
        static void blbl(string text, int delay = 55)//red for blood level
        {
            text = textInfo.ToTitleCase(text);

            for (int i = 0; i < text.Length; i++)
            {
                Console.ForegroundColor= ConsoleColor.DarkRed;                
                Console.Write(text[i]);
                Thread.Sleep(delay);
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }
        }
        static void albl(string text, int delay = 45)//grey for lightbulb level
        {
            text = textInfo.ToTitleCase(text);

            for (int i = 0; i < text.Length; i++)
            {
                Console.ForegroundColor= ConsoleColor.Gray;                
                Console.Write(text[i]);
                Thread.Sleep(delay);
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }
        }
        static void plbl(string text, int delay = 45)//player text
        {
            text = textInfo.ToTitleCase(text);

            for (int i = 0; i < text.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(text[i]);
                Thread.Sleep(delay);
                Console.ForegroundColor= ConsoleColor.DarkGray;
            }
        }
        static public float lightGreen = 0;
        static public float waterGreen = 0;
        static public float bloodGreen = 0;
        static public float clownGreen = 0;


        static void Main(string[] args)
        {
            Console.Beep(100,1000);
            Console.WindowHeight = 20;
            Console.WindowWidth = 150;
            Console.CursorVisible = false;
            intro();
            //start();
            //choice1();
            //lightbulb();
            //win();
        }

        private static void intro()
        {
            Thread.Sleep(3000);
            Console.WriteLine("\n\n\n------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\t\t    ██████  ▒█████   ██▓    ▄▄▄       ██▀███      ██▓ ███▄    █   █████▒██▓ ███▄    █  ██▓▄▄▄█████▓▓██   ██▓\r\n\t\t  ▒██    ▒ ▒██▒  ██▒▓██▒   ▒████▄    ▓██ ▒ ██▒   ▓██▒ ██ ▀█   █ ▓██   ▒▓██▒ ██ ▀█   █ ▓██▒▓  ██▒ ▓▒ ▒██  ██▒\r\n\t\t  ░ ▓██▄   ▒██░  ██▒▒██░   ▒██  ▀█▄  ▓██ ░▄█ ▒   ▒██▒▓██  ▀█ ██▒▒████ ░▒██▒▓██  ▀█ ██▒▒██▒▒ ▓██░ ▒░  ▒██ ██░\r\n\t\t    ▒   ██▒▒██   ██░▒██░   ░██▄▄▄▄██ ▒██▀▀█▄     ░██░▓██▒  ▐▌██▒░▓█▒  ░░██░▓██▒  ▐▌██▒░██░░ ▓██▓ ░   ░ ▐██▓░\r\n\t\t  ▒██████▒▒░ ████▓▒░░██████▒▓█   ▓██▒░██▓ ▒██▒   ░██░▒██░   ▓██░░▒█░   ░██░▒██░   ▓██░░██░  ▒██▒ ░   ░ ██▒▓░\r\n\t\t  ▒ ▒▓▒ ▒ ░░ ▒░▒░▒░ ░ ▒░▓  ░▒▒   ▓▒█░░ ▒▓ ░▒▓░   ░▓  ░ ▒░   ▒ ▒  ▒ ░   ░▓  ░ ▒░   ▒ ▒ ░▓    ▒ ░░      ██▒▒▒ \r\n\t\t  ░ ░▒  ░ ░  ░ ▒ ▒░ ░ ░ ▒  ░ ▒   ▒▒ ░  ░▒ ░ ▒░    ▒ ░░ ░░   ░ ▒░ ░      ▒ ░░ ░░   ░ ▒░ ▒ ░    ░     ▓██ ░▒░ \r\n\t\t  ░  ░  ░  ░ ░ ░ ▒    ░ ░    ░   ▒     ░░   ░     ▒ ░   ░   ░ ░  ░ ░    ▒ ░   ░   ░ ░  ▒ ░  ░       ▒ ▒ ░░  \r\n\t\t        ░      ░ ░      ░  ░     ░  ░   ░         ░           ░         ░           ░  ░            ░ ░     \r\n\t\t                                                                                                    ░ ░     ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------\n\n\n");

            Thread.Sleep(4000);
            Console.Beep(900, 250);
            Console.Write("\n");
            Thread.Sleep(250);
            Console.Beep(750, 250);
            Thread.Sleep(250);
            Console.Beep(900, 250);
            Console.Write("\n");
            Thread.Sleep(250);
            Console.Beep(750, 250);
            Thread.Sleep(250);
            Console.Beep(900, 250);
            Console.Write("\n");
            Thread.Sleep(250);
            Console.Beep(750, 250);
            Thread.Sleep(250);
            Console.Beep(900, 250);
            Console.Write("\n");
            Thread.Sleep(250);
            Console.Beep(750, 250);


            Thread.Sleep(250);
            Console.Beep(900, 250);
            Console.WriteLine("\n\n\n\n\n------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\t\t   ██▒   █▓  ▄████ ▓█████▄     ██▓███   ███▄ ▄███▓    ██▓███   ██▀███   ▒█████   ▄▄▄██▀▀▀▓█████  ▄████▄  ▄▄▄█████▓\r\n\t\t  ▓██░   █▒ ██▒ ▀█▒▒██▀ ██▌   ▓██░  ██▒▓██▒▀█▀ ██▒   ▓██░  ██▒▓██ ▒ ██▒▒██▒  ██▒   ▒██   ▓█   ▀ ▒██▀ ▀█  ▓  ██▒ ▓▒\r\n\t\t   ▓██  █▒░▒██░▄▄▄░░██   █▌   ▓██░ ██▓▒▓██    ▓██░   ▓██░ ██▓▒▓██ ░▄█ ▒▒██░  ██▒   ░██   ▒███   ▒▓█    ▄ ▒ ▓██░ ▒░\r\n\t\t    ▒██ █░░░▓█  ██▓░▓█▄   ▌   ▒██▄█▓▒ ▒▒██    ▒██    ▒██▄█▓▒ ▒▒██▀▀█▄  ▒██   ██░▓██▄██▓  ▒▓█  ▄ ▒▓▓▄ ▄██▒░ ▓██▓ ░ \r\n\t\t     ▒▀█░  ░▒▓███▀▒░▒████▓    ▒██▒ ░  ░▒██▒   ░██▒   ▒██▒ ░  ░░██▓ ▒██▒░ ████▓▒░ ▓███▒   ░▒████▒▒ ▓███▀ ░  ▒██▒ ░ \r\n\t\t     ░ ▐░   ░▒   ▒  ▒▒▓  ▒    ▒▓▒░ ░  ░░ ▒░   ░  ░   ▒▓▒░ ░  ░░ ▒▓ ░▒▓░░ ▒░▒░▒░  ▒▓▒▒░   ░░ ▒░ ░░ ░▒ ▒  ░  ▒ ░░   \r\n\t\t     ░ ░░    ░   ░  ░ ▒  ▒    ░▒ ░     ░  ░      ░   ░▒ ░       ░▒ ░ ▒░  ░ ▒ ▒░  ▒ ░▒░    ░ ░  ░  ░  ▒       ░    \r\n\t\t       ░░  ░ ░   ░  ░ ░  ░    ░░       ░      ░      ░░         ░░   ░ ░ ░ ░ ▒   ░ ░ ░      ░   ░          ░      \r\n\t\t        ░        ░    ░                       ░                  ░         ░ ░   ░   ░      ░  ░░ ░               \r\n\t\t       ░            ░                                                                           ░                 ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------\n");
            Thread.Sleep(250);
            Console.Beep(700, 250);
            Thread.Sleep(250);
            Console.Beep(900, 250);
            Console.Write("\n");
            Thread.Sleep(250);
            Console.Beep(700, 250);
            Thread.Sleep(250);
            Console.Beep(900, 250);
            Console.Write("\n");
            Thread.Sleep(250);
            Console.Beep(700, 250);
            Thread.Sleep(250);
            Console.Beep(900, 250);
            Console.Write("\n");
            Thread.Sleep(250);
            Console.Beep(700, 250);


            Thread.Sleep(250);
            Console.Beep(900, 250);
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\t    ██████ ▄▄▄█████▓ ▒█████   ██▀███ ▓██   ██▓    ▄▄▄▄ ▓██   ██▓    ██ ▄█▀ ██▀███  ▓█████   ██████ ▄▄▄█████▓ ▒█████   ███▄    █ \r\n\t  ▒██    ▒ ▓  ██▒ ▓▒▒██▒  ██▒▓██ ▒ ██▒▒██  ██▒   ▓█████▄▒██  ██▒    ██▄█▒ ▓██ ▒ ██▒▓█   ▀ ▒██    ▒ ▓  ██▒ ▓▒▒██▒  ██▒ ██ ▀█   █ \r\n\t  ░ ▓██▄   ▒ ▓██░ ▒░▒██░  ██▒▓██ ░▄█ ▒ ▒██ ██░   ▒██▒ ▄██▒██ ██░   ▓███▄░ ▓██ ░▄█ ▒▒███   ░ ▓██▄   ▒ ▓██░ ▒░▒██░  ██▒▓██  ▀█ ██▒\r\n\t    ▒   ██▒░ ▓██▓ ░ ▒██   ██░▒██▀▀█▄   ░ ▐██▓░   ▒██░█▀  ░ ▐██▓░   ▓██ █▄ ▒██▀▀█▄  ▒▓█  ▄   ▒   ██▒░ ▓██▓ ░ ▒██   ██░▓██▒  ▐▌██▒\r\n\t  ▒██████▒▒  ▒██▒ ░ ░ ████▓▒░░██▓ ▒██▒ ░ ██▒▓░   ░▓█  ▀█▓░ ██▒▓░   ▒██▒ █▄░██▓ ▒██▒░▒████▒▒██████▒▒  ▒██▒ ░ ░ ████▓▒░▒██░   ▓██░\r\n\t  ▒ ▒▓▒ ▒ ░  ▒ ░░   ░ ▒░▒░▒░ ░ ▒▓ ░▒▓░  ██▒▒▒    ░▒▓███▀▒ ██▒▒▒    ▒ ▒▒ ▓▒░ ▒▓ ░▒▓░░░ ▒░ ░▒ ▒▓▒ ▒ ░  ▒ ░░   ░ ▒░▒░▒░ ░ ▒░   ▒ ▒ \r\n\t  ░ ░▒  ░ ░    ░      ░ ▒ ▒░   ░▒ ░ ▒░▓██ ░▒░    ▒░▒   ░▓██ ░▒░    ░ ░▒ ▒░  ░▒ ░ ▒░ ░ ░  ░░ ░▒  ░ ░    ░      ░ ▒ ▒░ ░ ░░   ░ ▒░\r\n\t  ░  ░  ░    ░      ░ ░ ░ ▒    ░░   ░ ▒ ▒ ░░      ░    ░▒ ▒ ░░     ░ ░░ ░   ░░   ░    ░   ░  ░  ░    ░      ░ ░ ░ ▒     ░   ░ ░ \r\n\t        ░               ░ ░     ░     ░ ░         ░     ░ ░        ░  ░      ░        ░  ░      ░               ░ ░           ░ \r\n                                    ░ ░              ░░ ░                                                                     ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------\n");
            Thread.Sleep(250);
            Console.Beep(750, 250);
            Thread.Sleep(250);
            Console.Beep(900, 250);
            Console.Write("\n");
            Thread.Sleep(250);
            Console.Beep(750, 250);
            Thread.Sleep(250);
            Console.Beep(900, 250);
            Console.Write("\n");
            Thread.Sleep(250);
            Console.Beep(750, 250);
            Thread.Sleep(250);
            Console.Beep(900, 250);
            Console.Write("\n");
            Thread.Sleep(250);
            Console.Beep(750, 250);


            Thread.Sleep(250);
            Console.Beep(900, 250);
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\t ▄████▄   ▒█████  ▓█████▄  ██▓ ███▄    █   ▄████     ▄▄▄▄ ▓██   ██▓    ██ ▄█▀ ██▀███  ▓█████   ██████ ▄▄▄█████▓ ▒█████   ███▄    █ \r\n\t▒██▀ ▀█  ▒██▒  ██▒▒██▀ ██▌▓██▒ ██ ▀█   █  ██▒ ▀█▒   ▓█████▄▒██  ██▒    ██▄█▒ ▓██ ▒ ██▒▓█   ▀ ▒██    ▒ ▓  ██▒ ▓▒▒██▒  ██▒ ██ ▀█   █ \r\n\t▒▓█    ▄ ▒██░  ██▒░██   █▌▒██▒▓██  ▀█ ██▒▒██░▄▄▄░   ▒██▒ ▄██▒██ ██░   ▓███▄░ ▓██ ░▄█ ▒▒███   ░ ▓██▄   ▒ ▓██░ ▒░▒██░  ██▒▓██  ▀█ ██▒\r\n\t▒▓▓▄ ▄██▒▒██   ██░░▓█▄   ▌░██░▓██▒  ▐▌██▒░▓█  ██▓   ▒██░█▀  ░ ▐██▓░   ▓██ █▄ ▒██▀▀█▄  ▒▓█  ▄   ▒   ██▒░ ▓██▓ ░ ▒██   ██░▓██▒  ▐▌██▒\r\n\t▒ ▓███▀ ░░ ████▓▒░░▒████▓ ░██░▒██░   ▓██░░▒▓███▀▒   ░▓█  ▀█▓░ ██▒▓░   ▒██▒ █▄░██▓ ▒██▒░▒████▒▒██████▒▒  ▒██▒ ░ ░ ████▓▒░▒██░   ▓██░\r\n\t░ ░▒ ▒  ░░ ▒░▒░▒░  ▒▒▓  ▒ ░▓  ░ ▒░   ▒ ▒  ░▒   ▒    ░▒▓███▀▒ ██▒▒▒    ▒ ▒▒ ▓▒░ ▒▓ ░▒▓░░░ ▒░ ░▒ ▒▓▒ ▒ ░  ▒ ░░   ░ ▒░▒░▒░ ░ ▒░   ▒ ▒ \r\n\t  ░  ▒     ░ ▒ ▒░  ░ ▒  ▒  ▒ ░░ ░░   ░ ▒░  ░   ░    ▒░▒   ░▓██ ░▒░    ░ ░▒ ▒░  ░▒ ░ ▒░ ░ ░  ░░ ░▒  ░ ░    ░      ░ ▒ ▒░ ░ ░░   ░ ▒░\r\n\t░        ░ ░ ░ ▒   ░ ░  ░  ▒ ░   ░   ░ ░ ░ ░   ░     ░    ░▒ ▒ ░░     ░ ░░ ░   ░░   ░    ░   ░  ░  ░    ░      ░ ░ ░ ▒     ░   ░ ░ \r\n\t░ ░          ░ ░     ░     ░           ░       ░     ░     ░ ░        ░  ░      ░        ░  ░      ░               ░ ░           ░ \r\n\t░                  ░                                      ░░ ░                                                                     ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------\n");
            Thread.Sleep(250);
            Console.Beep(950, 250);
            Thread.Sleep(250);
            Console.Beep(900, 250);
            Console.Write("\n");
            Thread.Sleep(250);
            Console.Beep(950, 250);
            Thread.Sleep(250);
            Console.Beep(900, 250);
            Console.Write("\n");
            Thread.Sleep(250);
            Console.Beep(950, 250);
            Thread.Sleep(250);
            Console.Beep(900, 250);
            Console.Write("\n");
            Thread.Sleep(250);
            Console.Beep(950, 250);


            Thread.Sleep(250);
            Console.Beep(900, 250);
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\t▓█████▄ ▓█████  ▄▄▄▄    █    ██   ▄████   ▄████  ██▓ ███▄    █   ▄████     ▄▄▄▄ ▓██   ██▓   ▓█████▄ ▓█████  ██▀███  ▓█████  ██ ▄█▀\r\n\t▒██▀ ██▌▓█   ▀ ▓█████▄  ██  ▓██▒ ██▒ ▀█▒ ██▒ ▀█▒▓██▒ ██ ▀█   █  ██▒ ▀█▒   ▓█████▄▒██  ██▒   ▒██▀ ██▌▓█   ▀ ▓██ ▒ ██▒▓█   ▀  ██▄█▒ \r\n\t░██   █▌▒███   ▒██▒ ▄██▓██  ▒██░▒██░▄▄▄░▒██░▄▄▄░▒██▒▓██  ▀█ ██▒▒██░▄▄▄░   ▒██▒ ▄██▒██ ██░   ░██   █▌▒███   ▓██ ░▄█ ▒▒███   ▓███▄░ \r\n\t░▓█▄   ▌▒▓█  ▄ ▒██░█▀  ▓▓█  ░██░░▓█  ██▓░▓█  ██▓░██░▓██▒  ▐▌██▒░▓█  ██▓   ▒██░█▀  ░ ▐██▓░   ░▓█▄   ▌▒▓█  ▄ ▒██▀▀█▄  ▒▓█  ▄ ▓██ █▄ \r\n\t░▒████▓ ░▒████▒░▓█  ▀█▓▒▒█████▓ ░▒▓███▀▒░▒▓███▀▒░██░▒██░   ▓██░░▒▓███▀▒   ░▓█  ▀█▓░ ██▒▓░   ░▒████▓ ░▒████▒░██▓ ▒██▒░▒████▒▒██▒ █▄\r\n\t ▒▒▓  ▒ ░░ ▒░ ░░▒▓███▀▒░▒▓▒ ▒ ▒  ░▒   ▒  ░▒   ▒ ░▓  ░ ▒░   ▒ ▒  ░▒   ▒    ░▒▓███▀▒ ██▒▒▒     ▒▒▓  ▒ ░░ ▒░ ░░ ▒▓ ░▒▓░░░ ▒░ ░▒ ▒▒ ▓▒\r\n\t ░ ▒  ▒  ░ ░  ░▒░▒   ░ ░░▒░ ░ ░   ░   ░   ░   ░  ▒ ░░ ░░   ░ ▒░  ░   ░    ▒░▒   ░▓██ ░▒░     ░ ▒  ▒  ░ ░  ░  ░▒ ░ ▒░ ░ ░  ░░ ░▒ ▒░\r\n\t ░ ░  ░    ░    ░    ░  ░░░ ░ ░ ░ ░   ░ ░ ░   ░  ▒ ░   ░   ░ ░ ░ ░   ░     ░    ░▒ ▒ ░░      ░ ░  ░    ░     ░░   ░    ░   ░ ░░ ░ \r\n\t   ░       ░  ░ ░         ░           ░       ░  ░           ░       ░     ░     ░ ░           ░       ░  ░   ░        ░  ░░  ░   \r\n\t ░                   ░                                                          ░░ ░         ░                                    ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------\n");
            Thread.Sleep(250);
            Console.Beep(750, 250);
            Thread.Sleep(250);
            Console.Beep(900, 250);
            Console.Write("\n");
            Thread.Sleep(250);
            Console.Beep(750, 250);
            Thread.Sleep(250);
            Console.Beep(900, 250);
            Console.Write("\n");
            Thread.Sleep(250);
            Console.Beep(750, 250);
            Thread.Sleep(250);
            Console.Beep(900, 250);
            Console.Write("\n");
            Thread.Sleep(250);
            Console.Beep(750, 250);


            Thread.Sleep(250);
            Console.Beep(900, 250);
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("   ▄▄▄       ██▀███  ▄▄▄█████▓    ███▄    █  ▒█████  ▄▄▄█████▓    ▄▄▄▄ ▓██   ██▓    ██ ▄█▀ ██▀███  ▓█████   ██████ ▄▄▄█████▓ ▒█████   ███▄    █ \r\n  ▒████▄    ▓██ ▒ ██▒▓  ██▒ ▓▒    ██ ▀█   █ ▒██▒  ██▒▓  ██▒ ▓▒   ▓█████▄▒██  ██▒    ██▄█▒ ▓██ ▒ ██▒▓█   ▀ ▒██    ▒ ▓  ██▒ ▓▒▒██▒  ██▒ ██ ▀█   █ \r\n  ▒██  ▀█▄  ▓██ ░▄█ ▒▒ ▓██░ ▒░   ▓██  ▀█ ██▒▒██░  ██▒▒ ▓██░ ▒░   ▒██▒ ▄██▒██ ██░   ▓███▄░ ▓██ ░▄█ ▒▒███   ░ ▓██▄   ▒ ▓██░ ▒░▒██░  ██▒▓██  ▀█ ██▒\r\n  ░██▄▄▄▄██ ▒██▀▀█▄  ░ ▓██▓ ░    ▓██▒  ▐▌██▒▒██   ██░░ ▓██▓ ░    ▒██░█▀  ░ ▐██▓░   ▓██ █▄ ▒██▀▀█▄  ▒▓█  ▄   ▒   ██▒░ ▓██▓ ░ ▒██   ██░▓██▒  ▐▌██▒\r\n   ▓█   ▓██▒░██▓ ▒██▒  ▒██▒ ░    ▒██░   ▓██░░ ████▓▒░  ▒██▒ ░    ░▓█  ▀█▓░ ██▒▓░   ▒██▒ █▄░██▓ ▒██▒░▒████▒▒██████▒▒  ▒██▒ ░ ░ ████▓▒░▒██░   ▓██░\r\n   ▒▒   ▓▒█░░ ▒▓ ░▒▓░  ▒ ░░      ░ ▒░   ▒ ▒ ░ ▒░▒░▒░   ▒ ░░      ░▒▓███▀▒ ██▒▒▒    ▒ ▒▒ ▓▒░ ▒▓ ░▒▓░░░ ▒░ ░▒ ▒▓▒ ▒ ░  ▒ ░░   ░ ▒░▒░▒░ ░ ▒░   ▒ ▒ \r\n    ▒   ▒▒ ░  ░▒ ░ ▒░    ░       ░ ░░   ░ ▒░  ░ ▒ ▒░     ░       ▒░▒   ░▓██ ░▒░    ░ ░▒ ▒░  ░▒ ░ ▒░ ░ ░  ░░ ░▒  ░ ░    ░      ░ ▒ ▒░ ░ ░░   ░ ▒░\r\n    ░   ▒     ░░   ░   ░            ░   ░ ░ ░ ░ ░ ▒    ░          ░    ░▒ ▒ ░░     ░ ░░ ░   ░░   ░    ░   ░  ░  ░    ░      ░ ░ ░ ▒     ░   ░ ░ \r\n        ░  ░   ░                          ░     ░ ░               ░     ░ ░        ░  ░      ░        ░  ░      ░               ░ ░           ░ \r\n                                                                       ░░ ░                                                                     ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------\n");
            Thread.Sleep(250);
            Console.Beep(700, 250);
            Thread.Sleep(250);
            Console.Beep(900, 250);
            Console.Write("\n");
            Thread.Sleep(250);
            Console.Beep(700, 250);
            Thread.Sleep(250);
            Console.Beep(900, 250);
            Console.Write("\n");
            Thread.Sleep(250);
            Console.Beep(700, 250);
            Thread.Sleep(250);
            Console.Beep(900, 250);
            Console.Write("\n");
            Thread.Sleep(250);
            Console.Beep(700, 250);


            Thread.Sleep(250);
            Console.Beep(900, 250);
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\t\t ███▄ ▄███▓ █    ██   ██████  ██▓ ▄████▄      ▄▄▄▄ ▓██   ██▓    ██ ▄█▀ ██▀███  ▓█████   ██████ ▄▄▄█████▓ ▒█████   ███▄    █ \r\n\t\t██▒▀█▀ ██▒ ██  ▓██▒▒██    ▒ ▓██▒▒██▀ ▀█     ▓█████▄▒██  ██▒    ██▄█▒ ▓██ ▒ ██▒▓█   ▀ ▒██    ▒ ▓  ██▒ ▓▒▒██▒  ██▒ ██ ▀█   █ \r\n\t\t▓██    ▓██░▓██  ▒██░░ ▓██▄   ▒██▒▒▓█    ▄    ▒██▒ ▄██▒██ ██░   ▓███▄░ ▓██ ░▄█ ▒▒███   ░ ▓██▄   ▒ ▓██░ ▒░▒██░  ██▒▓██  ▀█ ██▒\r\n\t\t▒██    ▒██ ▓▓█  ░██░  ▒   ██▒░██░▒▓▓▄ ▄██▒   ▒██░█▀  ░ ▐██▓░   ▓██ █▄ ▒██▀▀█▄  ▒▓█  ▄   ▒   ██▒░ ▓██▓ ░ ▒██   ██░▓██▒  ▐▌██▒\r\n\t\t▒██▒   ░██▒▒▒█████▓ ▒██████▒▒░██░▒ ▓███▀ ░   ░▓█  ▀█▓░ ██▒▓░   ▒██▒ █▄░██▓ ▒██▒░▒████▒▒██████▒▒  ▒██▒ ░ ░ ████▓▒░▒██░   ▓██░\r\n\t\t░ ▒░   ░  ░░▒▓▒ ▒ ▒ ▒ ▒▓▒ ▒ ░░▓  ░ ░▒ ▒  ░   ░▒▓███▀▒ ██▒▒▒    ▒ ▒▒ ▓▒░ ▒▓ ░▒▓░░░ ▒░ ░▒ ▒▓▒ ▒ ░  ▒ ░░   ░ ▒░▒░▒░ ░ ▒░   ▒ ▒ \r\n\t\t░  ░      ░░░▒░ ░ ░ ░ ░▒  ░ ░ ▒ ░  ░  ▒      ▒░▒   ░▓██ ░▒░    ░ ░▒ ▒░  ░▒ ░ ▒░ ░ ░  ░░ ░▒  ░ ░    ░      ░ ▒ ▒░ ░ ░░   ░ ▒░\r\n\t\t░      ░    ░░░ ░ ░ ░  ░  ░   ▒ ░░            ░    ░▒ ▒ ░░     ░ ░░ ░   ░░   ░    ░   ░  ░  ░    ░      ░ ░ ░ ▒     ░   ░ ░ \r\n\t\t       ░      ░           ░   ░  ░ ░          ░     ░ ░        ░  ░      ░        ░  ░      ░               ░ ░           ░ \r\n\t\t                                 ░                 ░░ ░                                                                     ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------\n");
            Thread.Sleep(250);
            Console.Beep(750, 250);
            Thread.Sleep(250);
            Console.Beep(900, 250);
            Console.Write("\n");
            Thread.Sleep(250);
            Console.Beep(750, 250);
            Thread.Sleep(250);
            Console.Beep(900, 250);
            Console.Write("\n");
            Thread.Sleep(250);
            Console.Beep(750, 250);
            Thread.Sleep(250);
            Console.Beep(900, 250);
            Console.Write("\n");
            Thread.Sleep(250);
            Console.Beep(750, 250);


            Thread.Sleep(250);
            Console.Beep(900, 250);
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\t\t\t ██▓ ███▄    █ ▄▄▄█████▓ ██▀███   ▒█████  ▓█████▄  █    ██  ▄████▄   ██▓ ███▄    █   ▄████ \r\n\t\t\t▓██▒ ██ ▀█   █ ▓  ██▒ ▓▒▓██ ▒ ██▒▒██▒  ██▒▒██▀ ██▌ ██  ▓██▒▒██▀ ▀█  ▓██▒ ██ ▀█   █  ██▒ ▀█▒\r\n\t\t\t▒██▒▓██  ▀█ ██▒▒ ▓██░ ▒░▓██ ░▄█ ▒▒██░  ██▒░██   █▌▓██  ▒██░▒▓█    ▄ ▒██▒▓██  ▀█ ██▒▒██░▄▄▄░\r\n\t\t\t░██░▓██▒  ▐▌██▒░ ▓██▓ ░ ▒██▀▀█▄  ▒██   ██░░▓█▄   ▌▓▓█  ░██░▒▓▓▄ ▄██▒░██░▓██▒  ▐▌██▒░▓█  ██▓\r\n\t\t\t░██░▒██░   ▓██░  ▒██▒ ░ ░██▓ ▒██▒░ ████▓▒░░▒████▓ ▒▒█████▓ ▒ ▓███▀ ░░██░▒██░   ▓██░░▒▓███▀▒\r\n\t\t\t░▓  ░ ▒░   ▒ ▒   ▒ ░░   ░ ▒▓ ░▒▓░░ ▒░▒░▒░  ▒▒▓  ▒ ░▒▓▒ ▒ ▒ ░ ░▒ ▒  ░░▓  ░ ▒░   ▒ ▒  ░▒   ▒ \r\n\t\t\t ▒ ░░ ░░   ░ ▒░    ░      ░▒ ░ ▒░  ░ ▒ ▒░  ░ ▒  ▒ ░░▒░ ░ ░   ░  ▒    ▒ ░░ ░░   ░ ▒░  ░   ░ \r\n\t\t\t ▒ ░   ░   ░ ░   ░        ░░   ░ ░ ░ ░ ▒   ░ ░  ░  ░░░ ░ ░ ░         ▒ ░   ░   ░ ░ ░ ░   ░ \r\n\t\t\t ░           ░             ░         ░ ░     ░       ░     ░ ░       ░           ░       ░ \r\n\t\t\t                                           ░               ░                               ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------\n");
            Thread.Sleep(250);
            Console.Beep(950, 250);
            Thread.Sleep(250);
            Console.Beep(900, 250);
            Console.Write("\n");
            Thread.Sleep(250);
            Console.Beep(950, 250);
            Thread.Sleep(250);
            Console.Beep(900, 250);
            Console.Write("\n");
            Thread.Sleep(250);
            Console.Beep(950, 250);
            Thread.Sleep(250);
            Console.Beep(900, 250);
            Console.Write("\n");
            Thread.Sleep(250);
            Console.Beep(950, 250);
            Thread.Sleep(250);

            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\t\t\t  ██▓███   ██░ ██  ▒█████   ▄▄▄▄    ▒█████   ██▓███   ██░ ██  ▒█████   ▄▄▄▄    ██▓ ▄▄▄      \r\n\t\t\t  ▓██░  ██▒▓██░ ██▒▒██▒  ██▒▓█████▄ ▒██▒  ██▒▓██░  ██▒▓██░ ██▒▒██▒  ██▒▓█████▄ ▓██▒▒████▄    \r\n\t\t\t  ▓██░ ██▓▒▒██▀▀██░▒██░  ██▒▒██▒ ▄██▒██░  ██▒▓██░ ██▓▒▒██▀▀██░▒██░  ██▒▒██▒ ▄██▒██▒▒██  ▀█▄  \r\n\t\t\t  ▒██▄█▓▒ ▒░▓█ ░██ ▒██   ██░▒██░█▀  ▒██   ██░▒██▄█▓▒ ▒░▓█ ░██ ▒██   ██░▒██░█▀  ░██░░██▄▄▄▄██ \r\n\t\t\t  ▒██▒ ░  ░░▓█▒░██▓░ ████▓▒░░▓█  ▀█▓░ ████▓▒░▒██▒ ░  ░░▓█▒░██▓░ ████▓▒░░▓█  ▀█▓░██░ ▓█   ▓██▒\r\n\t\t\t  ▒▓▒░ ░  ░ ▒ ░░▒░▒░ ▒░▒░▒░ ░▒▓███▀▒░ ▒░▒░▒░ ▒▓▒░ ░  ░ ▒ ░░▒░▒░ ▒░▒░▒░ ░▒▓███▀▒░▓   ▒▒   ▓▒█░\r\n\t\t\t  ░▒ ░      ▒ ░▒░ ░  ░ ▒ ▒░ ▒░▒   ░   ░ ▒ ▒░ ░▒ ░      ▒ ░▒░ ░  ░ ▒ ▒░ ▒░▒   ░  ▒ ░  ▒   ▒▒ ░\r\n\t\t\t  ░░        ░  ░░ ░░ ░ ░ ▒   ░    ░ ░ ░ ░ ▒  ░░        ░  ░░ ░░ ░ ░ ▒   ░    ░  ▒ ░  ░   ▒   \r\n\t\t\t            ░  ░  ░    ░ ░   ░          ░ ░            ░  ░  ░    ░ ░   ░       ░        ░  ░\r\n\t\t\t                                  ░                                          ░               ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------\n\n\n");

            Console.Beep(600, 3000);

            start();//Game Start
        }

        private static void start()
        {
            Thread.Sleep(400);
            Console.Clear();
            Thread.Sleep(3500);


            lbl("Hello..."); Thread.Sleep(1700);
            lbl("\nWhat brings you here?"); end();
            lbl("Don't answer that!", 30); Thread.Sleep(100); lbl(" We have not much time,"); Thread.Sleep(70); lbl(" and so much fun!"); end();
            lbl("Who am I?"); comma(); lbl(" That's not important..."); end();
            lbl("The real question at hand..."); comma(); lbl(" is simple..."); end();
            lbl("What Room Do You DARE Enter On This "); Thread.Sleep(800); Console.Write("Cold, "); Thread.Sleep(800); Console.Write("Dark, "); Thread.Sleep(800); Console.Write("Rainy, "); Thread.Sleep(500);  Console.Write("Day...\n\n");
            Thread.Sleep(1000);
            prechoice();
        }
        private static void prechoice()
        {
            if (lightGreen == 1 && waterGreen == 1 && bloodGreen == 1)
            {
                win();
            }
            else
            {
                choice1();
            }
        }
        private static void choice1()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Beep(700, 200);
            Console.Write("[d]  The Dark Room With The "); Console.ForegroundColor = ConsoleColor.DarkBlue; Console.Write("Water"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine(textInfo.ToTitleCase(" On The Floor\n"));
            Thread.Sleep(2000);
            Console.Beep(700, 200);
            Console.Write("[l]  The Room With Just A "); Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Lightbulb\n"); Console.ForegroundColor = ConsoleColor.DarkGray;
            Thread.Sleep(2000);
            Console.Beep(97, 350);
            Console.Write("[b]  The "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("Bloody"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine(" Room\n");
            /*Thread.Sleep(2000);
            Console.Beep(700, 200);
            Console.Write("[c]  The "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("C"); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("l"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("o"); Console.ForegroundColor = ConsoleColor.Blue; Console.Write("w"); Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.Write("n"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(" Room\n\n");
            */
            Thread.Sleep(500);
            Console.Write("  .   .   .  ");
            Console.ForegroundColor = ConsoleColor.Black;

            char input = Console.ReadKey().KeyChar;
            if (input == 'd')
            {
                Console.Clear();
                lbl("\n\nYou Enter The Dark Room With The "); Console.ForegroundColor = ConsoleColor.DarkBlue; plainlbl("Water"); Console.ForegroundColor = ConsoleColor.DarkGray; lbl(" On The Floor\n");
                Thread.Sleep(2500);
                lbl("\n\nYou Step Inside And Notice That There Was Never A Door..."); end();
                plbl("\"How?\""); comma();
                lbl(" you ask yourself, "); comma(); lbl("but then quickly focus on the insane sight you see..."); end();
                lbl("you are inside of a glass room,"); comma(); lbl(" and you are seemingly in the bottom of the ocean..."); end();
                lbl("you look in front of you,"); comma(); lbl(" and see a lever that is about 100 feet in front of you..."); end();
                lbl("you then see that there is a dripping comming from the roof,"); comma(); lbl(" causing the water to collect on the floor."); end();
                lbl("you look up at the sight at hand, "); comma(); lbl("and you can't believe it..."); end();
                lbl("it's a dead shark on top of the cracked glass roof..."); end();
                lbl("you stare for just a second, "); comma(); lbl("but then realize that you have to make a choice quickly..."); end();
                lbl("\n\nDo you:"); end();
                lbl("run for the lever and hope it fixes you situation <-[r]---[h]-> or hold the glass from breaking any further"); end();

                Thread.Sleep(500);
                water();
            }//
            else if (input == 'l')
            {
                Console.Clear();
                lbl("You Enter The Room With Just A "); Console.ForegroundColor = ConsoleColor.Yellow; plainlbl("Lightbulb");
                Thread.Sleep(2500);
                lbl("\n\nYou Step Inside And Notice That There Was Never A Door..."); end();
                plbl("\"How?\""); comma();
                lbl(" you ask yourself, "); comma(); lbl("but then quickly focus on a vivid sound you hear..."); end();
                plbl("\"That was weird...\""); end();
                lbl("While trying to figure out what you heard, "); comma(); lbl("you notice that there is a soft wavy fabric making up what is the wall in front of you."); end();
                lbl("With the dim lighting from the lightbulb, "); Thread.Sleep(500); lbl("you can see that the fabric is some sort of "); Console.ForegroundColor = ConsoleColor.DarkRed; plainlbl("Dark Red"); lbl(" color."); end();
                lbl("Suddenly you hear the sound again,"); Thread.Sleep(500); lbl(" but this time you can clearly hear it..."); end();
                lbl("The sound is a booming voice, "); comma(); lbl("on what seems to be a giant sound system..."); end();
                albl("\"I know you guys have not had the best experience today,"); comma(); albl(" but this next act should be the best performance you have "); Thread.Sleep(200); albl("EVER "); Thread.Sleep(200); albl("seen\""); end();
                lbl("You now quickly undurestand that this \"room\" you're in,"); comma(); lbl(" is actually a stage."); end();
                lbl("your body pulses with chills from your legs up to your neck..."); end();
                plbl("\"Oh no...\""); end();
                lbl("You're reminded of the time when your childhood thearapist diagnosed you with Glossophobia."); end();
                lbl("Before you can even move as much as one muscle,"); comma(); lbl(" the curtain splits into two,"); comma(); lbl(" presenting you to the audience."); end();
                lbl("For a short period of time,"); comma(); lbl(" you are blinded by the stage lights blaring into your eyes."); end();
                lbl("After your eyes adjust to the lighting,"); comma(); lbl(" and you take a look around."); end();
                lbl("you can feel your heart beating through your chest once you see the stern,"); comma(); lbl(" unpleased, "); comma(); lbl("judgemental crowd that clearly,"); comma(); lbl("\nas the announcer had said, "); comma(); lbl("has not had the best experience today."); end();
                albl("\"Let's give our new host a round of applause,"); comma(); albl(" shall we?\""); end();
                lbl("\n\nYou are now stuck with the following options:"); end(); lbl("say nothing <-[n]---[j]-> "); lbl("or start telling some jokes already"); end();
                
                Thread.Sleep(500);
                Console.ForegroundColor = ConsoleColor.Black;
                lightbulb();
            }//
            else if (input == 'b')
            {
                Console.Clear();
                lbl("\n\nYou Enter The "); Console.ForegroundColor = ConsoleColor.Red; plainlbl("Bloody"); Console.ForegroundColor = ConsoleColor.DarkGray; lbl(" Room\n");
                Thread.Sleep(2500);
                lbl("\n\nYou Step Inside And Notice That There Was Never A Door..."); end();
                plbl("\"How?\""); comma();
                lbl(" you ask yourself, "); comma(); lbl("but quickly focus on the man you notice in the corner..."); end();
                plbl("\"who are you?\""); end();
                blbl("\"that is not important young blood, "); comma(); blbl("there are much more important questions to be asked...\""); end();
                plbl("\"uuuummmmmm, "); comma(); plbl("like what?\""); end();
                lbl("he stares blankly for a while, "); comma(); lbl("but then clocks back into this world..."); end();
                blbl("\"what is your blood type?\""); comma(); lbl(" he says ignoring your question..."); end();
                plbl("\"uuummmm, "); comma(); plbl("b positive I guess...\""); end();
                blbl("\"wrong!\""); comma(); blbl("\"you are an A negative\""); end();
                blbl("\"now answer me this...\""); comma(); lbl("\"whill you please commit this small blood oath?\""); end();
                lbl("\n\nYou are now stuck with the following options:"); end(); lbl("say no <-[n]---[y]-> "); lbl("or say yes"); end();

                Thread.Sleep(500);
                blood();
            }
            else if (input == 'c')
            {
                Console.Clear();
                lbl("\n\nYou Enter The "); Thread.Sleep(48); Console.ForegroundColor = ConsoleColor.Red; Console.Write("C"); Thread.Sleep(48); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("l"); Thread.Sleep(48); Console.ForegroundColor = ConsoleColor.Green; Console.Write("o"); Thread.Sleep(48); Console.ForegroundColor = ConsoleColor.Blue; Console.Write("w"); Thread.Sleep(48); Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.Write("n"); Thread.Sleep(48); Console.ForegroundColor = ConsoleColor.DarkGray; lbl(" Room\n\n");
                Thread.Sleep(2500);
                lbl("\n\nYou Step Inside And Notice That There Was Never A Door..."); end();
                plbl("\"How?\""); comma();
                lbl(" you ask yourself, "); comma(); lbl(""); end();

                Thread.Sleep(500);
                clown();
            }
            else
            {
                choice1();
            }
        }


        //--------------------------------------------------------------------------------------------------------------------------------------------------
        private static void water()
        {
            char input = Console.ReadKey().KeyChar;
            if (input == 'h')
            {
                lbl("\n\nyou attempt to save yourself from the water leak, "); comma(); lbl("but it's too late..."); end();
                lbl("the water comes crashing down on you, "); comma(); lbl("and the dead sharks body crushes you..."); end();
                
                Thread.Sleep(1000);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n\n\n------------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("▄▄▄█████▓ ██░ ██  ▄▄▄       ██▓    ▄▄▄        ██████   ██████  ▒█████   ██▓███   ██░ ██  ▒█████   ▄▄▄▄    ██▓ ▄▄▄      \r\n▓  ██▒ ▓▒▓██░ ██▒▒████▄    ▓██▒   ▒████▄    ▒██    ▒ ▒██    ▒ ▒██▒  ██▒▓██░  ██▒▓██░ ██▒▒██▒  ██▒▓█████▄ ▓██▒▒████▄    \r\n▒ ▓██░ ▒░▒██▀▀██░▒██  ▀█▄  ▒██░   ▒██  ▀█▄  ░ ▓██▄   ░ ▓██▄   ▒██░  ██▒▓██░ ██▓▒▒██▀▀██░▒██░  ██▒▒██▒ ▄██▒██▒▒██  ▀█▄  \r\n░ ▓██▓ ░ ░▓█ ░██ ░██▄▄▄▄██ ▒██░   ░██▄▄▄▄██   ▒   ██▒  ▒   ██▒▒██   ██░▒██▄█▓▒ ▒░▓█ ░██ ▒██   ██░▒██░█▀  ░██░░██▄▄▄▄██ \r\n  ▒██▒ ░ ░▓█▒░██▓ ▓█   ▓██▒░██████▒▓█   ▓██▒▒██████▒▒▒██████▒▒░ ████▓▒░▒██▒ ░  ░░▓█▒░██▓░ ████▓▒░░▓█  ▀█▓░██░ ▓█   ▓██▒\r\n  ▒ ░░    ▒ ░░▒░▒ ▒▒   ▓▒█░░ ▒░▓  ░▒▒   ▓▒█░▒ ▒▓▒ ▒ ░▒ ▒▓▒ ▒ ░░ ▒░▒░▒░ ▒▓▒░ ░  ░ ▒ ░░▒░▒░ ▒░▒░▒░ ░▒▓███▀▒░▓   ▒▒   ▓▒█░\r\n    ░     ▒ ░▒░ ░  ▒   ▒▒ ░░ ░ ▒  ░ ▒   ▒▒ ░░ ░▒  ░ ░░ ░▒  ░ ░  ░ ▒ ▒░ ░▒ ░      ▒ ░▒░ ░  ░ ▒ ▒░ ▒░▒   ░  ▒ ░  ▒   ▒▒ ░\r\n  ░       ░  ░░ ░  ░   ▒     ░ ░    ░   ▒   ░  ░  ░  ░  ░  ░  ░ ░ ░ ▒  ░░        ░  ░░ ░░ ░ ░ ▒   ░    ░  ▒ ░  ░   ▒   \r\n          ░  ░  ░      ░  ░    ░  ░     ░  ░      ░        ░      ░ ░            ░  ░  ░    ░ ░   ░       ░        ░  ░\r\n                                                                                                       ░               ");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------");

                Thread.Sleep(500);
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else if (input == 'r')
            {
                lbl("you sprint for the lever, "); comma(); lbl("and as you are running, "); comma(); lbl("the glass breaks behind you..."); end();
                lbl("you hear the crashing sound behind you, "); comma(); lbl("and you feel the water rushing under your feet."); end();
                lbl("as you finally reach the lever, "); comma(); lbl("the water reaches up to your knees..."); end();
                lbl("you switch the lever,"); comma(); lbl(" and the water drains..."); end();
                lbl("you then notice a light on the floor thats just has turned green,"); comma(); lbl(" and you instantly teleport back to the main room..."); end();
                waterGreen = 1;
                prechoice();
            }
            else
            {
                water();
            }
        }//
        private static void lightbulb()
        {
            char input = Console.ReadKey().KeyChar;
            if (input == 'n')
            {
                lbl("\n\nYou freeze in terror,"); comma(); lbl(" not knowing what to say..."); end();
                albl("\"Well..."); comma(); albl(" why am i not surprised...\""); end();
                lbl("The crowd remains quiet,"); comma(); lbl(" but the tension rises from 0 to 100 within miliseconds"); end();
                albl("\"Looks like we got annother quitter on our hands,"); comma(); albl(" let's show them the way out...\""); end();
                lbl("you hear a faint click,"); comma(); lbl(" and the floor below you divides into two."); end();
                lbl("you fall for a solid ten seconds,"); comma(); lbl(" and your mind falls into the darkness"); end();
                Thread.Sleep(1000); 
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n\n\n------------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("\t\t\t  ▄████  ██▓     ▒█████    ██████   ██████  ▒█████   ██▓███   ██░ ██  ▒█████   ▄▄▄▄    ██▓ ▄▄▄      \r\n\t\t\t ██▒ ▀█▒▓██▒    ▒██▒  ██▒▒██    ▒ ▒██    ▒ ▒██▒  ██▒▓██░  ██▒▓██░ ██▒▒██▒  ██▒▓█████▄ ▓██▒▒████▄    \r\n\t\t\t▒██░▄▄▄░▒██░    ▒██░  ██▒░ ▓██▄   ░ ▓██▄   ▒██░  ██▒▓██░ ██▓▒▒██▀▀██░▒██░  ██▒▒██▒ ▄██▒██▒▒██  ▀█▄  \r\n\t\t\t░▓█  ██▓▒██░    ▒██   ██░  ▒   ██▒  ▒   ██▒▒██   ██░▒██▄█▓▒ ▒░▓█ ░██ ▒██   ██░▒██░█▀  ░██░░██▄▄▄▄██ \r\n\t\t\t░▒▓███▀▒░██████▒░ ████▓▒░▒██████▒▒▒██████▒▒░ ████▓▒░▒██▒ ░  ░░▓█▒░██▓░ ████▓▒░░▓█  ▀█▓░██░ ▓█   ▓██▒\r\n\t\t\t ░▒   ▒ ░ ▒░▓  ░░ ▒░▒░▒░ ▒ ▒▓▒ ▒ ░▒ ▒▓▒ ▒ ░░ ▒░▒░▒░ ▒▓▒░ ░  ░ ▒ ░░▒░▒░ ▒░▒░▒░ ░▒▓███▀▒░▓   ▒▒   ▓▒█░\r\n\t\t\t  ░   ░ ░ ░ ▒  ░  ░ ▒ ▒░ ░ ░▒  ░ ░░ ░▒  ░ ░  ░ ▒ ▒░ ░▒ ░      ▒ ░▒░ ░  ░ ▒ ▒░ ▒░▒   ░  ▒ ░  ▒   ▒▒ ░\r\n\t\t\t░ ░   ░   ░ ░   ░ ░ ░ ▒  ░  ░  ░  ░  ░  ░  ░ ░ ░ ▒  ░░        ░  ░░ ░░ ░ ░ ▒   ░    ░  ▒ ░  ░   ▒   \r\n\t\t\t      ░     ░  ░    ░ ░        ░        ░      ░ ░            ░  ░  ░    ░ ░   ░       ░        ░  ░\r\n\t\t\t                                                                                    ░               ");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------");

                Thread.Sleep(500);
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else if (input == 'j')
            {
                lbl("\n\ntype joke here --->  ");

                joke();
            }
            else
            {
                lightbulb();
            }
        }//
        private static void blood()//
        {
            char input = Console.ReadKey().KeyChar;
            if (input == 'y')
            {
                lbl("NO!"); end();
                lbl("never ever ever do blood oaths with stangers."); end();
                lbl("only friends!"); end();
                Thread.Sleep(1000);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n\n\n------------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("\t\t\t ██░ ██ ▓█████  ███▄ ▄███▓ ▒█████   ██▓███   ██░ ██  ▒█████   ▄▄▄▄    ██▓ ▄▄▄      \r\n\t\t\t▓██░ ██▒▓█   ▀ ▓██▒▀█▀ ██▒▒██▒  ██▒▓██░  ██▒▓██░ ██▒▒██▒  ██▒▓█████▄ ▓██▒▒████▄    \r\n\t\t\t▒██▀▀██░▒███   ▓██    ▓██░▒██░  ██▒▓██░ ██▓▒▒██▀▀██░▒██░  ██▒▒██▒ ▄██▒██▒▒██  ▀█▄  \r\n\t\t\t░▓█ ░██ ▒▓█  ▄ ▒██    ▒██ ▒██   ██░▒██▄█▓▒ ▒░▓█ ░██ ▒██   ██░▒██░█▀  ░██░░██▄▄▄▄██ \r\n\t\t\t░▓█▒░██▓░▒████▒▒██▒   ░██▒░ ████▓▒░▒██▒ ░  ░░▓█▒░██▓░ ████▓▒░░▓█  ▀█▓░██░ ▓█   ▓██▒\r\n\t\t\t ▒ ░░▒░▒░░ ▒░ ░░ ▒░   ░  ░░ ▒░▒░▒░ ▒▓▒░ ░  ░ ▒ ░░▒░▒░ ▒░▒░▒░ ░▒▓███▀▒░▓   ▒▒   ▓▒█░\r\n\t\t\t ▒ ░▒░ ░ ░ ░  ░░  ░      ░  ░ ▒ ▒░ ░▒ ░      ▒ ░▒░ ░  ░ ▒ ▒░ ▒░▒   ░  ▒ ░  ▒   ▒▒ ░\r\n\t\t\t ░  ░░ ░   ░   ░      ░   ░ ░ ░ ▒  ░░        ░  ░░ ░░ ░ ░ ▒   ░    ░  ▒ ░  ░   ▒   \r\n\t\t\t ░  ░  ░   ░  ░       ░       ░ ░            ░  ░  ░    ░ ░   ░       ░        ░  ░\r\n\t\t\t                                                                   ░               ");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------");

                Thread.Sleep(500);
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else if (input == 'n')
            {
                lbl("Good job!"); end();
                lbl("never ever ever do blood oaths with stangers."); end();
                lbl("only friends!"); end();
                lbl("you then notice a green light turn on in the corner of the room,"); comma(); lbl(" and you instantly teleport back to the main room..."); end();
                bloodGreen = 1;
                prechoice();
            }
            else
            {
                blood();
            }
        }
        private static void clown()
        {
            char input = Console.ReadKey().KeyChar;
            if (input == '-')
            {
                lbl("\n\n,"); comma(); lbl(""); end();
                
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n\n\n------------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("\t\t ▄████▄   ▒█████   █    ██  ██▓     ██▀███   ▒█████   ██▓███   ██░ ██  ▒█████   ▄▄▄▄    ██▓ ▄▄▄      \r\n\t\t▒██▀ ▀█  ▒██▒  ██▒ ██  ▓██▒▓██▒    ▓██ ▒ ██▒▒██▒  ██▒▓██░  ██▒▓██░ ██▒▒██▒  ██▒▓█████▄ ▓██▒▒████▄    \r\n\t\t▒▓█    ▄ ▒██░  ██▒▓██  ▒██░▒██░    ▓██ ░▄█ ▒▒██░  ██▒▓██░ ██▓▒▒██▀▀██░▒██░  ██▒▒██▒ ▄██▒██▒▒██  ▀█▄  \r\n\t\t▒▓▓▄ ▄██▒▒██   ██░▓▓█  ░██░▒██░    ▒██▀▀█▄  ▒██   ██░▒██▄█▓▒ ▒░▓█ ░██ ▒██   ██░▒██░█▀  ░██░░██▄▄▄▄██ \r\n\t\t▒ ▓███▀ ░░ ████▓▒░▒▒█████▓ ░██████▒░██▓ ▒██▒░ ████▓▒░▒██▒ ░  ░░▓█▒░██▓░ ████▓▒░░▓█  ▀█▓░██░ ▓█   ▓██▒\r\n\t\t░ ░▒ ▒  ░░ ▒░▒░▒░ ░▒▓▒ ▒ ▒ ░ ▒░▓  ░░ ▒▓ ░▒▓░░ ▒░▒░▒░ ▒▓▒░ ░  ░ ▒ ░░▒░▒░ ▒░▒░▒░ ░▒▓███▀▒░▓   ▒▒   ▓▒█░\r\n\t\t  ░  ▒     ░ ▒ ▒░ ░░▒░ ░ ░ ░ ░ ▒  ░  ░▒ ░ ▒░  ░ ▒ ▒░ ░▒ ░      ▒ ░▒░ ░  ░ ▒ ▒░ ▒░▒   ░  ▒ ░  ▒   ▒▒ ░\r\n\t\t░        ░ ░ ░ ▒   ░░░ ░ ░   ░ ░     ░░   ░ ░ ░ ░ ▒  ░░        ░  ░░ ░░ ░ ░ ▒   ░    ░  ▒ ░  ░   ▒   \r\n\t\t░ ░          ░ ░     ░         ░  ░   ░         ░ ░            ░  ░  ░    ░ ░   ░       ░        ░  ░\r\n\t\t░                                                                                    ░               ");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------");

                Thread.Sleep(500);
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else if (input == '-')
            {
                lbl(", "); comma(); lbl(""); end();
                lbl("you then notice a green light turn on ----------,"); comma(); lbl(" and you instantly teleport back to the main room..."); end();
                clownGreen = 1;
                prechoice();
            }
        }
        private static void joke()
        {
            String input = Console.ReadLine();
            if (input == "no")
            {
                lbl("\n\nYou freeze in terror,"); comma(); lbl(" not knowing what to say..."); end();
                albl("\"Well..."); comma(); albl(" why am i not surprised...\""); end();
                lbl("The crowd remains quiet,"); comma(); lbl(" but the tension rises from 0 to 100 within miliseconds"); end();
                albl("\"Looks like we got annother quitter on our hands,"); comma(); albl(" let's show them the way out...\""); end();
                lbl("you hear a faint click,"); comma(); lbl(" and the floor below you divides into two."); end();
                lbl("you fall for a solid ten seconds,"); comma(); lbl(" and your mind falls into the darkness"); end();
                Thread.Sleep(1000);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n\n\n------------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("\t\t\t  ▄████  ██▓     ▒█████    ██████   ██████  ▒█████   ██▓███   ██░ ██  ▒█████   ▄▄▄▄    ██▓ ▄▄▄      \r\n\t\t\t ██▒ ▀█▒▓██▒    ▒██▒  ██▒▒██    ▒ ▒██    ▒ ▒██▒  ██▒▓██░  ██▒▓██░ ██▒▒██▒  ██▒▓█████▄ ▓██▒▒████▄    \r\n\t\t\t▒██░▄▄▄░▒██░    ▒██░  ██▒░ ▓██▄   ░ ▓██▄   ▒██░  ██▒▓██░ ██▓▒▒██▀▀██░▒██░  ██▒▒██▒ ▄██▒██▒▒██  ▀█▄  \r\n\t\t\t░▓█  ██▓▒██░    ▒██   ██░  ▒   ██▒  ▒   ██▒▒██   ██░▒██▄█▓▒ ▒░▓█ ░██ ▒██   ██░▒██░█▀  ░██░░██▄▄▄▄██ \r\n\t\t\t░▒▓███▀▒░██████▒░ ████▓▒░▒██████▒▒▒██████▒▒░ ████▓▒░▒██▒ ░  ░░▓█▒░██▓░ ████▓▒░░▓█  ▀█▓░██░ ▓█   ▓██▒\r\n\t\t\t ░▒   ▒ ░ ▒░▓  ░░ ▒░▒░▒░ ▒ ▒▓▒ ▒ ░▒ ▒▓▒ ▒ ░░ ▒░▒░▒░ ▒▓▒░ ░  ░ ▒ ░░▒░▒░ ▒░▒░▒░ ░▒▓███▀▒░▓   ▒▒   ▓▒█░\r\n\t\t\t  ░   ░ ░ ░ ▒  ░  ░ ▒ ▒░ ░ ░▒  ░ ░░ ░▒  ░ ░  ░ ▒ ▒░ ░▒ ░      ▒ ░▒░ ░  ░ ▒ ▒░ ▒░▒   ░  ▒ ░  ▒   ▒▒ ░\r\n\t\t\t░ ░   ░   ░ ░   ░ ░ ░ ▒  ░  ░  ░  ░  ░  ░  ░ ░ ░ ▒  ░░        ░  ░░ ░░ ░ ░ ▒   ░    ░  ▒ ░  ░   ▒   \r\n\t\t\t      ░     ░  ░    ░ ░        ░        ░      ░ ░            ░  ░  ░    ░ ░   ░       ░        ░  ░\r\n\t\t\t                                                                                    ░               ");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------");

                Thread.Sleep(500);
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else
            {
                lbl("the crowd stares at you, "); comma(); lbl("but seems glad that you had the guts to even speak."); end();
                lbl("you then notice a green light turn on in the distance,"); comma(); lbl(" and you instantly teleport back to the main room..."); end();
                lightGreen = 1;
                prechoice();
            }
        }//
        private static void win()
        {
            Console.Clear(); Thread.Sleep(2000);
            lbl("wow,"); comma(); lbl(" you did it..."); end();
            lbl("you're no longer afraid..."); comma(); lbl(" of anything..."); end();
            lbl("you win..."); comma(); lbl(" I guess..."); end();
            Thread.Sleep(1000);
            Console.WriteLine("\n\n\n------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\t\t\t\t▄▄▄█████▓ ██░ ██ ▓█████    ▓█████  ███▄    █ ▓█████▄ \r\n\t\t\t\t▓  ██▒ ▓▒▓██░ ██▒▓█   ▀    ▓█   ▀  ██ ▀█   █ ▒██▀ ██▌\r\n\t\t\t\t▒ ▓██░ ▒░▒██▀▀██░▒███      ▒███   ▓██  ▀█ ██▒░██   █▌\r\n\t\t\t\t░ ▓██▓ ░ ░▓█ ░██ ▒▓█  ▄    ▒▓█  ▄ ▓██▒  ▐▌██▒░▓█▄   ▌\r\n\t\t\t\t  ▒██▒ ░ ░▓█▒░██▓░▒████▒   ░▒████▒▒██░   ▓██░░▒████▓ \r\n\t\t\t\t  ▒ ░░    ▒ ░░▒░▒░░ ▒░ ░   ░░ ▒░ ░░ ▒░   ▒ ▒  ▒▒▓  ▒ \r\n\t\t\t\t    ░     ▒ ░▒░ ░ ░ ░  ░    ░ ░  ░░ ░░   ░ ▒░ ░ ▒  ▒ \r\n\t\t\t\t  ░       ░  ░░ ░   ░         ░      ░   ░ ░  ░ ░  ░ \r\n\t\t\t\t          ░  ░  ░   ░  ░      ░  ░         ░    ░    \r\n\t\t\t\t                                              ░      ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------");

            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.Black;
        }//

        /*Casting


        //type casting

        static double my8ByteNumber = 7.123456789;

        static float my4ByteNumber = (float)my8ByteNumber;

        int my4ByteInteger = (int)my8ByteNumber;

        //System.Convert

        float my4ByteNumberAgain = Convert.ToSingle(my4ByteNumber); //single is annother name for float

        int my4ByteIntegerAgain = Convert.ToInt32(my8ByteNumber);
        --------------------------------------------------------------------------------------------------------------------------------------------------
        */
        /*Operators (+ - / *)
         * Operands: what you are operating
         
         *Arithmetic Operators (+, -, /, *,) {+=, -=, /=, *=} ({++, --}) [ints, floats, doubles]
        
        int a = 13;
        int b = 5;
        int c = a () b;

        int d = 40;
        d {} 7;                         ex: d=d+7 SAME AS d+=7

        int f = 9;
        f({});
        ({})f;

        string a = "my name is"
        string b = " Kreston"

        string message = a + b;


         *Comparison Operators (<, >) {<=, >=} [!=, ==]
        
        int yay = 4;
        int nay = 3;

        bool yayOrNay = yay () nay;                          [when you write this, it will say "true" or "false"]
        bool yayOrNay = yay {} nay;                          [when you write this, it will say "true" or "false"]
        bool yayOrNay = yay [] nay;                          [when you write this, it will say "true" or "false"]

        Ex: bool nayOrYay = yay >= nay; ~ true

         *Boolean Logic Operators (&&)and {||}or [!]not

        Bool microsoftIsCool = true;
        Bool applePhonesAreCool = true;
        Bool appleComputersAreCool = false;
        
        Bool allAreTrue = microsoftIsCool && applePhonesAreCool && appleComputersAreCool; ~ false
        Bool oneIsCool = microsoftIsCool || applePhonesAreCool || appleComputersAreCool; ~ true
        Bool noneAreCool = !microsoftIsCool; ~ false

         
        */
        /*Structs
        
        */
    }
}




/*-----------------------------------------------------------------------------------------------------------------------------------------------------------------
Notes:

Console.Beep(freq, *);*1000 = 1 sec                                                                                      ---    Beep
Thread.Sleep(*);*1000 = 1 sec                                                                                            ---    Stops writing for an amount of time
Console.BackgroundColor = ConsoleColor.*;*color                                                                          ---    Background Color for text
Console.ForegroundColor = ConsoleColor.*;*color                                                                          ---    Color of text
Console.WriteLine("*");*text                                                                                             ---    <<<Write Text
Console.Write("*");*text, BUT, it makes the NEXT text text on the same line                                              ---    Witing text on same line
Console.WriteLine("*\r");*return (deletes the letter beforehand)                                                         ---    "Return" for text
Console.WriteLine("*\t");*tab                                                                                            ---    Tab for text
Console.WriteLine("*\n");*new line/ indent                                                                               ---    Indent for text>>>
Console.WriteLine(textInfo.ToTitleCase("")); (ONLY FOR THIS CODE!)                                                       ---    All Capital Letters
Console.Write(textInfo.ToTitleCase("")); (ONLY FOR THIS CODE!)                                                           ---    All Capital Letters (same line)
Console.Write("\"*"); Thread.Sleep(100); Console.Write("*"); Thread.Sleep(100); Console.Write("*\""); Thread.Sleep();    ---    Quotes / Letter By Letter
Console.Clear();                                                                                                         ---    Clears console
- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
String input = Console.ReadLine();                                                                                       ---    Checking console for input AND reacting
if (input == "")
{
    
}
else if (input == "")
{
    
}
else
{
    
}
- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
static void LBL(string text, int delay = 50)                                                                             ---    Letter by letter (with some of my extra code)
        {
            text = textInfo.ToTitleCase(text);

            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);
                Thread.Sleep(delay);
            }
        }
- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -


*/
/*
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
|                                                                                                                                                                                                                             |
|                                                                            TO PLAY AGAIN, PRESS THE "TEXT ADVENTURE" BUTTON                                                                                                 |
|                                                                                                                                                                                                                             |
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
|                                                                                                                                                                                                                             |
|                                                                                    !PLEASE DO NOT TOUCH THE CODE!                                                                                                           |
|                                                                                                                                                                                                                             | 
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
*/

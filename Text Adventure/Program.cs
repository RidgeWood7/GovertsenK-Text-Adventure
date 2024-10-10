using System;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

namespace Text_Adventure //Entamaphobia
{
    internal class Program
    {
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


        static void Main(string[] args)
        {
            Console.Beep(100,1000);
            Console.WindowHeight = 20;
            Console.WindowWidth = 150;
            Console.CursorVisible = false;
            //intro();
            start();
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
            Thread.Sleep(2000);
            Console.Beep(700, 200);
            Console.Write("[c]  The "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("C"); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("l"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("o"); Console.ForegroundColor = ConsoleColor.Blue; Console.Write("w"); Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.Write("n"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(" Room\n\n");
            Thread.Sleep(500);
            Console.Write("  .   .   .  ");
            Console.ForegroundColor = ConsoleColor.Black;
            choice1();
        }
        private static void choice1()
        {
            char input = Console.ReadKey().KeyChar;
            if (input == 'd')
            {
                Console.Clear();
                lbl("\n\nYou Enter The Dark Room With The "); Console.ForegroundColor = ConsoleColor.DarkBlue; plainlbl("Water"); Console.ForegroundColor = ConsoleColor.DarkGray; lbl(" On The Floor\n");
                Thread.Sleep(2500);

                Thread.Sleep(500);
                water();
            }
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
                plbl("Oh no..."); end();
                lbl("You're reminded of the time when your childhood thearapist diagnosed you with Glossophobia."); end();
                lbl("Before you can even move as much as one muscle,"); comma(); lbl(" the curtain splits into two,"); comma(); lbl(" presenting you to the audience."); end();
                lbl("For a short period of time,"); comma(); lbl(" you are blinded by the stage lights blaring into your eyes."); end();
                albl("\"Let's give our new host a round of applause,"); comma(); albl("shall we?\""); end();
                lbl("you can feel your heart beating through your chest once you see the stern,"); comma(); lbl(" unpleased, "); comma(); lbl("judgemental crowd that clearly,"); comma(); lbl("\nas the announcer had said, "); comma(); lbl("has not had the best experience today."); end();
                lbl("\n\nYou are now stuck with the following options:"); lbl("\n[m]  say that this was all a mistake,"); end(); lbl("[j]  or start telling some jokes already");
                lightbulb();

                Thread.Sleep(500);
                lightbulb();
            }
            else if (input == 'b')
            {
                Console.Clear();
                lbl("\n\nYou Enter The "); Console.ForegroundColor = ConsoleColor.Red; plainlbl("Bloody"); Console.ForegroundColor = ConsoleColor.DarkGray; lbl(" Room\n");
                Thread.Sleep(2500);

                Thread.Sleep(500);
                blood();
            }
            else if (input == 'c')
            {
                Console.Clear();
                lbl("\n\nYou Enter The "); Thread.Sleep(48); Console.ForegroundColor = ConsoleColor.Red; Console.Write("C"); Thread.Sleep(48); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("l"); Thread.Sleep(48); Console.ForegroundColor = ConsoleColor.Green; Console.Write("o"); Thread.Sleep(48); Console.ForegroundColor = ConsoleColor.Blue; Console.Write("w"); Thread.Sleep(48); Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.Write("n"); Thread.Sleep(48); Console.ForegroundColor = ConsoleColor.DarkGray; lbl(" Room\n\n");
                Thread.Sleep(2500);

                Thread.Sleep(500);
                clown();
            }
            else
            {
                lbl("pick again... [d] | [l] | [b] | [c]\n\n");
                Thread.Sleep(500);
                Console.Write("  .   .   .  ");
                Console.ForegroundColor = ConsoleColor.Black;
                choice1();
            }
        }

        private static void water()
        {
            char input = Console.ReadKey().KeyChar;
            if (input == 'm')
            {

            }
            else if (input == 'j')
            {

            }
            else
            {

            }
        }
        private static void lightbulb()
        {
            Thread sleep = new Thread(() =>
            {
                Thread.Sleep(4000);
                lbl("boom");
            });
            sleep.Start();
            String input = Console.ReadLine();
            if (input == "m")
            {
                sleep.Abort();
                lbl("no boom");
            }
            else if (input == "j")
            {
                sleep.Abort();
                 lbl("no boom");
            }
            else
            {
                
            }
        }
        private static void blood()
        {
            String input = Console.ReadLine();
            if (input == "m")
            {

            }
            else if (input == "j")
            {

            }
            else
            {

            }
        }
        private static void clown()
        {
            String input = Console.ReadLine();
            if (input == "m")
            {

            }
            else if (input == "j")
            {

            }
            else
            {

            }
        }
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

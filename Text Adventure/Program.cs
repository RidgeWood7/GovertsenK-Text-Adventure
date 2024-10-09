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
        }
        static void comma()
        {
            Thread.Sleep(500);
        }
        static void lbl(string text, int delay = 48)
        {
            text = textInfo.ToTitleCase(text);

            for (int i = 0; i < text.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write(text[i]);
                Thread.Sleep(delay);
            }
        }
        static void plainlbl(string text, int delay = 48)
        {
            text = textInfo.ToTitleCase(text);

            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);
                Thread.Sleep(delay);
            }
        }
        static void albl(string text, int delay = 45)
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
        static void plbl(string text, int delay = 45)
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
            choices001();
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
            Console.WriteLine("\t\t  ▓█████  ███▄    █ ▄▄▄█████▓ ▄▄▄       ███▄ ▄███▓ ▄▄▄       ██▓███   ██░ ██  ▒█████   ▄▄▄▄    ██▓ ▄▄▄      \r\n\t\t  ▓█   ▀  ██ ▀█   █ ▓  ██▒ ▓▒▒████▄    ▓██▒▀█▀ ██▒▒████▄    ▓██░  ██▒▓██░ ██▒▒██▒  ██▒▓█████▄ ▓██▒▒████▄    \r\n\t\t  ▒███   ▓██  ▀█ ██▒▒ ▓██░ ▒░▒██  ▀█▄  ▓██    ▓██░▒██  ▀█▄  ▓██░ ██▓▒▒██▀▀██░▒██░  ██▒▒██▒ ▄██▒██▒▒██  ▀█▄  \r\n\t\t  ▒▓█  ▄ ▓██▒  ▐▌██▒░ ▓██▓ ░ ░██▄▄▄▄██ ▒██    ▒██ ░██▄▄▄▄██ ▒██▄█▓▒ ▒░▓█ ░██ ▒██   ██░▒██░█▀  ░██░░██▄▄▄▄██ \r\n\t\t  ░▒████▒▒██░   ▓██░  ▒██▒ ░  ▓█   ▓██▒▒██▒   ░██▒ ▓█   ▓██▒▒██▒ ░  ░░▓█▒░██▓░ ████▓▒░░▓█  ▀█▓░██░ ▓█   ▓██▒\r\n\t\t  ░░ ▒░ ░░ ▒░   ▒ ▒   ▒ ░░    ▒▒   ▓▒█░░ ▒░   ░  ░ ▒▒   ▓▒█░▒▓▒░ ░  ░ ▒ ░░▒░▒░ ▒░▒░▒░ ░▒▓███▀▒░▓   ▒▒   ▓▒█░\r\n\t\t   ░ ░  ░░ ░░   ░ ▒░    ░      ▒   ▒▒ ░░  ░      ░  ▒   ▒▒ ░░▒ ░      ▒ ░▒░ ░  ░ ▒ ▒░ ▒░▒   ░  ▒ ░  ▒   ▒▒ ░\r\n\t\t     ░      ░   ░ ░   ░        ░   ▒   ░      ░     ░   ▒   ░░        ░  ░░ ░░ ░ ░ ▒   ░    ░  ▒ ░  ░   ▒   \r\n\t\t     ░  ░         ░                ░  ░       ░         ░  ░          ░  ░  ░    ░ ░   ░       ░        ░  ░\r\n\t\t                                                                                            ░               ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------\n\n\n");

            Console.Beep(600, 3000);

            //Game Start

            Thread.Sleep(400);
            Console.Clear();
            Console.Write("\t\t\t\t\t\t\t\t ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(":|ARTEMIS CONSOLE|:");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n");
            Thread.Sleep(3500);
            choices001();
        }

        private static void choices001()
        {
            lbl("Hello..."); Thread.Sleep(1700);
            lbl("\nWhat brings you here?"); end();
            lbl("\nDon't answer that!", 30); Thread.Sleep(100); lbl(" We have not much time,"); Thread.Sleep(70); lbl(" and so much fun!"); end();
            lbl("\nWho am I?"); comma(); lbl(" That's not important..."); end();
            lbl("\nThe real question at hand..."); comma(); lbl(" is simple..."); end();
            lbl("\nWhat Room Do You DARE Enter On This "); Thread.Sleep(800); Console.Write("Cold, "); Thread.Sleep(800); Console.Write("Dark, "); Thread.Sleep(800); Console.Write("Rainy, "); Thread.Sleep(500);  Console.Write("Day...\n\n");
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
                lbl("\n\nYou Enter The Dark Room With The "); Console.ForegroundColor = ConsoleColor.DarkBlue; Console.Write("Water"); Console.ForegroundColor = ConsoleColor.DarkGray; lbl(" On The Floor\n");
                Thread.Sleep(2500);

                Thread.Sleep(500);
                water();
            }
            else if (input == 'l')
            {
                Console.Clear();
                lbl("You Enter The Room With Just A "); Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Lightbulb");
                Thread.Sleep(2500);
                lbl("\n\nYou Step Inside And Notice That There Was Never A Door..."); end();
                plbl("\n\"How?\""); comma();
                lbl(" you ask yourself, "); comma(); lbl("but then quickly focus on a vivid sound you hear..."); end();
                plbl("\n\"That was weird...\""); end();
                lbl("\nWhile trying to figure out what you heard, "); comma(); lbl("you notice that there is a soft wavy fabric making up what is the wall in front of you."); end();
                lbl("\nWith the dim lighting from the lightbulb, "); Thread.Sleep(500); lbl("you can see that the fabric is some sort of "); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("Dark Red"); lbl(" color."); end();
                lbl("\nSuddenly you hear the sound again,"); Thread.Sleep(500); lbl(" but this time you can clearly hear it..."); end();
                lbl("\nThe sound is a booming voice, "); comma(); lbl("on what seems to be a giant sound system..."); end();
                albl("\"I know you guys have not had the best exerience today,"); comma(); albl(" but this next act should be the best performance you have "); Thread.Sleep(200); albl("EVER "); Thread.Sleep(200); albl("seen"); end();
                lbl(""); Thread.Sleep(1); Console.WriteLine(textInfo.ToTitleCase("")); Thread.Sleep(1000000000);

                Thread.Sleep(500);
                lightbulb();
            }
            else if (input == 'b')
            {
                Console.Clear();
                lbl("\n\nYou Enter The "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("Bloody"); Console.ForegroundColor = ConsoleColor.DarkGray; lbl(" Room\n");
                Thread.Sleep(2500);

                Thread.Sleep(500);
                blood();
            }
            else if (input == 'c')
            {
                Console.Clear();
                lbl("\n\nYou Enter The "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("C"); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("l"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("o"); Console.ForegroundColor = ConsoleColor.Blue; Console.Write("w"); Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.Write("n"); Console.ForegroundColor = ConsoleColor.DarkGray; lbl(" Room\n\n");
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

        private static void water()//d
        {

        }
        private static void lightbulb()//l
        {

        }
        private static void blood()//b
        {

        }
        private static void clown()//c
        {
            
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

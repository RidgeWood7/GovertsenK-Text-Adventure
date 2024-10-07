using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Text_Adventure //Entamaphobia
{
    internal class Program
    {
        static TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

        static private float quickWitTime = 10f;
        static void Main(string[] args)
        {
            Console.WindowHeight = 20;
            Console.WindowWidth = 150;
            intro();
        }

        private static void intro()
        {

            

            Thread.Sleep(1000);
            Console.Beep(900, 250);
            Thread.Sleep(250);
            Console.Beep(750, 250);
            Thread.Sleep(250);
            Console.Beep(900, 250);
            Thread.Sleep(250);
            Console.Beep(750, 250);
            Thread.Sleep(250);
            Console.Beep(900, 250);
            Thread.Sleep(250);
            Console.Beep(750, 250);
            Thread.Sleep(250);
            Console.Beep(900, 250);
            Thread.Sleep(250);
            Console.Beep(750, 250);//

            Console.WriteLine("\n\n\n\n\n------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(" ▄▄▄       ███▄    █     ▒█████   ██▀███   ██▓  ▄████  ██▓ ███▄    █  ▄▄▄       ██▓         ▄████  ▄▄▄       ███▄ ▄███▓▓█████ \r\n▒████▄     ██ ▀█   █    ▒██▒  ██▒▓██ ▒ ██▒▓██▒ ██▒ ▀█▒▓██▒ ██ ▀█   █ ▒████▄    ▓██▒        ██▒ ▀█▒▒████▄    ▓██▒▀█▀ ██▒▓█   ▀ \r\n▒██  ▀█▄  ▓██  ▀█ ██▒   ▒██░  ██▒▓██ ░▄█ ▒▒██▒▒██░▄▄▄░▒██▒▓██  ▀█ ██▒▒██  ▀█▄  ▒██░       ▒██░▄▄▄░▒██  ▀█▄  ▓██    ▓██░▒███   \r\n░██▄▄▄▄██ ▓██▒  ▐▌██▒   ▒██   ██░▒██▀▀█▄  ░██░░▓█  ██▓░██░▓██▒  ▐▌██▒░██▄▄▄▄██ ▒██░       ░▓█  ██▓░██▄▄▄▄██ ▒██    ▒██ ▒▓█  ▄ \r\n ▓█   ▓██▒▒██░   ▓██░   ░ ████▓▒░░██▓ ▒██▒░██░░▒▓███▀▒░██░▒██░   ▓██░ ▓█   ▓██▒░██████▒   ░▒▓███▀▒ ▓█   ▓██▒▒██▒   ░██▒░▒████▒\r\n ▒▒   ▓▒█░░ ▒░   ▒ ▒    ░ ▒░▒░▒░ ░ ▒▓ ░▒▓░░▓   ░▒   ▒ ░▓  ░ ▒░   ▒ ▒  ▒▒   ▓▒█░░ ▒░▓  ░    ░▒   ▒  ▒▒   ▓▒█░░ ▒░   ░  ░░░ ▒░ ░\r\n  ▒   ▒▒ ░░ ░░   ░ ▒░     ░ ▒ ▒░   ░▒ ░ ▒░ ▒ ░  ░   ░  ▒ ░░ ░░   ░ ▒░  ▒   ▒▒ ░░ ░ ▒  ░     ░   ░   ▒   ▒▒ ░░  ░      ░ ░ ░  ░\r\n  ░   ▒      ░   ░ ░    ░ ░ ░ ▒    ░░   ░  ▒ ░░ ░   ░  ▒ ░   ░   ░ ░   ░   ▒     ░ ░      ░ ░   ░   ░   ▒   ░      ░      ░   \r\n      ░  ░         ░        ░ ░     ░      ░        ░  ░           ░       ░  ░    ░  ░         ░       ░  ░       ░      ░  ░\r\n                                                                                                                              ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------\n\n\n\n\n");

            Thread.Sleep(250);
            Console.Beep(900, 250);
            Thread.Sleep(250);
            Console.Beep(700, 250);
            Thread.Sleep(250);
            Console.Beep(900, 250);
            Thread.Sleep(250);
            Console.Beep(700, 250);
            Thread.Sleep(250);
            Console.Beep(900, 250);
            Thread.Sleep(250);
            Console.Beep(700, 250);
            Thread.Sleep(250);
            Console.Beep(900, 250);
            Thread.Sleep(250);
            Console.Beep(700, 250);//

            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("  ██████ ▄▄▄█████▓ ▒█████   ██▀███ ▓██   ██▓    ▄▄▄▄ ▓██   ██▓    ██ ▄█▀ ██▀███  ▓█████   ██████ ▄▄▄█████▓ ▒█████   ███▄    █ \r\n▒██    ▒ ▓  ██▒ ▓▒▒██▒  ██▒▓██ ▒ ██▒▒██  ██▒   ▓█████▄▒██  ██▒    ██▄█▒ ▓██ ▒ ██▒▓█   ▀ ▒██    ▒ ▓  ██▒ ▓▒▒██▒  ██▒ ██ ▀█   █ \r\n░ ▓██▄   ▒ ▓██░ ▒░▒██░  ██▒▓██ ░▄█ ▒ ▒██ ██░   ▒██▒ ▄██▒██ ██░   ▓███▄░ ▓██ ░▄█ ▒▒███   ░ ▓██▄   ▒ ▓██░ ▒░▒██░  ██▒▓██  ▀█ ██▒\r\n  ▒   ██▒░ ▓██▓ ░ ▒██   ██░▒██▀▀█▄   ░ ▐██▓░   ▒██░█▀  ░ ▐██▓░   ▓██ █▄ ▒██▀▀█▄  ▒▓█  ▄   ▒   ██▒░ ▓██▓ ░ ▒██   ██░▓██▒  ▐▌██▒\r\n▒██████▒▒  ▒██▒ ░ ░ ████▓▒░░██▓ ▒██▒ ░ ██▒▓░   ░▓█  ▀█▓░ ██▒▓░   ▒██▒ █▄░██▓ ▒██▒░▒████▒▒██████▒▒  ▒██▒ ░ ░ ████▓▒░▒██░   ▓██░\r\n▒ ▒▓▒ ▒ ░  ▒ ░░   ░ ▒░▒░▒░ ░ ▒▓ ░▒▓░  ██▒▒▒    ░▒▓███▀▒ ██▒▒▒    ▒ ▒▒ ▓▒░ ▒▓ ░▒▓░░░ ▒░ ░▒ ▒▓▒ ▒ ░  ▒ ░░   ░ ▒░▒░▒░ ░ ▒░   ▒ ▒ \r\n░ ░▒  ░ ░    ░      ░ ▒ ▒░   ░▒ ░ ▒░▓██ ░▒░    ▒░▒   ░▓██ ░▒░    ░ ░▒ ▒░  ░▒ ░ ▒░ ░ ░  ░░ ░▒  ░ ░    ░      ░ ▒ ▒░ ░ ░░   ░ ▒░\r\n░  ░  ░    ░      ░ ░ ░ ▒    ░░   ░ ▒ ▒ ░░      ░    ░▒ ▒ ░░     ░ ░░ ░   ░░   ░    ░   ░  ░  ░    ░      ░ ░ ░ ▒     ░   ░ ░ \r\n      ░               ░ ░     ░     ░ ░         ░     ░ ░        ░  ░      ░        ░  ░      ░               ░ ░           ░ \r\n                                    ░ ░              ░░ ░                                                                     ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------\n\n\n\n\n");

            Thread.Sleep(250);
            Console.Beep(900, 250);
            Thread.Sleep(250);
            Console.Beep(750, 250);
            Thread.Sleep(250);
            Console.Beep(900, 250);
            Thread.Sleep(250);
            Console.Beep(750, 250);
            Thread.Sleep(250);
            Console.Beep(900, 250);
            Thread.Sleep(250);
            Console.Beep(750, 250);
            Thread.Sleep(250);
            Console.Beep(900, 250);
            Thread.Sleep(250);
            Console.Beep(750, 250);//

            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(" ▄████▄   ▒█████  ▓█████▄  ██▓ ███▄    █   ▄████     ▄▄▄▄ ▓██   ██▓    ██ ▄█▀ ██▀███  ▓█████   ██████ ▄▄▄█████▓ ▒█████   ███▄    █ \r\n▒██▀ ▀█  ▒██▒  ██▒▒██▀ ██▌▓██▒ ██ ▀█   █  ██▒ ▀█▒   ▓█████▄▒██  ██▒    ██▄█▒ ▓██ ▒ ██▒▓█   ▀ ▒██    ▒ ▓  ██▒ ▓▒▒██▒  ██▒ ██ ▀█   █ \r\n▒▓█    ▄ ▒██░  ██▒░██   █▌▒██▒▓██  ▀█ ██▒▒██░▄▄▄░   ▒██▒ ▄██▒██ ██░   ▓███▄░ ▓██ ░▄█ ▒▒███   ░ ▓██▄   ▒ ▓██░ ▒░▒██░  ██▒▓██  ▀█ ██▒\r\n▒▓▓▄ ▄██▒▒██   ██░░▓█▄   ▌░██░▓██▒  ▐▌██▒░▓█  ██▓   ▒██░█▀  ░ ▐██▓░   ▓██ █▄ ▒██▀▀█▄  ▒▓█  ▄   ▒   ██▒░ ▓██▓ ░ ▒██   ██░▓██▒  ▐▌██▒\r\n▒ ▓███▀ ░░ ████▓▒░░▒████▓ ░██░▒██░   ▓██░░▒▓███▀▒   ░▓█  ▀█▓░ ██▒▓░   ▒██▒ █▄░██▓ ▒██▒░▒████▒▒██████▒▒  ▒██▒ ░ ░ ████▓▒░▒██░   ▓██░\r\n░ ░▒ ▒  ░░ ▒░▒░▒░  ▒▒▓  ▒ ░▓  ░ ▒░   ▒ ▒  ░▒   ▒    ░▒▓███▀▒ ██▒▒▒    ▒ ▒▒ ▓▒░ ▒▓ ░▒▓░░░ ▒░ ░▒ ▒▓▒ ▒ ░  ▒ ░░   ░ ▒░▒░▒░ ░ ▒░   ▒ ▒ \r\n  ░  ▒     ░ ▒ ▒░  ░ ▒  ▒  ▒ ░░ ░░   ░ ▒░  ░   ░    ▒░▒   ░▓██ ░▒░    ░ ░▒ ▒░  ░▒ ░ ▒░ ░ ░  ░░ ░▒  ░ ░    ░      ░ ▒ ▒░ ░ ░░   ░ ▒░\r\n░        ░ ░ ░ ▒   ░ ░  ░  ▒ ░   ░   ░ ░ ░ ░   ░     ░    ░▒ ▒ ░░     ░ ░░ ░   ░░   ░    ░   ░  ░  ░    ░      ░ ░ ░ ▒     ░   ░ ░ \r\n░ ░          ░ ░     ░     ░           ░       ░     ░     ░ ░        ░  ░      ░        ░  ░      ░               ░ ░           ░ \r\n░                  ░                                      ░░ ░                                                                     ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------\n\n\n\n\n");

            Thread.Sleep(250);
            Console.Beep(900, 250);
            Thread.Sleep(250);
            Console.Beep(950, 250);
            Thread.Sleep(250);
            Console.Beep(900, 250);
            Thread.Sleep(250);
            Console.Beep(950, 250);
            Thread.Sleep(250);
            Console.Beep(900, 250);
            Thread.Sleep(250);
            Console.Beep(950, 250);
            Thread.Sleep(250);
            Console.Beep(900, 250);
            Thread.Sleep(250);
            Console.Beep(950, 250);//

            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("▓█████▄ ▓█████  ▄▄▄▄    █    ██   ▄████   ▄████  ██▓ ███▄    █   ▄████     ▄▄▄▄ ▓██   ██▓   ▓█████▄ ▓█████  ██▀███  ▓█████  ██ ▄█▀\r\n▒██▀ ██▌▓█   ▀ ▓█████▄  ██  ▓██▒ ██▒ ▀█▒ ██▒ ▀█▒▓██▒ ██ ▀█   █  ██▒ ▀█▒   ▓█████▄▒██  ██▒   ▒██▀ ██▌▓█   ▀ ▓██ ▒ ██▒▓█   ▀  ██▄█▒ \r\n░██   █▌▒███   ▒██▒ ▄██▓██  ▒██░▒██░▄▄▄░▒██░▄▄▄░▒██▒▓██  ▀█ ██▒▒██░▄▄▄░   ▒██▒ ▄██▒██ ██░   ░██   █▌▒███   ▓██ ░▄█ ▒▒███   ▓███▄░ \r\n░▓█▄   ▌▒▓█  ▄ ▒██░█▀  ▓▓█  ░██░░▓█  ██▓░▓█  ██▓░██░▓██▒  ▐▌██▒░▓█  ██▓   ▒██░█▀  ░ ▐██▓░   ░▓█▄   ▌▒▓█  ▄ ▒██▀▀█▄  ▒▓█  ▄ ▓██ █▄ \r\n░▒████▓ ░▒████▒░▓█  ▀█▓▒▒█████▓ ░▒▓███▀▒░▒▓███▀▒░██░▒██░   ▓██░░▒▓███▀▒   ░▓█  ▀█▓░ ██▒▓░   ░▒████▓ ░▒████▒░██▓ ▒██▒░▒████▒▒██▒ █▄\r\n ▒▒▓  ▒ ░░ ▒░ ░░▒▓███▀▒░▒▓▒ ▒ ▒  ░▒   ▒  ░▒   ▒ ░▓  ░ ▒░   ▒ ▒  ░▒   ▒    ░▒▓███▀▒ ██▒▒▒     ▒▒▓  ▒ ░░ ▒░ ░░ ▒▓ ░▒▓░░░ ▒░ ░▒ ▒▒ ▓▒\r\n ░ ▒  ▒  ░ ░  ░▒░▒   ░ ░░▒░ ░ ░   ░   ░   ░   ░  ▒ ░░ ░░   ░ ▒░  ░   ░    ▒░▒   ░▓██ ░▒░     ░ ▒  ▒  ░ ░  ░  ░▒ ░ ▒░ ░ ░  ░░ ░▒ ▒░\r\n ░ ░  ░    ░    ░    ░  ░░░ ░ ░ ░ ░   ░ ░ ░   ░  ▒ ░   ░   ░ ░ ░ ░   ░     ░    ░▒ ▒ ░░      ░ ░  ░    ░     ░░   ░    ░   ░ ░░ ░ \r\n   ░       ░  ░ ░         ░           ░       ░  ░           ░       ░     ░     ░ ░           ░       ░  ░   ░        ░  ░░  ░   \r\n ░                   ░                                                          ░░ ░         ░                                    ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------\n\n\n\n\n");

            Thread.Sleep(250);
            Console.Beep(900, 250);
            Thread.Sleep(250);
            Console.Beep(750, 250);
            Thread.Sleep(250);
            Console.Beep(900, 250);
            Thread.Sleep(250);
            Console.Beep(750, 250);
            Thread.Sleep(250);
            Console.Beep(900, 250);
            Thread.Sleep(250);
            Console.Beep(750, 250);
            Thread.Sleep(250);
            Console.Beep(900, 250);
            Thread.Sleep(250);
            Console.Beep(750, 250);//

            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(" ▄▄▄       ██▀███  ▄▄▄█████▓    ███▄    █  ▒█████  ▄▄▄█████▓    ▄▄▄▄ ▓██   ██▓    ██ ▄█▀ ██▀███  ▓█████   ██████ ▄▄▄█████▓ ▒█████   ███▄    █ \r\n▒████▄    ▓██ ▒ ██▒▓  ██▒ ▓▒    ██ ▀█   █ ▒██▒  ██▒▓  ██▒ ▓▒   ▓█████▄▒██  ██▒    ██▄█▒ ▓██ ▒ ██▒▓█   ▀ ▒██    ▒ ▓  ██▒ ▓▒▒██▒  ██▒ ██ ▀█   █ \r\n▒██  ▀█▄  ▓██ ░▄█ ▒▒ ▓██░ ▒░   ▓██  ▀█ ██▒▒██░  ██▒▒ ▓██░ ▒░   ▒██▒ ▄██▒██ ██░   ▓███▄░ ▓██ ░▄█ ▒▒███   ░ ▓██▄   ▒ ▓██░ ▒░▒██░  ██▒▓██  ▀█ ██▒\r\n░██▄▄▄▄██ ▒██▀▀█▄  ░ ▓██▓ ░    ▓██▒  ▐▌██▒▒██   ██░░ ▓██▓ ░    ▒██░█▀  ░ ▐██▓░   ▓██ █▄ ▒██▀▀█▄  ▒▓█  ▄   ▒   ██▒░ ▓██▓ ░ ▒██   ██░▓██▒  ▐▌██▒\r\n ▓█   ▓██▒░██▓ ▒██▒  ▒██▒ ░    ▒██░   ▓██░░ ████▓▒░  ▒██▒ ░    ░▓█  ▀█▓░ ██▒▓░   ▒██▒ █▄░██▓ ▒██▒░▒████▒▒██████▒▒  ▒██▒ ░ ░ ████▓▒░▒██░   ▓██░\r\n ▒▒   ▓▒█░░ ▒▓ ░▒▓░  ▒ ░░      ░ ▒░   ▒ ▒ ░ ▒░▒░▒░   ▒ ░░      ░▒▓███▀▒ ██▒▒▒    ▒ ▒▒ ▓▒░ ▒▓ ░▒▓░░░ ▒░ ░▒ ▒▓▒ ▒ ░  ▒ ░░   ░ ▒░▒░▒░ ░ ▒░   ▒ ▒ \r\n  ▒   ▒▒ ░  ░▒ ░ ▒░    ░       ░ ░░   ░ ▒░  ░ ▒ ▒░     ░       ▒░▒   ░▓██ ░▒░    ░ ░▒ ▒░  ░▒ ░ ▒░ ░ ░  ░░ ░▒  ░ ░    ░      ░ ▒ ▒░ ░ ░░   ░ ▒░\r\n  ░   ▒     ░░   ░   ░            ░   ░ ░ ░ ░ ░ ▒    ░          ░    ░▒ ▒ ░░     ░ ░░ ░   ░░   ░    ░   ░  ░  ░    ░      ░ ░ ░ ▒     ░   ░ ░ \r\n      ░  ░   ░                          ░     ░ ░               ░     ░ ░        ░  ░      ░        ░  ░      ░               ░ ░           ░ \r\n                                                                     ░░ ░                                                                     ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------\n\n\n\n\n");

            Thread.Sleep(250);
            Console.Beep(900, 250);
            Thread.Sleep(250);
            Console.Beep(700, 250);
            Thread.Sleep(250);
            Console.Beep(900, 250);
            Thread.Sleep(250);
            Console.Beep(700, 250);
            Thread.Sleep(250);
            Console.Beep(900, 250);
            Thread.Sleep(250);
            Console.Beep(700, 250);
            Thread.Sleep(250);
            Console.Beep(900, 250);
            Thread.Sleep(250);
            Console.Beep(700, 250);//

            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(" ███▄ ▄███▓ █    ██   ██████  ██▓ ▄████▄      ▄▄▄▄ ▓██   ██▓    ██ ▄█▀ ██▀███  ▓█████   ██████ ▄▄▄█████▓ ▒█████   ███▄    █ \r\n▓██▒▀█▀ ██▒ ██  ▓██▒▒██    ▒ ▓██▒▒██▀ ▀█     ▓█████▄▒██  ██▒    ██▄█▒ ▓██ ▒ ██▒▓█   ▀ ▒██    ▒ ▓  ██▒ ▓▒▒██▒  ██▒ ██ ▀█   █ \r\n▓██    ▓██░▓██  ▒██░░ ▓██▄   ▒██▒▒▓█    ▄    ▒██▒ ▄██▒██ ██░   ▓███▄░ ▓██ ░▄█ ▒▒███   ░ ▓██▄   ▒ ▓██░ ▒░▒██░  ██▒▓██  ▀█ ██▒\r\n▒██    ▒██ ▓▓█  ░██░  ▒   ██▒░██░▒▓▓▄ ▄██▒   ▒██░█▀  ░ ▐██▓░   ▓██ █▄ ▒██▀▀█▄  ▒▓█  ▄   ▒   ██▒░ ▓██▓ ░ ▒██   ██░▓██▒  ▐▌██▒\r\n▒██▒   ░██▒▒▒█████▓ ▒██████▒▒░██░▒ ▓███▀ ░   ░▓█  ▀█▓░ ██▒▓░   ▒██▒ █▄░██▓ ▒██▒░▒████▒▒██████▒▒  ▒██▒ ░ ░ ████▓▒░▒██░   ▓██░\r\n░ ▒░   ░  ░░▒▓▒ ▒ ▒ ▒ ▒▓▒ ▒ ░░▓  ░ ░▒ ▒  ░   ░▒▓███▀▒ ██▒▒▒    ▒ ▒▒ ▓▒░ ▒▓ ░▒▓░░░ ▒░ ░▒ ▒▓▒ ▒ ░  ▒ ░░   ░ ▒░▒░▒░ ░ ▒░   ▒ ▒ \r\n░  ░      ░░░▒░ ░ ░ ░ ░▒  ░ ░ ▒ ░  ░  ▒      ▒░▒   ░▓██ ░▒░    ░ ░▒ ▒░  ░▒ ░ ▒░ ░ ░  ░░ ░▒  ░ ░    ░      ░ ▒ ▒░ ░ ░░   ░ ▒░\r\n░      ░    ░░░ ░ ░ ░  ░  ░   ▒ ░░            ░    ░▒ ▒ ░░     ░ ░░ ░   ░░   ░    ░   ░  ░  ░    ░      ░ ░ ░ ▒     ░   ░ ░ \r\n       ░      ░           ░   ░  ░ ░          ░     ░ ░        ░  ░      ░        ░  ░      ░               ░ ░           ░ \r\n                                 ░                 ░░ ░                                                                     ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------\n\n\n\n\n");

            Thread.Sleep(250);
            Console.Beep(900, 250);
            Thread.Sleep(250);
            Console.Beep(750, 250);
            Thread.Sleep(250);
            Console.Beep(900, 250);
            Thread.Sleep(250);
            Console.Beep(750, 250);
            Thread.Sleep(250);
            Console.Beep(900, 250);
            Thread.Sleep(250);
            Console.Beep(750, 250);
            Thread.Sleep(250);
            Console.Beep(900, 250);
            Thread.Sleep(250);
            Console.Beep(750, 250);//

            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(" ██▓ ███▄    █ ▄▄▄█████▓ ██▀███   ▒█████  ▓█████▄  █    ██  ▄████▄   ██▓ ███▄    █   ▄████ \r\n▓██▒ ██ ▀█   █ ▓  ██▒ ▓▒▓██ ▒ ██▒▒██▒  ██▒▒██▀ ██▌ ██  ▓██▒▒██▀ ▀█  ▓██▒ ██ ▀█   █  ██▒ ▀█▒\r\n▒██▒▓██  ▀█ ██▒▒ ▓██░ ▒░▓██ ░▄█ ▒▒██░  ██▒░██   █▌▓██  ▒██░▒▓█    ▄ ▒██▒▓██  ▀█ ██▒▒██░▄▄▄░\r\n░██░▓██▒  ▐▌██▒░ ▓██▓ ░ ▒██▀▀█▄  ▒██   ██░░▓█▄   ▌▓▓█  ░██░▒▓▓▄ ▄██▒░██░▓██▒  ▐▌██▒░▓█  ██▓\r\n░██░▒██░   ▓██░  ▒██▒ ░ ░██▓ ▒██▒░ ████▓▒░░▒████▓ ▒▒█████▓ ▒ ▓███▀ ░░██░▒██░   ▓██░░▒▓███▀▒\r\n░▓  ░ ▒░   ▒ ▒   ▒ ░░   ░ ▒▓ ░▒▓░░ ▒░▒░▒░  ▒▒▓  ▒ ░▒▓▒ ▒ ▒ ░ ░▒ ▒  ░░▓  ░ ▒░   ▒ ▒  ░▒   ▒ \r\n ▒ ░░ ░░   ░ ▒░    ░      ░▒ ░ ▒░  ░ ▒ ▒░  ░ ▒  ▒ ░░▒░ ░ ░   ░  ▒    ▒ ░░ ░░   ░ ▒░  ░   ░ \r\n ▒ ░   ░   ░ ░   ░        ░░   ░ ░ ░ ░ ▒   ░ ░  ░  ░░░ ░ ░ ░         ▒ ░   ░   ░ ░ ░ ░   ░ \r\n ░           ░             ░         ░ ░     ░       ░     ░ ░       ░           ░       ░ \r\n                                           ░               ░                               ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------\n\n\n");

            Thread.Sleep(250);
            Console.Beep(900, 250);
            Thread.Sleep(250);
            Console.Beep(950, 250);
            Thread.Sleep(250);
            Console.Beep(900, 250);
            Thread.Sleep(250);
            Console.Beep(950, 250);
            Thread.Sleep(250);
            Console.Beep(900, 250);
            Thread.Sleep(250);
            Console.Beep(950, 250);
            Thread.Sleep(250);
            Console.Beep(900, 250);
            Thread.Sleep(250);
            Console.Beep(950, 250);//

            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("▓█████  ███▄    █ ▄▄▄█████▓ ▄▄▄       ███▄ ▄███▓ ▄▄▄       ██▓███   ██░ ██  ▒█████   ▄▄▄▄    ██▓ ▄▄▄      \r\n▓█   ▀  ██ ▀█   █ ▓  ██▒ ▓▒▒████▄    ▓██▒▀█▀ ██▒▒████▄    ▓██░  ██▒▓██░ ██▒▒██▒  ██▒▓█████▄ ▓██▒▒████▄    \r\n▒███   ▓██  ▀█ ██▒▒ ▓██░ ▒░▒██  ▀█▄  ▓██    ▓██░▒██  ▀█▄  ▓██░ ██▓▒▒██▀▀██░▒██░  ██▒▒██▒ ▄██▒██▒▒██  ▀█▄  \r\n▒▓█  ▄ ▓██▒  ▐▌██▒░ ▓██▓ ░ ░██▄▄▄▄██ ▒██    ▒██ ░██▄▄▄▄██ ▒██▄█▓▒ ▒░▓█ ░██ ▒██   ██░▒██░█▀  ░██░░██▄▄▄▄██ \r\n░▒████▒▒██░   ▓██░  ▒██▒ ░  ▓█   ▓██▒▒██▒   ░██▒ ▓█   ▓██▒▒██▒ ░  ░░▓█▒░██▓░ ████▓▒░░▓█  ▀█▓░██░ ▓█   ▓██▒\r\n░░ ▒░ ░░ ▒░   ▒ ▒   ▒ ░░    ▒▒   ▓▒█░░ ▒░   ░  ░ ▒▒   ▓▒█░▒▓▒░ ░  ░ ▒ ░░▒░▒░ ▒░▒░▒░ ░▒▓███▀▒░▓   ▒▒   ▓▒█░\r\n ░ ░  ░░ ░░   ░ ▒░    ░      ▒   ▒▒ ░░  ░      ░  ▒   ▒▒ ░░▒ ░      ▒ ░▒░ ░  ░ ▒ ▒░ ▒░▒   ░  ▒ ░  ▒   ▒▒ ░\r\n   ░      ░   ░ ░   ░        ░   ▒   ░      ░     ░   ▒   ░░        ░  ░░ ░░ ░ ░ ▒   ░    ░  ▒ ░  ░   ▒   \r\n   ░  ░         ░                ░  ░       ░         ░  ░          ░  ░  ░    ░ ░   ░       ░        ░  ░\r\n                                                                                          ░               ");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------\n\n\n\n\n\n\n\n\n\n");

            Thread.Sleep(250);
            Console.Beep(600, 3000);

            //Game Start

            Thread.Sleep(400);
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
            Console.WriteLine(textInfo.ToTitleCase("Hello...")); Thread.Sleep(3000);
            Console.WriteLine(textInfo.ToTitleCase("What brings you here?")); Thread.Sleep(1000);
            Console.WriteLine(textInfo.ToTitleCase("Don't answer that! We have not much time, and so much fun!")); Thread.Sleep(3000);
            Console.WriteLine(textInfo.ToTitleCase("Who am I? That's not important...")); Thread.Sleep(2000);
            Console.WriteLine(textInfo.ToTitleCase("The real question at hand is simple...")); Thread.Sleep(3000);
            Console.WriteLine("What Room Do You DARE Enter On This Cold, Dark, Rainy Day...\n");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Thread.Sleep(4000);
            Console.Beep(700, 200);
            Console.Write("[d]  The Dark Room With The "); Console.ForegroundColor = ConsoleColor.DarkBlue; Console.Write("Water"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine(textInfo.ToTitleCase(" On The Floor\n"));
            Thread.Sleep(2000);
            Console.Beep(700, 200);
            Console.Write("[l]  The Room With Just A "); Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Lightbulb\n"); Console.ForegroundColor = ConsoleColor.DarkGray;
            Thread.Sleep(2000);
            Console.Beep(700, 200);
            Console.Write("[b]  The "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("Bloody"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine(" Room\n");
            Thread.Sleep(2000);
            Console.Beep(700, 200);
            Console.Write("[c]  The "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("C"); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("l"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("o"); Console.ForegroundColor = ConsoleColor.Blue; Console.Write("w"); Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.Write("n"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(" Room\n\n");
            Thread.Sleep(500);
            Console.Write("  .   .   .  ");
            choice1();
        }
        private static void choice1()
        {
            String input = Console.ReadLine();
            if (input == "d")
            {
                Console.Write(textInfo.ToTitleCase("\n\nYou Enter The Dark Room With The ")); Console.ForegroundColor = ConsoleColor.DarkBlue; Console.Write("Water"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine(textInfo.ToTitleCase(" On The Floor\n"));
                Thread.Sleep(2500);

                Thread.Sleep(500);
                water();
            }
            else if (input == "l")
            {
                Console.Write(textInfo.ToTitleCase("\n\nYou Enter The Room With Just A ")); Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Lightbulb\n"); Console.ForegroundColor = ConsoleColor.DarkGray;
                Thread.Sleep(2500);
                Console.Write(textInfo.ToTitleCase("You Step Inside And Notice That There Was Never A Door...")); Thread.Sleep(500);
                Console.Write("\"H"); Thread.Sleep(80); Console.Write("o"); Thread.Sleep(80); Console.Write("w"); Thread.Sleep(80); Console.Write("?\""); Thread.Sleep(100);
                Console.Write(textInfo.ToTitleCase("you ask yourself, but then quickly focus on a sound you hear vividly...")); Thread.Sleep(100);
                Console.Write(textInfo.ToTitleCase("While trying to figure out what you hear, ")); Thread.Sleep(100); Console.Write(textInfo.ToTitleCase("you notice that this"));

                Thread.Sleep(500);
                lightbulb();
            }
            else if (input == "b")
            {
                Console.Write(textInfo.ToTitleCase("\n\nYou Enter The ")); Console.ForegroundColor = ConsoleColor.Red; Console.Write("Bloody"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine(" Room\n");
                Thread.Sleep(2500);

                Thread.Sleep(500);
                blood();
            }
            else if (input == "c")
            {
                Console.Write(textInfo.ToTitleCase("\n\nYou Enter The ")); Console.ForegroundColor = ConsoleColor.Red; Console.Write("C"); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("l"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("o"); Console.ForegroundColor = ConsoleColor.Blue; Console.Write("w"); Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.Write("n"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(" Room\n\n");
                Thread.Sleep(2500);

                Thread.Sleep(500);
                clown();
            }
            else
            {
                Console.WriteLine("pick again... [d] | [l] | [b] | [c]\n\n");
                Thread.Sleep(500);
                Console.Write("  .   .   .  ");
                
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

Console.Beep(freq, *);*1000 = 1 sec                                                                    ---    Beep
Thread.Sleep(*);*1000 = 1 sec                                                                          ---    Stops writing for an amount of time
Console.BackgroundColor = ConsoleColor.*;*color                                                        ---    Background Color for text
Console.ForegroundColor = ConsoleColor.*;*color                                                        ---    Color of text
Console.WriteLine("*");*text                                                                           ---    <<<Write Text
Console.Write("*");*text, BUT, it makes the NEXT text text on the same line                            ---    Witing text on same line
Console.WriteLine("*\r");*return (deletes the letter beforehand)                                       ---    "Return" for text
Console.WriteLine("*\t");*tab                                                                          ---    Tab for text
Console.WriteLine("*\n");*new line/ indent                                                             ---    Indent for text>>>
Console.WriteLine(textInfo.ToTitleCase("")); (ONLY FOR THIS CODE!)                                     ---    All Capital Letters
Console.Write(textInfo.ToTitleCase("")); (ONLY FOR THIS CODE!)                                         ---    All Capital Letters (same line)
- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
String input = Console.ReadLine();                                                                     ---    Checking console for input AND reacting
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




*/

using System.Drawing;
using System.Runtime.CompilerServices;

namespace Text_Adventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro Beeps and Title--------------------------------------------------------------------------------------------------------------------------------

            Console.Beep(647, 500);
            Console.Beep(827, 1000);
            Console.Beep(187, 1500);
            Console.Beep(2427, 300);
            Console.Beep(700, 1700);
            Console.Beep(827, 200);
            Console.Beep(827, 200);
            Console.Beep(827, 200);
            Thread.Sleep(400);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(":|KRESTON CONSOLE 2000|:\n");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
            Thread.Sleep(1500);
            Choice1();
        }

        private static void Choice1()
        {
            Console.WriteLine("What Room Do You DARE Enter On This Cold, Dark, Rainy Day...");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("[d]  The Dark Room\n");
            Console.WriteLine("[l]  The Room With Just a Lightbulb\n");
            Console.Write("[b]  The "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("Bloody"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine(" Room\n");
            Console.WriteLine("[c]  The Clown Room");

            String input = Console.ReadLine();
            if (input == "d")
            {
                Console.WriteLine("");
            }
            else if (input == "l")
            {
                Console.WriteLine("");
            }
            else if (input == "b")
            {
                Console.WriteLine("");
            }
            else if (input == "c")
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("That was not an option");
            }
        }
    }
}




//-----------------------------------------------------------------------------------------------------------------------------------------------------------------
//Notes:

//Console.Beep(freq, *);*1000 = 1 sec                                                                    ---    Beep
//Thread.Sleep(*);*1000 = 1 sec                                                                          ---    Stops writing for an amount of time
//Console.BackgroundColor = ConsoleColor.*;*color                                                        ---    Background Color for text
//Console.ForegroundColor = ConsoleColor.*;*color                                                        ---    Color of text
//Console.WriteLine("*");*text                                                                           ---    <<<Write Text
//Console.WriteLine("*");*text, BUT, it makes the NEXT text text on the same line                        ---    Witing text on same line
//Console.WriteLine("*\r");*return (deletes the letter beforehand)                                       ---    "Return" for text
//Console.WriteLine("*\t");*tab                                                                          ---    Tab for text
//Console.WriteLine("*\n");*new line/ indent                                                             ---    Indent for text>>>
//- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
//String input = Console.ReadLine();                                                                     ---    Checking console for input AND reacting
//if (input == "")
//{
//    
//}
//else if (input == "")
//{
//    
//}
//else
//{
//    
//}
//- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
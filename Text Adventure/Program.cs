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
            Console.WriteLine(":|ARTEMIS CONSOLE|:\n");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
            Thread.Sleep(3500);
            choices001();
        }

        private static void choices001()
        {
            Console.WriteLine("What Room Do You DARE Enter On This Cold, Dark, Rainy Day...\n");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Thread.Sleep(4000);
            Console.Beep(700, 200);
            Console.Write("[d]  The Dark Room With The "); Console.ForegroundColor = ConsoleColor.DarkBlue; Console.Write("Water"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine(" On The Floor\n");
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
                Console.Write("\n\nYou Enter The Dark Room With The "); Console.ForegroundColor = ConsoleColor.DarkBlue; Console.Write("Water"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine(" On The Floor\n");
            }
            else if (input == "l")
            {
                Console.Write("\n\nYou Enter The Room With Just A "); Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Lightbulb\n"); Console.ForegroundColor = ConsoleColor.DarkGray;
            }
            else if (input == "b")
            {
                Console.Write("\n\nYou Enter The "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("Bloody"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine(" Room\n");
             }
            else if (input == "c")
            {
                Console.Write("\n\nYou Enter The "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("C"); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("l"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("o"); Console.ForegroundColor = ConsoleColor.Blue; Console.Write("w"); Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.Write("n"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(" Room\n\n");
            }
            else
            {
                Console.WriteLine("pick again... [d] | [l] | [b] | [c]\n\n");
                Thread.Sleep(500);
                Console.Write("  .   .   .  ");
                choice1();
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
//Console.Write("*");*text, BUT, it makes the NEXT text text on the same line                            ---    Witing text on same line
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
using System;



namespace RPGEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection = 0;
            int oldselection = 1;
            Console.CursorVisible = false;
            Console.SetCursorPosition(0, 0);
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKey Key = Console.ReadKey().Key;
                    if(Key == ConsoleKey.UpArrow)
                    {
                        if (selection > 0) selection--;
                        else selection = 0;
                    }else if (Key == ConsoleKey.DownArrow)
                    {
                        if (selection < 3) selection++;
                        else selection = 3;
                    }
                }
                if (selection != oldselection)
                {
                    if (selection == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    Console.WriteLine("Eka valikko");
                    if (selection == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    Console.WriteLine("Toka valikko");
                    if (selection == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    Console.WriteLine("Kolmas valikko");
                    if (selection == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    Console.WriteLine("Neljäs valikko");
                    Console.SetCursorPosition(0, 0);
                    oldselection = selection;
                }
            }
            
            

        }

    }
}

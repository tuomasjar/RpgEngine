using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGEngine;

namespace RPGEngine
{
    static class Graphics
    {
        public static void drawScreen()
        {

        }

        public static void drawEntity(Entity target)
        {
            int x = target.location.X;
            int y = target.location.Y;
            Console.SetCursorPosition(x, y);
            char symbol = target.Symbol;
            Console.Write(symbol);
        }

        public static void clearLocation(Position target)
        {
            int x = target.X;
            int y = target.Y;
            Console.SetCursorPosition(x, y);
            Console.Write(Constants.EMPTY_SYMBOL);
        }

        public static void drawItem(Item target)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Course_task_6_struct
{
    enum Colors
    {
        Black = 0,
        DarkBlue = 1,
        DarkGreen = 2,
        DarkRed = 3,
        DarkMagenta = 4,
        DarkYellow = 5,
        Gray = 6,
        DarkGray = 7,
        Blue = 8,
        Green = 9,
        Cyan = 10,
        Red = 11,
        Magenta = 12,
        Yellow = 13,
        White = 14
    }
    static class Printer
    {
        public static void Print(string stroka, int color)
        {
            switch(color)
            {
                case 1: Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case 2: Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 3: Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case 4: Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case 5: Console.ForegroundColor = ConsoleColor.DarkCyan;
                    break;
                case 6: Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
                case 7: Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case 8: Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;
                case 9: Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case 10: Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case 11: Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case 12: Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 13: Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case 14: Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                default: Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
            Console.WriteLine(stroka);
            Console.ResetColor();
        }
    }
}

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
        static void Print(string stroka, int color)
        {
            Console.ForegroundColor = (int)Colors.Black;
            Console.WriteLine(stroka);
            Console.ResetColor();
        }
    }
}

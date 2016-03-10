using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Course_task_6_struct
{
    enum Post
    {
        Fedya = 30,
        Petya = 32,
        Ivan = 31 
    }
    static class Accauntant
    {
        public static bool AskForBonus(Post worker, int hours)
        {
            if ((int)worker > hours)
                return true;
            else
                return false;
        }
    }
}

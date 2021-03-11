using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Roulette
    {
        public static int GetNum()
        {

            Random rnd = new Random();
            var number = rnd.Next(0, 37);
            return number;

        }
    }
}

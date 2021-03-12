using System;
using System.Collections.Generic;
using System.Text;

namespace myroulette
{
    public class Roulette
    {
        public int roll;

        public Roulette(){
            this.roll = 0;
        }
        public void rolling()
        {
            /*
            変数の省略はおすすめしません．空白の１４年間が過ぎ去ったあとでも思い出せるように
            しておくことが人類平和に役立ちます．
            */
            Random random = new Random(); 
            this.roll = random.Next(0, 37); // 整数値って分かってるなら，intとかに制限するほうがいいよ．
            this.checkPoint(this.roll);
        }

        public int checkPoint(int roll)
        {
            if (roll == 0)
            {
                Console.WriteLine("番号は0です\n");
                return 0;
            }
            else if (roll == 37)
            {
                Console.WriteLine("番号は00です\n");
                return 0;
            }
            else if (roll >= 25)
            {
                Console.WriteLine("番号は{0}で位置は3rdです\n", roll);
                return 3;
            }
            else if (roll >= 13)
            {
                Console.WriteLine("番号は{0}で位置は2ndです\n", roll);
                return 2;
            }
            else if (roll >= 1)
            {
                Console.WriteLine("番号は{0}で位置は1stです\n", roll);
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}

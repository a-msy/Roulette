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
        public int getNum()
        {
            /*
            変数の省略はおすすめしません．空白の１４年間が過ぎ去ったあとでも思い出せるように
            しておくことが人類平和に役立ちます．
            */
            Random random = new Random(); 
            this.roll = random.Next(0, 37); // 整数値って分かってるなら，intとかに制限するほうがいいよ．
        }
    }
}

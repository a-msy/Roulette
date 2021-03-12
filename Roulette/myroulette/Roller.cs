using System;
using Roulette;
using myplayer;

namespace myroulette
{
    public class Roller
    {
        public int roll;

        public Roller(){
            this.roll = 0;
        }

        public void rolling()
        {
            /*
            変数の省略はおすすめしません．空白の１４年間が過ぎ去ったあとでも思い出せるように
            しておくことが人類平和に役立ちます．
            */
            Random random = new Random(); 
            this.roll = random.Next(0, Const.double_zero); // 整数値って分かってるなら，intとかに制限するほうがいいよ．
            this.checkPoint(true);
        }

        public void return2(Player player, int betMoney)
        {
            betMoney *= 2;
            Console.WriteLine($"当たり！2倍の払い戻し：{betMoney}");
            player.capitalMoney += betMoney;
        }

        public void return4(Player player, int betMoney)
        {
            betMoney *= 4;
            Console.WriteLine($"当たり！4倍の払い戻し：{betMoney}");
            player.capitalMoney += betMoney;
        }

        public int checkPoint(bool print)
        {
            if (this.roll == Const.zero)
            {
                if(print) Console.WriteLine("番号は0です");
                return 0;
            }
            else if (this.roll == Const.double_zero)
            {
                if (print) Console.WriteLine("番号は00です");
                return 0;
            }
            else if (this.roll >= Const.third_area)
            {
                if (print) Console.WriteLine("番号は{0}で位置は3rdです", roll);
                return 3;
            }
            else if (this.roll >= Const.second_area)
            {
                if (print) Console.WriteLine("番号は{0}で位置は2ndです", roll);
                return 2;
            }
            else if (this.roll >= Const.first_area)
            {
                if (print) Console.WriteLine("番号は{0}で位置は1stです", roll);
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}

using myplayer;
using myroulette;
using System;
using Roulette;

namespace mystrategy
{
    public class Strategy
    {
        int[] area = new int[4] { 0, 0, 0, 0 };
        int[] betMoney = new int[4] { 0, 0, 0, 0 };

        public Strategy(int waitTimes){
            for(int loop = 0; loop < Const.sections; loop++)
            {
                this.area[loop] = waitTimes;
                this.betMoney[loop] = 0;
            }
        }

        public void checkChance(Player player, Roller roller)
        {
            if(roller.roll > Const.zero && roller.roll < Const.double_zero)
            {
                if(area[roller.checkPoint(false)] == 0)
                {
                    Console.WriteLine($"エリア{roller.checkPoint(false)}にかけるチャンスが来ました.資金{player.capitalMoney}の1％をBETします");
                    // なるべく式はみやすく．　+=　とかそれだけで脳みそ疲れるので．
                    this.betMoney[roller.checkPoint(false)] = (int)Math.Round(player.capitalMoney * 0.01);
                    player.capitalMoney -= this.betMoney[roller.checkPoint(false)];
                    Console.WriteLine($"掛け金は￥{this.betMoney[roller.checkPoint(false)]}です(資金：{player.capitalMoney})");
                }
                
            }
        }

        private void checkLoseOrWin(Player player, Roller roller, int target_area, int lost_area1, int lost_area2, int min, int max)
        {
            this.area[target_area] = player.waitTimes;
            this.area[lost_area2] -= 1;
            this.area[lost_area1] -= 1;

            if (this.betMoney[target_area] > 0)
            {
                if (roller.roll >= min && roller.roll <= max)
                {
                    roller.return4(player, this.betMoney[target_area]);
                }
                else
                {
                    roller.return2(player, this.betMoney[target_area]);
                }

            }
            if (this.betMoney[lost_area1] > 0 || this.betMoney[lost_area2] > 0)
            {
                Console.WriteLine($"外れ！掛け金を{Const.monte}倍にしてもう一度賭けます");
                if (this.betMoney[lost_area1] > 0)
                {
                    this.betMoney[lost_area1] *= Const.monte;
                    Console.WriteLine($"掛け金は￥{this.betMoney[lost_area1]}です");
                    player.capitalMoney -= this.betMoney[lost_area1];
                }
                else
                {
                    this.betMoney[lost_area2] *= Const.monte;
                    Console.WriteLine($"掛け金は￥{this.betMoney[lost_area2]}です");
                    player.capitalMoney -= this.betMoney[lost_area2];
                }

            }
        }

        public void checkStrategy(Player player, Roller roller)
        {
            if (roller.roll >= Const.third_area)
            {
                this.checkLoseOrWin(player, roller, 3, 1, 2, 28, 33);
            }
            else if (roller.roll >= Const.second_area)
            {
                this.checkLoseOrWin(player, roller, 2, 1, 3, 16, 21);
            }
            else if (roller.roll >= Const.first_area)
            {
                this.checkLoseOrWin(player, roller, 1, 2, 3, 4, 9);
            }
        }
    }
}
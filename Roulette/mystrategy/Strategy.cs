using myplayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace mystrategy
{
    public class Strategy
    {
        int first;
        int second;
        int third;

        int betMoneyForFirst;
        int betMoneyForSecond;
        int betMoneyForThird;

        public Strategy(int waitTimes){
            this.first = waitTimes;
            this.second = waitTimes;
            this.third = waitTimes;
            this.betMoneyForFirst = 0;
            this.betMoneyForSecond = 0;
            this.betMoneyForThird = 0;
        }

        public void checkChance(Player player)
        {
            if(this.first == 0)
            {
                Console.WriteLine("1stにかけるチャンスが来ました.資金{0}の1％をBETします\n", player.capitalMoney);
                // なるべく式はみやすく．　+=　とかそれだけで脳みそ疲れるので．
                this.betMoneyForFirst = (int)Math.Round(player.capitalMoney * 0.01);
                player.capitalMoney -= this.betMoneyForFirst;
            }

            if(this.second == 0)
            {
                Console.WriteLine("2ndにかけるチャンスが来ました.資金{0}の1％をBETします\n", player.capitalMoney);
                this.betMoneyForSecond = (int)Math.Round(player.capitalMoney * 0.01);
                player.capitalMoney -= this.betMoneyForSecond;
            }

            if (this.third == 0)
            {
                Console.WriteLine("3rdにかけるチャンスが来ました.資金{0}の1％をBETします\n", player.capitalMoney);
                this.betMoneyForThird = (int)Math.Round(player.capitalMoney * 0.01);
                player.capitalMoney -= this.betMoneyForThird;
            }
        }

        public void checkStrategy(int roll)
        {
            if (number >= 25)
            {
                Console.WriteLine($"番号は{number}、位置は3rdです");
                trd = resetNum;
                fst--;
                snd--;
                if (betMoney3 > 0)
                {
                    if (number >= 28 && number <= 33)
                    {
                        Console.WriteLine("当たり！4倍です！");
                        betMoney3 *= 4;
                        capitalMoney += (int)betMoney3;
                        betMoney3 = 0;
                        Console.WriteLine($"現在の軍資金は￥{capitalMoney}です");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("当たり！2倍です！");
                        betMoney3 *= 2;
                        capitalMoney += (int)betMoney3;
                        betMoney3 = 0;
                        Console.WriteLine($"現在の軍資金は￥{capitalMoney}です");
                        Console.ReadLine();
                    }

                }
                if (betMoney1 > 0 || betMoney2 > 0)
                {
                    Console.WriteLine("外れ！掛け金を倍にしてもう一度賭けます");
                    if (betMoney1 > 0)
                    {
                        betMoney1 *= 2;
                        capitalMoney -= (int)betMoney1;
                    }
                    else
                    {
                        betMoney2 *= 2;
                        capitalMoney -= (int)betMoney2;
                    }

                }
            }
            else if (number >= 13)
            {
                Console.WriteLine($"番号は{number}、位置は2ndです");
                snd = resetNum;
                fst--;
                trd--;
                if (betMoney2 > 0)
                {
                    if (number >= 16 && number <= 21)
                    {
                        Console.WriteLine("当たり！4倍です！");
                        betMoney2 *= 4;
                        capitalMoney += (int)betMoney2;
                        betMoney2 = 0;
                        Console.WriteLine($"現在の軍資金は￥{capitalMoney}です");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("当たり！2倍です！");
                        betMoney2 *= 2;
                        capitalMoney += (int)betMoney2;
                        betMoney2 = 0;
                        Console.WriteLine($"現在の軍資金は￥{capitalMoney}です");
                        Console.ReadLine();
                    }

                }
                if (betMoney1 > 0 || betMoney3 > 0)
                {
                    Console.WriteLine("外れ！掛け金を倍にしてもう一度賭けます");
                    if (betMoney1 > 0)
                    {
                        betMoney1 *= 2;
                        capitalMoney -= (int)betMoney1;
                    }
                    else
                    {
                        betMoney3 *= 2;
                        capitalMoney -= (int)betMoney3;
                    }

                }
            }
            else if (number >= 1)
            {
                Console.WriteLine($"番号は{number}、位置は1stです");
                fst = resetNum;
                snd--;
                trd--;
                if (betMoney1 > 0)
                {
                    if (number >= 4 && number <= 9)
                    {
                        Console.WriteLine("当たり！4倍です！");
                        betMoney1 *= 4;
                        capitalMoney += (int)betMoney1;
                        betMoney1 = 0;
                        Console.WriteLine($"現在の軍資金は￥{capitalMoney}です");
                        Console.ReadLine();
                    }
                    else
                    {

                        Console.WriteLine("当たり！2倍です！");
                        betMoney1 *= 2;
                        capitalMoney += (int)betMoney1;
                        betMoney1 = 0;
                        Console.WriteLine($"現在の軍資金は￥{capitalMoney}です");
                        Console.ReadLine();
                    }

                }
                if (betMoney2 > 0 || betMoney3 > 0)
                {
                    Console.WriteLine("外れ！掛け金を倍にしてもう一度賭けます");
                    if (betMoney2 > 0)
                    {
                        betMoney2 *= 2;
                        capitalMoney -= (int)betMoney2;
                    }
                    else
                    {
                        betMoney3 *= 2;
                        capitalMoney -= (int)betMoney3;
                    }

                }
            }

            if (capitalMoney >= target)
            {
                Console.WriteLine("目標達成！");
                break;
            }
            if (capitalMoney <= 0)
            {
                Console.WriteLine("残念！破産してしまいました！");
            }
        }
    }
}
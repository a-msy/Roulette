using System;
using System.Collections.Generic;
using System.Text;
using myplayer;
using mystrategy;
using myroulette;

namespace ConsoleApp3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Roulette roulette = new Roulette();
            player.initializePlayer();

            Strategy strategy = new Strategy(player.waitTimes); // Strategyには何かしらintの値が必要なので，playerの初期化後に宣言を行う

            while (player.capitalMoney > 0)
            {

                if (fst == 0)
                {
                    Console.WriteLine("1stにかけるチャンスが来ました\n資金の1％をBETします");
                    betMoney1 = capitalMoney * 0.01;
                    capitalMoney -= (int)betMoney1;
                    Console.ReadLine();
                }
                else if (snd == 0)
                {
                    Console.WriteLine("2ndにかけるチャンスが来ました\n資金の1％をBETします");
                    betMoney2 = capitalMoney * 0.01;
                    capitalMoney -= (int)betMoney2;
                    Console.ReadLine();
                }
                else if (trd == 0)
                {
                    Console.WriteLine("3rdにかけるチャンスが来ました\n資金の1％をBETします");
                    betMoney3 = capitalMoney * 0.01;
                    capitalMoney -= (int)betMoney3;
                    Console.ReadLine();
                }

                Random rnd = new Random();
                var number = rnd.Next(0, 37);

                if (number == 0)
                {
                    Console.WriteLine($"番号は0です");
                }
                else if (number == 37)
                {
                    Console.WriteLine($"番号は00です");
                }
                else if (number >= 25)
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
}
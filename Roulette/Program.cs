using System;
using myplayer;
using mystrategy;
using myroulette;

namespace ConsoleApp3
{
    public class Program
    {
        static void Main(string[] args)
        {
            // クラスや変数は頭で宣言するほうが個人的には見やすくて助かる．

            Player player = new Player();
            Roller roller = new Roller();
            player.initializePlayer();
            Strategy strategy = new Strategy(player.waitTimes); // Strategyには何かしらintの値が必要なので，playerの初期化後に宣言を行う

            while (player.isBankrupt())
            {
                player.checkStatus();
                roller.rolling();
                strategy.checkChance(player, roller);
                strategy.checkStrategy(player, roller);
                Console.WriteLine("\n");
            }

            return ;
        }
    }
}
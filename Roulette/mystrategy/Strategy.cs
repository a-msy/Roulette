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
                Console.WriteLine("1st‚É‚©‚¯‚éƒ`ƒƒƒ“ƒX‚ª—ˆ‚Ü‚µ‚½.‘‹à{0}‚Ì1“‚ğBET‚µ‚Ü‚·\n", player.capitalMoney);
                // ‚È‚é‚×‚­®‚Í‚İ‚â‚·‚­D@+=@‚Æ‚©‚»‚ê‚¾‚¯‚Å”]‚İ‚»”æ‚ê‚é‚Ì‚ÅD
                this.betMoneyForFirst = (int)Math.Round(player.capitalMoney * 0.01);
                player.capitalMoney -= this.betMoneyForFirst;
            }

            if(this.second == 0)
            {
                Console.WriteLine("2nd‚É‚©‚¯‚éƒ`ƒƒƒ“ƒX‚ª—ˆ‚Ü‚µ‚½.‘‹à{0}‚Ì1“‚ğBET‚µ‚Ü‚·\n", player.capitalMoney);
                this.betMoneyForSecond = (int)Math.Round(player.capitalMoney * 0.01);
                player.capitalMoney -= this.betMoneyForSecond;
            }

            if (this.third == 0)
            {
                Console.WriteLine("3rd‚É‚©‚¯‚éƒ`ƒƒƒ“ƒX‚ª—ˆ‚Ü‚µ‚½.‘‹à{0}‚Ì1“‚ğBET‚µ‚Ü‚·\n", player.capitalMoney);
                this.betMoneyForThird = (int)Math.Round(player.capitalMoney * 0.01);
                player.capitalMoney -= this.betMoneyForThird;
            }
        }

        public void checkStrategy(int roll)
        {
            if (number >= 25)
            {
                Console.WriteLine($"”Ô†‚Í{number}AˆÊ’u‚Í3rd‚Å‚·");
                trd = resetNum;
                fst--;
                snd--;
                if (betMoney3 > 0)
                {
                    if (number >= 28 && number <= 33)
                    {
                        Console.WriteLine("“–‚½‚èI4”{‚Å‚·I");
                        betMoney3 *= 4;
                        capitalMoney += (int)betMoney3;
                        betMoney3 = 0;
                        Console.WriteLine($"Œ»İ‚ÌŒR‘‹à‚Í{capitalMoney}‚Å‚·");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("“–‚½‚èI2”{‚Å‚·I");
                        betMoney3 *= 2;
                        capitalMoney += (int)betMoney3;
                        betMoney3 = 0;
                        Console.WriteLine($"Œ»İ‚ÌŒR‘‹à‚Í{capitalMoney}‚Å‚·");
                        Console.ReadLine();
                    }

                }
                if (betMoney1 > 0 || betMoney2 > 0)
                {
                    Console.WriteLine("ŠO‚êIŠ|‚¯‹à‚ğ”{‚É‚µ‚Ä‚à‚¤ˆê“x“q‚¯‚Ü‚·");
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
                Console.WriteLine($"”Ô†‚Í{number}AˆÊ’u‚Í2nd‚Å‚·");
                snd = resetNum;
                fst--;
                trd--;
                if (betMoney2 > 0)
                {
                    if (number >= 16 && number <= 21)
                    {
                        Console.WriteLine("“–‚½‚èI4”{‚Å‚·I");
                        betMoney2 *= 4;
                        capitalMoney += (int)betMoney2;
                        betMoney2 = 0;
                        Console.WriteLine($"Œ»İ‚ÌŒR‘‹à‚Í{capitalMoney}‚Å‚·");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("“–‚½‚èI2”{‚Å‚·I");
                        betMoney2 *= 2;
                        capitalMoney += (int)betMoney2;
                        betMoney2 = 0;
                        Console.WriteLine($"Œ»İ‚ÌŒR‘‹à‚Í{capitalMoney}‚Å‚·");
                        Console.ReadLine();
                    }

                }
                if (betMoney1 > 0 || betMoney3 > 0)
                {
                    Console.WriteLine("ŠO‚êIŠ|‚¯‹à‚ğ”{‚É‚µ‚Ä‚à‚¤ˆê“x“q‚¯‚Ü‚·");
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
                Console.WriteLine($"”Ô†‚Í{number}AˆÊ’u‚Í1st‚Å‚·");
                fst = resetNum;
                snd--;
                trd--;
                if (betMoney1 > 0)
                {
                    if (number >= 4 && number <= 9)
                    {
                        Console.WriteLine("“–‚½‚èI4”{‚Å‚·I");
                        betMoney1 *= 4;
                        capitalMoney += (int)betMoney1;
                        betMoney1 = 0;
                        Console.WriteLine($"Œ»İ‚ÌŒR‘‹à‚Í{capitalMoney}‚Å‚·");
                        Console.ReadLine();
                    }
                    else
                    {

                        Console.WriteLine("“–‚½‚èI2”{‚Å‚·I");
                        betMoney1 *= 2;
                        capitalMoney += (int)betMoney1;
                        betMoney1 = 0;
                        Console.WriteLine($"Œ»İ‚ÌŒR‘‹à‚Í{capitalMoney}‚Å‚·");
                        Console.ReadLine();
                    }

                }
                if (betMoney2 > 0 || betMoney3 > 0)
                {
                    Console.WriteLine("ŠO‚êIŠ|‚¯‹à‚ğ”{‚É‚µ‚Ä‚à‚¤ˆê“x“q‚¯‚Ü‚·");
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
                Console.WriteLine("–Ú•W’B¬I");
                break;
            }
            if (capitalMoney <= 0)
            {
                Console.WriteLine("c”OI”jY‚µ‚Ä‚µ‚Ü‚¢‚Ü‚µ‚½I");
            }
        }
    }
}
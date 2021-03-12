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
                Console.WriteLine("1st�ɂ�����`�����X�����܂���.����{0}��1����BET���܂�\n", player.capitalMoney);
                // �Ȃ�ׂ����݂͂₷���D�@+=�@�Ƃ����ꂾ���Ŕ]�݂�����̂ŁD
                this.betMoneyForFirst = (int)Math.Round(player.capitalMoney * 0.01);
                player.capitalMoney -= this.betMoneyForFirst;
            }

            if(this.second == 0)
            {
                Console.WriteLine("2nd�ɂ�����`�����X�����܂���.����{0}��1����BET���܂�\n", player.capitalMoney);
                this.betMoneyForSecond = (int)Math.Round(player.capitalMoney * 0.01);
                player.capitalMoney -= this.betMoneyForSecond;
            }

            if (this.third == 0)
            {
                Console.WriteLine("3rd�ɂ�����`�����X�����܂���.����{0}��1����BET���܂�\n", player.capitalMoney);
                this.betMoneyForThird = (int)Math.Round(player.capitalMoney * 0.01);
                player.capitalMoney -= this.betMoneyForThird;
            }
        }

        public void checkStrategy(int roll)
        {
            if (number >= 25)
            {
                Console.WriteLine($"�ԍ���{number}�A�ʒu��3rd�ł�");
                trd = resetNum;
                fst--;
                snd--;
                if (betMoney3 > 0)
                {
                    if (number >= 28 && number <= 33)
                    {
                        Console.WriteLine("������I4�{�ł��I");
                        betMoney3 *= 4;
                        capitalMoney += (int)betMoney3;
                        betMoney3 = 0;
                        Console.WriteLine($"���݂̌R�����́�{capitalMoney}�ł�");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("������I2�{�ł��I");
                        betMoney3 *= 2;
                        capitalMoney += (int)betMoney3;
                        betMoney3 = 0;
                        Console.WriteLine($"���݂̌R�����́�{capitalMoney}�ł�");
                        Console.ReadLine();
                    }

                }
                if (betMoney1 > 0 || betMoney2 > 0)
                {
                    Console.WriteLine("�O��I�|������{�ɂ��Ă�����x�q���܂�");
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
                Console.WriteLine($"�ԍ���{number}�A�ʒu��2nd�ł�");
                snd = resetNum;
                fst--;
                trd--;
                if (betMoney2 > 0)
                {
                    if (number >= 16 && number <= 21)
                    {
                        Console.WriteLine("������I4�{�ł��I");
                        betMoney2 *= 4;
                        capitalMoney += (int)betMoney2;
                        betMoney2 = 0;
                        Console.WriteLine($"���݂̌R�����́�{capitalMoney}�ł�");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("������I2�{�ł��I");
                        betMoney2 *= 2;
                        capitalMoney += (int)betMoney2;
                        betMoney2 = 0;
                        Console.WriteLine($"���݂̌R�����́�{capitalMoney}�ł�");
                        Console.ReadLine();
                    }

                }
                if (betMoney1 > 0 || betMoney3 > 0)
                {
                    Console.WriteLine("�O��I�|������{�ɂ��Ă�����x�q���܂�");
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
                Console.WriteLine($"�ԍ���{number}�A�ʒu��1st�ł�");
                fst = resetNum;
                snd--;
                trd--;
                if (betMoney1 > 0)
                {
                    if (number >= 4 && number <= 9)
                    {
                        Console.WriteLine("������I4�{�ł��I");
                        betMoney1 *= 4;
                        capitalMoney += (int)betMoney1;
                        betMoney1 = 0;
                        Console.WriteLine($"���݂̌R�����́�{capitalMoney}�ł�");
                        Console.ReadLine();
                    }
                    else
                    {

                        Console.WriteLine("������I2�{�ł��I");
                        betMoney1 *= 2;
                        capitalMoney += (int)betMoney1;
                        betMoney1 = 0;
                        Console.WriteLine($"���݂̌R�����́�{capitalMoney}�ł�");
                        Console.ReadLine();
                    }

                }
                if (betMoney2 > 0 || betMoney3 > 0)
                {
                    Console.WriteLine("�O��I�|������{�ɂ��Ă�����x�q���܂�");
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
                Console.WriteLine("�ڕW�B���I");
                break;
            }
            if (capitalMoney <= 0)
            {
                Console.WriteLine("�c�O�I�j�Y���Ă��܂��܂����I");
            }
        }
    }
}
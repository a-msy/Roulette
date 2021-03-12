using System;
using System.Collections.Generic;
using System.Text;

namespace mystrategy
{
    public class Strategy
    {
        var first;
        var second;
        var third;

        double betMoneyForFirst;
        double betMoneyForSecond;
        double betMoneyForThird;

        public Strategy(int waitTimes){
            this.first = waitTimes;
            this.second = waitTimes;
            this.third = waitTimes;
        }
    }
}
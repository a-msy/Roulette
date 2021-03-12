using System;
using System.Collections.Generic;
using System.Text;

namespace myplayer
{
    public class Player
    {
        public int capitalMoney;
        public int target;
        public int waitTimes;
        public Player(){
            /*
            コンストラクタと呼ばれるもので，クラス名と同じ名前で宣言します．
            生まれたときに，戸籍ないと不便でしょ？そんなやつ
            */
            this.capitalMoney = 0;
            this.target = 0;
            this.waitTimes = 0;
        }
        
        private void getMoney(){
            Console.WriteLine("資金を入力してください (単位:円）");
            this.capitalMoney = int.Parse(Console.ReadLine());
        }

        private void getTarget(){
            Console.WriteLine("目標金額を入力してください (単位:円）");
            this.target = int.Parse(Console.ReadLine());
        }

        private void getwaitTimes(){
            Console.WriteLine("賭けるまで待つ回数を設定して下さい");
            this.waitTimes = int.Parse(Console.ReadLine());
        }

        public void initializePlayer(){ // 別のクラスから呼び出す必要のあるものはpublicにする
            this.getMoney();
            this.getTarget();
            this.getwaitTimes();
            Console.WriteLine($"連続で{resetNum}回出なかったフィールドに賭けます");
        }

    }
}
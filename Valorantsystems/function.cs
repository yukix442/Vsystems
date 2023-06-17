using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Web;

namespace Valorantsystems
{
    public class function
    {

        //平均ランク計算関数
        public string AvgRank(int rank1,int rank2, int rank3,int rank4,int rank5)
        {
            double sum = 0;
            string rank;
            sum = rank1+ rank2 + rank3 + rank4 + rank5;
            sum = sum / 5.0;
            double roundedNumber = (double)Math.Round(sum);
            rank =TostringRank((int)roundedNumber);
            return rank;
        }

        //数値ランク化関数
        public string TostringRank(int numrank)
        {
            string rank="ランク測定不能";
            if (numrank == 1)
            {
                rank = "アイアン1";
            }
            else if(numrank == 2)
            {
                rank = "アイアン2";
            }
            else if (numrank == 3)
            {
                rank = "アイアン3";
            }
            else if (numrank == 4)
            {
                rank = "ブロンズ1";
            }
            else if (numrank == 5)
            {
                rank = "ブロンズ2";
            }
            else if (numrank == 6)
            {
                rank = "ブロンズ3";
            }
            else if (numrank == 7)
            {
                rank = "シルバー1";
            }
            else if (numrank == 8)
            {
                rank = "シルバー2";
            }
            else if (numrank == 9)
            {
                rank = "シルバー3";
            }
            else if (numrank == 10)
            {
                rank = "ゴールド1";
            }
            else if (numrank == 11)
            {
                rank = "ゴールド2";
            }
            else if (numrank == 12)
            {
                rank = "ゴールド3";
            }
            else if (numrank == 13)
            {
                rank = "プラチナ1";
            }
            else if (numrank == 14)
            {
                rank = "プラチナ2";
            }
            else if (numrank == 15)
            {
                rank = "プラチナ3";
            }
            else if (numrank == 16)
            {
                rank = "ダイヤモンド1";
            }
            else if (numrank == 17)
            {
                rank = "ダイヤモンド2";
            }
            else if (numrank == 18)
            {
                rank = "ダイヤモンド3";
            }
            else if (numrank == 19)
            {
                rank = "アセンダント1";
            }
            else if (numrank == 20)
            {
                rank = "アセンダント2";
            }
            else if (numrank == 21)
            {
                rank = "アセンダント3";
            }
            else if (numrank == 22)
            {
                rank = "イモータル1";
            }
            else if (numrank == 23)
            {
                rank = "イモータル2";
            }
            else if (numrank == 24)
            {
                rank = "イモータル3";
            }
            else if (numrank == 25)
            {
                rank = "レディアント";
            }
            return rank;

        }

        //ランク数値化関数
        public int TointRank(string rank)
        {
            int numericRank=0;
            if (rank.Equals("アイアン1"))
            {
                numericRank = 1;
            }
            else if (rank.Equals("アイアン2"))
            {
                numericRank = 2;
            }
            else if (rank.Equals("アイアン3"))
            {
                numericRank = 3;
            } 
            else if (rank.Equals("ブロンズ1"))
            {
                numericRank = 4;
            }
            else if (rank.Equals("ブロンズ2"))
            {
                numericRank = 5;
            }
            else if (rank.Equals("ブロンズ3"))
            {
                numericRank = 6;
            }
            else if (rank.Equals("シルバー1"))
            {
                numericRank = 7;
            }
            else if (rank.Equals("シルバー2"))
            {
                numericRank = 8;
            }
            else if (rank.Equals("シルバー3") )
            {
                numericRank = 9;
            }
           
            else if (rank.Equals("ゴールド1"))
            {
                numericRank = 10;
            }
            else if (rank.Equals("ゴールド2") )
            {
                numericRank = 11;
            }
            else if (rank.Equals("ゴールド3"))
            {
                numericRank = 12;
            }
            else if (rank.Equals("プラチナ1"))
            {
                numericRank = 13;
            }
            else if (rank.Equals("プラチナ2"))
            {
                numericRank = 14;
            }
            else if (rank.Equals("プラチナ3") )
            {
                numericRank = 15;
            }
            else if (rank.Equals("ダイヤモンド1"))
            {
                numericRank = 16;
            }
            else if (rank.Equals("ダイヤモンド2"))
            {
                numericRank = 17;
            }
            else if (rank.Equals("ダイヤモンド3"))
            {
                numericRank = 18;
            }
            else if (rank.Equals("アセンダント1"))
            {
                numericRank = 19;
            }
            else if (rank.Equals("アセンダント2"))
            {
                numericRank = 20;
            }
            else if (rank.Equals("アセンダント3"))
            {
                numericRank = 21;
            }
            else if (rank.Equals("イモータル1"))
            {
                numericRank = 22;
            }
            else if (rank.Equals("イモータル2"))
            {
                numericRank = 23;
            }
            else if (rank.Equals("イモータル3"))
            {
                numericRank = 24;
            }
            else if (rank.Equals("レディアント"))
            {
                numericRank = 25;
            }

            return numericRank;
        }
    }
}
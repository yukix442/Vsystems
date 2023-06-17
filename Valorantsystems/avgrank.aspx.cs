using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Valorantsystems
{
    public partial class avgrank : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                dropdownlist1.Items.Add("ランク選択");
                dropdownlist1.Items.Add("アイアン1");
                dropdownlist1.Items.Add("アイアン2");
                dropdownlist1.Items.Add("アイアン3");
                dropdownlist1.Items.Add("ブロンズ1");
                dropdownlist1.Items.Add("ブロンズ2");
                dropdownlist1.Items.Add("ブロンズ3");
                dropdownlist1.Items.Add("シルバー1");
                dropdownlist1.Items.Add("シルバー2");
                dropdownlist1.Items.Add("シルバー3");
                dropdownlist1.Items.Add("ゴールド1");
                dropdownlist1.Items.Add("ゴールド2");
                dropdownlist1.Items.Add("ゴールド3");
                dropdownlist1.Items.Add("プラチナ1");
                dropdownlist1.Items.Add("プラチナ2");
                dropdownlist1.Items.Add("プラチナ3");
                dropdownlist1.Items.Add("ダイヤモンド1");
                dropdownlist1.Items.Add("ダイヤモンド2");
                dropdownlist1.Items.Add("ダイヤモンド3");
                dropdownlist1.Items.Add("アセンダント1");
                dropdownlist1.Items.Add("アセンダント2");
                dropdownlist1.Items.Add("アセンダント3");
                dropdownlist1.Items.Add("イモータル1");
                dropdownlist1.Items.Add("イモータル2");
                dropdownlist1.Items.Add("イモータル3");
                dropdownlist1.Items.Add("レディアント");

                dropdownlist2.Items.Add("ランク選択");
                dropdownlist2.Items.Add("アイアン1");
                dropdownlist2.Items.Add("アイアン2");
                dropdownlist2.Items.Add("アイアン3");
                dropdownlist2.Items.Add("ブロンズ1");
                dropdownlist2.Items.Add("ブロンズ2");
                dropdownlist2.Items.Add("ブロンズ3");
                dropdownlist2.Items.Add("シルバー1");
                dropdownlist2.Items.Add("シルバー2");
                dropdownlist2.Items.Add("シルバー3");
                dropdownlist2.Items.Add("ゴールド1");
                dropdownlist2.Items.Add("ゴールド2");
                dropdownlist2.Items.Add("ゴールド3");
                dropdownlist2.Items.Add("プラチナ1");
                dropdownlist2.Items.Add("プラチナ2");
                dropdownlist2.Items.Add("プラチナ3");
                dropdownlist2.Items.Add("ダイヤモンド1");
                dropdownlist2.Items.Add("ダイヤモンド2");
                dropdownlist2.Items.Add("ダイヤモンド3");
                dropdownlist2.Items.Add("アセンダント1");
                dropdownlist2.Items.Add("アセンダント2");
                dropdownlist2.Items.Add("アセンダント3");
                dropdownlist2.Items.Add("イモータル1");
                dropdownlist2.Items.Add("イモータル2");
                dropdownlist2.Items.Add("イモータル3");
                dropdownlist2.Items.Add("レディアント");

                dropdownlist3.Items.Add("ランク選択");
                dropdownlist3.Items.Add("アイアン1");
                dropdownlist3.Items.Add("アイアン2");
                dropdownlist3.Items.Add("アイアン3");
                dropdownlist3.Items.Add("ブロンズ1");
                dropdownlist3.Items.Add("ブロンズ2");
                dropdownlist3.Items.Add("ブロンズ3");
                dropdownlist3.Items.Add("シルバー1");
                dropdownlist3.Items.Add("シルバー2");
                dropdownlist3.Items.Add("シルバー3");
                dropdownlist3.Items.Add("ゴールド1");
                dropdownlist3.Items.Add("ゴールド2");
                dropdownlist3.Items.Add("ゴールド3");
                dropdownlist3.Items.Add("プラチナ1");
                dropdownlist3.Items.Add("プラチナ2");
                dropdownlist3.Items.Add("プラチナ3");
                dropdownlist3.Items.Add("ダイヤモンド1");
                dropdownlist3.Items.Add("ダイヤモンド2");
                dropdownlist3.Items.Add("ダイヤモンド3");
                dropdownlist3.Items.Add("アセンダント1");
                dropdownlist3.Items.Add("アセンダント2");
                dropdownlist3.Items.Add("アセンダント3");
                dropdownlist3.Items.Add("イモータル1");
                dropdownlist3.Items.Add("イモータル2");
                dropdownlist3.Items.Add("イモータル3");
                dropdownlist3.Items.Add("レディアント");

                dropdownlist4.Items.Add("ランク選択");
                dropdownlist4.Items.Add("アイアン1");
                dropdownlist4.Items.Add("アイアン2");
                dropdownlist4.Items.Add("アイアン3");
                dropdownlist4.Items.Add("ブロンズ1");
                dropdownlist4.Items.Add("ブロンズ2");
                dropdownlist4.Items.Add("ブロンズ3");
                dropdownlist4.Items.Add("シルバー1");
                dropdownlist4.Items.Add("シルバー2");
                dropdownlist4.Items.Add("シルバー3");
                dropdownlist4.Items.Add("ゴールド1");
                dropdownlist4.Items.Add("ゴールド2");
                dropdownlist4.Items.Add("ゴールド3");
                dropdownlist4.Items.Add("プラチナ1");
                dropdownlist4.Items.Add("プラチナ2");
                dropdownlist4.Items.Add("プラチナ3");
                dropdownlist4.Items.Add("ダイヤモンド1");
                dropdownlist4.Items.Add("ダイヤモンド2");
                dropdownlist4.Items.Add("ダイヤモンド3");
                dropdownlist4.Items.Add("アセンダント1");
                dropdownlist4.Items.Add("アセンダント2");
                dropdownlist4.Items.Add("アセンダント3");
                dropdownlist4.Items.Add("イモータル1");
                dropdownlist4.Items.Add("イモータル2");
                dropdownlist4.Items.Add("イモータル3");
                dropdownlist4.Items.Add("レディアント");

                dropdownlist5.Items.Add("ランク選択");
                dropdownlist5.Items.Add("アイアン1");
                dropdownlist5.Items.Add("アイアン2");
                dropdownlist5.Items.Add("アイアン3");
                dropdownlist5.Items.Add("ブロンズ1");
                dropdownlist5.Items.Add("ブロンズ2");
                dropdownlist5.Items.Add("ブロンズ3");
                dropdownlist5.Items.Add("シルバー1");
                dropdownlist5.Items.Add("シルバー2");
                dropdownlist5.Items.Add("シルバー3");
                dropdownlist5.Items.Add("ゴールド1");
                dropdownlist5.Items.Add("ゴールド2");
                dropdownlist5.Items.Add("ゴールド3");
                dropdownlist5.Items.Add("プラチナ1");
                dropdownlist5.Items.Add("プラチナ2");
                dropdownlist5.Items.Add("プラチナ3");
                dropdownlist5.Items.Add("ダイヤモンド1");
                dropdownlist5.Items.Add("ダイヤモンド2");
                dropdownlist5.Items.Add("ダイヤモンド3");
                dropdownlist5.Items.Add("アセンダント1");
                dropdownlist5.Items.Add("アセンダント2");
                dropdownlist5.Items.Add("アセンダント3");
                dropdownlist5.Items.Add("イモータル1");
                dropdownlist5.Items.Add("イモータル2");
                dropdownlist5.Items.Add("イモータル3");
                dropdownlist5.Items.Add("レディアント");
            }
                /*1色*/
                dropdownlist1.Items[7].Attributes["style"] = "background-color: #c0c0c0; ";
                dropdownlist1.Items[8].Attributes["style"] = "background-color: #c0c0c0; ";
                dropdownlist1.Items[9].Attributes["style"] = "background-color: #c0c0c0; ";
                dropdownlist1.Items[4].Attributes["style"] = "background-color: #ac6b25; ";
                dropdownlist1.Items[5].Attributes["style"] = "background-color: #ac6b25; ";
                dropdownlist1.Items[6].Attributes["style"] = "background-color: #ac6b25; ";
                dropdownlist1.Items[10].Attributes["style"] = "background-color: #ffd700; ";
                dropdownlist1.Items[11].Attributes["style"] = "background-color: #ffd700; ";
                dropdownlist1.Items[12].Attributes["style"] = "background-color: #ffd700; ";
                dropdownlist1.Items[13].Attributes["style"] = "background-color: #00bfff; ";
                dropdownlist1.Items[14].Attributes["style"] = "background-color: #00bfff; ";
                dropdownlist1.Items[15].Attributes["style"] = "background-color: #00bfff;";

                dropdownlist1.Items[16].Attributes["style"] = "background-color: #1e90ff; ";
                dropdownlist1.Items[17].Attributes["style"] = "background-color: #1e90ff; ";
                dropdownlist1.Items[18].Attributes["style"] = "background-color: #1e90ff;";
                dropdownlist1.Items[19].Attributes["style"] = "background-color: #3cb371; ";
                dropdownlist1.Items[20].Attributes["style"] = "background-color: #3cb371; ";
                dropdownlist1.Items[21].Attributes["style"] = "background-color: #3cb371;";
                dropdownlist1.Items[22].Attributes["style"] = "background-color: #8b0000; ";
                dropdownlist1.Items[23].Attributes["style"] = "background-color: #8b0000; ";
                dropdownlist1.Items[24].Attributes["style"] = "background-color: #8b0000;";
                dropdownlist1.Items[25].Attributes["style"] = "background-color: #daa520;";

                /*2色*/
                dropdownlist2.Items[7].Attributes["style"] = "background-color: #c0c0c0; ";
                dropdownlist2.Items[8].Attributes["style"] = "background-color: #c0c0c0; ";
                dropdownlist2.Items[9].Attributes["style"] = "background-color: #c0c0c0; ";
                dropdownlist2.Items[4].Attributes["style"] = "background-color: #ac6b25; ";
                dropdownlist2.Items[5].Attributes["style"] = "background-color: #ac6b25; ";
                dropdownlist2.Items[6].Attributes["style"] = "background-color: #ac6b25; ";
                dropdownlist2.Items[10].Attributes["style"] = "background-color: #ffd700; ";
                dropdownlist2.Items[11].Attributes["style"] = "background-color: #ffd700; ";
                dropdownlist2.Items[12].Attributes["style"] = "background-color: #ffd700; ";
                dropdownlist2.Items[13].Attributes["style"] = "background-color: #00bfff; ";
                dropdownlist2.Items[14].Attributes["style"] = "background-color: #00bfff; ";
                dropdownlist2.Items[15].Attributes["style"] = "background-color: #00bfff;";
                dropdownlist2.Items[16].Attributes["style"] = "background-color: #1e90ff; ";
                dropdownlist2.Items[17].Attributes["style"] = "background-color: #1e90ff; ";
                dropdownlist2.Items[18].Attributes["style"] = "background-color: #1e90ff;";
                dropdownlist2.Items[19].Attributes["style"] = "background-color: #3cb371; ";
                dropdownlist2.Items[20].Attributes["style"] = "background-color: #3cb371; ";
                dropdownlist2.Items[21].Attributes["style"] = "background-color: #3cb371;";
                dropdownlist2.Items[22].Attributes["style"] = "background-color: #8b0000; ";
                dropdownlist2.Items[23].Attributes["style"] = "background-color: #8b0000; ";
                dropdownlist2.Items[24].Attributes["style"] = "background-color: #8b0000;";
                dropdownlist2.Items[25].Attributes["style"] = "background-color: #daa520;";


                /*3色*/

                dropdownlist3.Items[7].Attributes["style"] = "background-color: #c0c0c0; ";
                dropdownlist3.Items[8].Attributes["style"] = "background-color: #c0c0c0; ";
                dropdownlist3.Items[9].Attributes["style"] = "background-color: #c0c0c0; ";
                dropdownlist3.Items[4].Attributes["style"] = "background-color: #ac6b25; ";
                dropdownlist3.Items[5].Attributes["style"] = "background-color: #ac6b25; ";
                dropdownlist3.Items[6].Attributes["style"] = "background-color: #ac6b25; ";
                dropdownlist3.Items[10].Attributes["style"] = "background-color: #ffd700; ";
                dropdownlist3.Items[11].Attributes["style"] = "background-color: #ffd700; ";
                dropdownlist3.Items[12].Attributes["style"] = "background-color: #ffd700; ";
                dropdownlist3.Items[13].Attributes["style"] = "background-color: #00bfff; ";
                dropdownlist3.Items[14].Attributes["style"] = "background-color: #00bfff; ";
                dropdownlist3.Items[15].Attributes["style"] = "background-color: #00bfff;";
                dropdownlist3.Items[16].Attributes["style"] = "background-color: #1e90ff; ";
                dropdownlist3.Items[17].Attributes["style"] = "background-color: #1e90ff; ";
                dropdownlist3.Items[18].Attributes["style"] = "background-color: #1e90ff;";
                dropdownlist3.Items[19].Attributes["style"] = "background-color: #3cb371; ";
                dropdownlist3.Items[20].Attributes["style"] = "background-color: #3cb371; ";
                dropdownlist3.Items[21].Attributes["style"] = "background-color: #3cb371;";
                dropdownlist3.Items[22].Attributes["style"] = "background-color: #8b0000; ";
                dropdownlist3.Items[23].Attributes["style"] = "background-color: #8b0000; ";
                dropdownlist3.Items[24].Attributes["style"] = "background-color: #8b0000;";
                dropdownlist3.Items[25].Attributes["style"] = "background-color: #daa520;";


                /*4色*/
                dropdownlist4.Items[7].Attributes["style"] = "background-color: #c0c0c0; ";
                dropdownlist4.Items[8].Attributes["style"] = "background-color: #c0c0c0; ";
                dropdownlist4.Items[9].Attributes["style"] = "background-color: #c0c0c0; ";
                dropdownlist4.Items[4].Attributes["style"] = "background-color: #ac6b25; ";
                dropdownlist4.Items[5].Attributes["style"] = "background-color: #ac6b25; ";
                dropdownlist4.Items[6].Attributes["style"] = "background-color: #ac6b25; ";
                dropdownlist4.Items[10].Attributes["style"] = "background-color: #ffd700; ";
                dropdownlist4.Items[11].Attributes["style"] = "background-color: #ffd700; ";
                dropdownlist4.Items[12].Attributes["style"] = "background-color: #ffd700; ";
                dropdownlist4.Items[13].Attributes["style"] = "background-color: #00bfff; ";
                dropdownlist4.Items[14].Attributes["style"] = "background-color: #00bfff; ";
                dropdownlist4.Items[15].Attributes["style"] = "background-color: #00bfff;";

                dropdownlist4.Items[16].Attributes["style"] = "background-color: #1e90ff; ";
                dropdownlist4.Items[17].Attributes["style"] = "background-color: #1e90ff; ";
                dropdownlist4.Items[18].Attributes["style"] = "background-color: #1e90ff;";
                dropdownlist4.Items[19].Attributes["style"] = "background-color: #3cb371; ";
                dropdownlist4.Items[20].Attributes["style"] = "background-color: #3cb371; ";
                dropdownlist4.Items[21].Attributes["style"] = "background-color: #3cb371;";
                dropdownlist4.Items[22].Attributes["style"] = "background-color: #8b0000; ";
                dropdownlist4.Items[23].Attributes["style"] = "background-color: #8b0000; ";
                dropdownlist4.Items[24].Attributes["style"] = "background-color: #8b0000;";
                dropdownlist4.Items[25].Attributes["style"] = "background-color: #daa520;";


                /*5色*/
                dropdownlist5.Items[7].Attributes["style"] = "background-color: #c0c0c0; ";
                dropdownlist5.Items[8].Attributes["style"] = "background-color: #c0c0c0; ";
                dropdownlist5.Items[9].Attributes["style"] = "background-color: #c0c0c0; ";
                dropdownlist5.Items[4].Attributes["style"] = "background-color: #ac6b25; ";
                dropdownlist5.Items[5].Attributes["style"] = "background-color: #ac6b25; ";
                dropdownlist5.Items[6].Attributes["style"] = "background-color: #ac6b25; ";
                dropdownlist5.Items[10].Attributes["style"] = "background-color: #ffd700; ";
                dropdownlist5.Items[11].Attributes["style"] = "background-color: #ffd700; ";
                dropdownlist5.Items[12].Attributes["style"] = "background-color: #ffd700; ";
                dropdownlist5.Items[13].Attributes["style"] = "background-color: #00bfff; ";
                dropdownlist5.Items[14].Attributes["style"] = "background-color: #00bfff; ";
                dropdownlist5.Items[15].Attributes["style"] = "background-color: #00bfff;";
                dropdownlist5.Items[16].Attributes["style"] = "background-color: #1e90ff; ";
                dropdownlist5.Items[17].Attributes["style"] = "background-color: #1e90ff; ";
                dropdownlist5.Items[18].Attributes["style"] = "background-color: #1e90ff;";
                dropdownlist5.Items[16].Attributes["style"] = "background-color: #1e90ff; ";
                dropdownlist5.Items[17].Attributes["style"] = "background-color: #1e90ff; ";
                dropdownlist5.Items[18].Attributes["style"] = "background-color: #1e90ff;";
                dropdownlist5.Items[19].Attributes["style"] = "background-color: #3cb371; ";
                dropdownlist5.Items[20].Attributes["style"] = "background-color: #3cb371; ";
                dropdownlist5.Items[21].Attributes["style"] = "background-color: #3cb371;";
                dropdownlist5.Items[22].Attributes["style"] = "background-color: #8b0000; ";
                dropdownlist5.Items[23].Attributes["style"] = "background-color: #8b0000; ";
                dropdownlist5.Items[24].Attributes["style"] = "background-color: #8b0000;";
                dropdownlist5.Items[25].Attributes["style"] = "background-color: #daa520;";

        }



        protected void dropdownlist1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ドロップダウンリストの選択が変更されたときに実行する処理をここに記述します
        }
        protected void dropdownlist2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ドロップダウンリストの選択が変更されたときに実行する処理をここに記述します
        }

        protected void dropdownlist3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ドロップダウンリストの選択が変更されたときに実行する処理をここに記述します
        }
        protected void dropdownlist4_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ドロップダウンリストの選択が変更されたときに実行する処理をここに記述します
        }
        protected void dropdownlist5_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ドロップダウンリストの選択が変更されたときに実行する処理をここに記述します
        }

    
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            function func = new function();
            int[] rank=new int[5];
            string a;
            
                a = string.Format("{0:s}",
                dropdownlist1.SelectedItem);
                rank[0] = func.TointRank(a);

            a = string.Format("{0:s}",
                dropdownlist2.SelectedItem);
            rank[1] = func.TointRank(a);

            a = string.Format("{0:s}",
                dropdownlist3.SelectedItem);
            rank[2] = func.TointRank(a);

            a = string.Format("{0:s}",
                dropdownlist4.SelectedItem);
            rank[3] = func.TointRank(a);

            a = string.Format("{0:s}",
                dropdownlist5.SelectedItem);
            rank[4] = func.TointRank(a);

            if (rank[0] != 0 && rank[1] != 0 && rank[2] != 0 && rank[3] != 0 && rank[4] != 0)
            {
                a = func.AvgRank(rank[0], rank[1], rank[2], rank[3], rank[4]);

                Label1.Text = "平均ランクは" + a + "です。";
            }
            else
                Label1.Text="ランクを選択してください。";
        }
    }
}
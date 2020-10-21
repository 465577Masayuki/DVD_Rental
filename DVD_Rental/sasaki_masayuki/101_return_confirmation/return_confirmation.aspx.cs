using DVD_Rental.sasaki_masayuki._0_common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DVD_Rental.sasaki_masayuki._101_return_confirmation
{
    public partial class return_confirmation : System.Web.UI.Page
    {
        private List<int> return_dvd_id_list = new List<int>();
        private int m_member_id;

        protected void Page_Load(object sender, EventArgs e)
        {

            //dvdidの文字列取得
            String selected_dvd_id = Session["Select_DVD_ID"].ToString();
            //,で区切られたdvdidを分割
            string[] str_arr = selected_dvd_id.Split(',');

            //メンバーID格納
            m_member_id = int.Parse(Session["Member_ID"].ToString());

            //リストに格納
            int dvd_id_num = str_arr.Length;

            for (int i = 0; i < dvd_id_num; i++)
            {
                return_dvd_id_list.Add(int.Parse(str_arr[i]));
            }

            if (!IsPostBack)
            {
                //ポストバックじゃなければ

                //Listのクリア
                BulletedList1.Items.Clear();

                for (int i = 0; i < dvd_id_num; i++)
                {
                    string dvd_name = C_Sasaki_Common.Extract_The_Name_Of_The_DVD_That_Matches_The_DVD_ID(str_arr[i]);
                    BulletedList1.Items.Add(dvd_name);
                }

            }

            Label1.Text = "以下の" + BulletedList1.Items.Count + "点の商品を返却します。"; 
        }

        //キャンセルボタン
        protected void Button1_Click(object sender, EventArgs e)
        {
            Termination_Process();
            Redirect_Regression_Management();
        }

        //確定ボタン
        protected void Button2_Click(object sender, EventArgs e)
        {
            //選択されたIDの取得
            string selected_id_str = Session["Selected_ID"].ToString();
            Session.Remove("Selected_ID");
            //選択されたIDを配列に格納
            string[] selcted_id = selected_id_str.Split(',');


            int return_dvd_num = return_dvd_id_list.Count();
            for (int i = 0; i < return_dvd_num; i++)
            {
                //返却するDVDIDのStockを増やす。
                C_Sasaki_Common.Update_SQL("Update [dbo].[Stock] SET Quantity += 1 Where DVDId = " + return_dvd_id_list[i]);

                //RentalDBのIDと選択されたIDが一致する物のIsReturnedフラグをtrueに設定。(※一つだけ)
                C_Sasaki_Common.Update_SQL("Update [dbo].[Rental] SET IsReturned = 1 Where " + selcted_id[i] + " =  Id");
            }

            Termination_Process();
            Redirect_Regression_Management();
        }

        //返却管理画面に遷移する関数
        private void Redirect_Regression_Management()
        {
            Response.Redirect("/sasaki_masayuki/100_regression_management/regression_management.aspx");
        }

        //終了処理
        private void Termination_Process()
        {
            return_dvd_id_list.Clear();
        }

    }

}
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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //キャンセルボタン
        protected void Button1_Click(object sender, EventArgs e)
        {
            Redirect_Regression_Management();
        }

        //確定ボタン
        protected void Button2_Click(object sender, EventArgs e)
        {
            Redirect_Regression_Management();
        }

        //返却管理画面に遷移する関数
        private void Redirect_Regression_Management()
        {
            Response.Redirect("/sasaki_masayuki/100_regression_management/regression_management.aspx");
        }
    }
}
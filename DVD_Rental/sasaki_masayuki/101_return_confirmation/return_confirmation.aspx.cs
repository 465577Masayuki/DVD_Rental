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
            if (Request.Cookies["login"] != null)
            {
                if (Request.Cookies["login"].Value != "")
                {
                    if (Session[Request.Cookies["login"].Value] != null)
                    {
                        if (Session[Request.Cookies["login"].Value].ToString() == "0")
                        {
                            Response.Redirect("./../../rental.aspx");
                        }
                    }
                    else
                    {
                        Session[Request.Cookies["login"].Value] = null;
                        Response.Cookies["login"].Expires = DateTime.Now.AddDays(-1);
                        Response.Redirect("./../../login.aspx");
                    }
                }
                else
                {
                    Response.Cookies["login"].Expires = DateTime.Now.AddDays(-1);
                    Response.Redirect("./../../login.aspx");
                }
            }
            else
            {
                Response.Cookies["login"].Expires = DateTime.Now.AddDays(-1);
                Response.Redirect("./../../login.aspx");
            }
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
using DVD_Rental.sasaki_masayuki._0_common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace DVD_Rental.sasaki_masayuki._100_regression_management
{
    public partial class WebForm1 : System.Web.UI.Page
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

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender,EventArgs e)
        {
            //ログアウト処理
            Session[Request.Cookies["login"].Value] = null;
            Response.Cookies["login"].Expires = DateTime.Now.AddDays(-1);
            Response.Redirect("./../../login.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("/sasaki_masayuki/101_return_confirmation/return_confirmation.aspx");
        }



        //テキストボックスに入力されているテキストを取得
        //※テキストが入力されていない場合nullを返します。
        private string Get_Text()
        {
            try
            {
                return TextBox1.Text;
            }
            catch (Exception ex)
            {
                C_Sasaki_Common.Catch_An_Exception(ex);
            }
            return null;
        }

        
    }
}
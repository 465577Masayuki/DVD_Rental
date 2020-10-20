using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DVD_Rental
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Session["id_err_flag"] = 0;
                Session["pw_err_flag"] = 0;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //ID : 15文字 英数字
            //PW : 25文字 英数字

            //user_idの英数字判定
            if(new Regex("^[0-9a-zA-Z]+$").IsMatch(user_id.Text))
            {
                Session["id_err_flag"] = 0;

                //passwdの英数字判定
                if (new Regex("^[0-9a-zA-Z]+$").IsMatch(passwd.Text))
                {
                    //認証処理


                    //データベース
                    ConnectDB db = new ConnectDB();
                    string[] status = db.auth(user_id.Text,passwd.Text);

                    try
                    {
                        if (Convert.ToBoolean(status[0]) == true)
                        {
                            //管理者フラグ成立
                            //Session.Remove("id_err_flag");
                            //Session.Remove("pw_err_flag");

                            Session[status[1]] = "1";
                            Response.Cookies["login"].Value = status[1];
                            Response.Cookies["login"].Expires = DateTime.Now.AddDays(1);
                        }
                        else if (Convert.ToBoolean(status[0]) == false)
                        {
                            //管理者フラグ非成立
                            //Session.Remove("id_err_flag");
                            //Session.Remove("pw_err_flag");

                            Session[status[1]] = "0";
                            Response.Cookies["login"].Value = status[1];
                            Response.Cookies["login"].Expires = DateTime.Now.AddDays(1);
                        }
                    }
                    catch(Exception err)
                    {
                        if (int.Parse(status[0]) == -1)
                        {
                            //ログインできない
                        }
                    }

                }
                else
                {
                    //パスワードのエラー
                    Session["pw_err_flag"] = 1;
                }
            }
            else
            {

                //passwdの英数字判定
                if (new Regex("^[0-9a-zA-Z]+$").IsMatch(passwd.Text))
                {
                    //IDのエラー
                    Session["id_err_flag"] = 1;
                }
                else
                {
                    //IDとパスワードのエラー
                    Session["id_err_flag"] = 1;
                    Session["pw_err_flag"] = 1;
                }
            }
        }
    }
}
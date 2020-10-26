using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Drawing;
using DVD_Rental.sasaki_masayuki._0_common;


namespace Rental_Form
{
    public partial class RentalForm : System.Web.UI.Page
    {
        private static SqlConnection sqlConnection;
        private static SqlDataReader sqlDataReader;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["login"] != null)
            {
                if (Request.Cookies["login"].Value != "")
                {
                    if (Session[Request.Cookies["login"].Value] != null)
                    {
                        if (Session[Request.Cookies["login"].Value].ToString() == "1")
                        {
                            Response.Redirect("/sasaki_masayuki/100_regression_management/regression_management.aspx");
                        }
                    }
                    else
                    {
                        Session[Request.Cookies["login"].Value] = null;
                        Response.Cookies["login"].Expires = DateTime.Now.AddDays(-1);
                        Response.Redirect("./login.aspx");
                    }
                }
                else
                {
                    Response.Cookies["login"].Expires = DateTime.Now.AddDays(-1);
                    Response.Redirect("./login.aspx");
                }
            }
            else
            {
                Response.Cookies["login"].Expires = DateTime.Now.AddDays(-1);
                Response.Redirect("./login.aspx");
            }

            //確認画面からのエラーがあれば表示する
            if (Session["confirmation_error"] != null)
            {
                Label1.Text = Session["confirmation_error"].ToString();
            }

            Button1.Text = "ログアウト";
            Button2.Text = "選択した商品をレンタル";

            string connectionString = "Data Source = .\\SQLEXPRESS;" + "Initial Catalog = DVDRentalDB ;" + "Integrated Security = True ;";
            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            sqlCommand.CommandText = "Select * From [DVD]";

            sqlDataReader = sqlCommand.ExecuteReader();
            

            sqlCommand.Dispose();


            if(!IsPostBack)
            {

                CheckBoxList1.Items.Clear();
                // DVDを表示
                while (sqlDataReader.Read())
                {
                    string str = sqlDataReader["Name"].ToString();
                    CheckBoxList1.Items.Add(str);
                    

                }
            }


            sqlDataReader.Close();
            sqlConnection.Close();
            sqlConnection.Dispose();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            Label1.Text = "";
            Session.Remove("confirmation_error");

            int count = 1;                // DVDIDカウント

            // チェックが入っているものをSessionに入れる（力技）
            foreach (ListItem li in CheckBoxList1.Items)
            {
                // チェックが付いているものにデータを入れる
                if (li.Selected)
                {
                    switch (count)
                    {

                        case 1:
                            Session["DVD1"] = li.Text;
                            break;
                        case 2:
                            Session["DVD2"] = li.Text;
                            break;
                        case 3:
                            Session["DVD3"] = li.Text;
                            break;
                        case 4:
                            Session["DVD4"] = li.Text;
                            break;
                        case 5:
                            Session["DVD5"] = li.Text;
                            break;
                        case 6:
                            Session["DVD6"] = li.Text;
                            break;
                        case 7:
                            Session["DVD7"] = li.Text;
                            break;
                        case 8:
                            Session["DVD8"] = li.Text;
                            break;
                        case 9:
                            Session["DVD9"] = li.Text;
                            break;
                        case 10:
                            Session["DVD10"] = li.Text;
                            break;
                        case 11:
                            Session["DVD11"] = li.Text;
                            break;
                        case 12:
                            Session["DVD12"] = li.Text;
                            break;

                    }
                }
                // チェックがついていないものにはなにもいれない
                else
                {
                    switch (count)
                    {
                        case 1:
                            Session.Remove("DVD1");
                            break;
                        case 2:
                            Session.Remove("DVD2");
                            break;
                        case 3:
                            Session.Remove("DVD3");
                            break;
                        case 4:
                            Session.Remove("DVD4");
                            break;
                        case 5:
                            Session.Remove("DVD5");
                            break;
                        case 6:
                            Session.Remove("DVD6");
                            break;
                        case 7:
                            Session.Remove("DVD7");
                            break;
                        case 8:
                            Session.Remove("DVD8");
                            break;
                        case 9:
                            Session.Remove("DVD9");
                            break;
                        case 10:
                            Session.Remove("DVD10");
                            break;
                        case 11:
                            Session.Remove("DVD11");
                            break;
                        case 12:
                            Session.Remove("DVD12");
                            break;

                    }
                }

                count++;
            }

            Session["MemberID"] = TextBox1.Text;

            List<string> Dvdid = new List<string>();
            for (int i = 1; i <= 12; i++)
            {
                if (Session["DVD" + i.ToString()] != null)
                {
                    if (Session["DVD" + i.ToString()].ToString() != "")
                    {

                        Dvdid.Add(C_Sasaki_Common.Convert_DVD_Name_To_ID(Session["DVD" + i.ToString()].ToString()));

                    }
                }

            }
            Session["dvdid"] = string.Join(",", Dvdid);

            List<string> Stock_UpdateDateTime;
            Stock_UpdateDateTime = C_Sasaki_Common.Get_Stock_Update_Date_Time_For_DVD_Id(Dvdid);
            Session["RentalForm_Stock_UpdateDateTime"] = string.Join(",", Stock_UpdateDateTime);

            Response.Redirect("RentalConfirm.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // ログアウト処理
            Session[Request.Cookies["login"].Value] = null;
            Response.Cookies["login"].Expires = DateTime.Now.AddDays(-1);
            Response.Redirect("Login.aspx");
        }
    }
}
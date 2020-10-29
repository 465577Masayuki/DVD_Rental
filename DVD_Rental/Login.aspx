<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DVD_Rental.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="./css/style.css" />
</head>
<body>
    <div class="bg"></div>
    <div class="bg bg2"></div>
    <div class="bg bg3"></div>
    <form id="form1" runat="server">
        <div class="wrap">
            <div class="text_area">
                <asp:TextBox ID="user_id" CssClass="text" runat="server" MaxLength="15" placeholder="ID"></asp:TextBox>
                <div class="underline"></div>
            </div>
            <div class="text_area">
                <asp:TextBox ID="passwd" CssClass="text" runat="server" TextMode="Password" MaxLength="25" placeholder="Password"></asp:TextBox>
                <div class="underline"></div>
            </div>
            <div class="button_area">
                <asp:Button ID="Button1" runat="server" Text="ログイン" OnClick="Button1_Click" />
            </div>
        </div>
    </form>

    <script>
        if (<%=Session["id_err_flag"] %>) {
            //document.getElementById("Label1").style.color = "#ff0000";
        }
        else {
            //document.getElementById("Label1").style.color = "#000000";
        }

        if (<%=Session["pw_err_flag"] %>) {
            //document.getElementById("Label2").style.color = "#ff0000";
        }
        else {
            //document.getElementById("Label2").style.color = "#000000";
        }
    </script>
</body>
</html>

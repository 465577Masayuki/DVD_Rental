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
            <div id="err_notification">
                <span id="err"></span>
            </div>
            <div class="text_area">
                <asp:TextBox ID="user_id" CssClass="text" runat="server" MaxLength="15" placeholder="ID"></asp:TextBox>
                <div id="id_underline" class="underline"></div>
            </div>
            <div class="text_area">
                <asp:TextBox ID="passwd" CssClass="text" runat="server" TextMode="Password" MaxLength="25" placeholder="Password"></asp:TextBox>
                <div id="pw_underline" class="underline"></div>
            </div>
            <div class="button_area">
                <asp:Button ID="Button1" CssClass="login_btn" runat="server" Text="Login" OnClick="Button1_Click" />
            </div>
        </div>
    </form>

    <script>
        document.getElementById("err_notification").style.display = "none";
        if (<%=Session["id_err_flag"] %> && <%=Session["pw_err_flag"] %>) {
            document.getElementById("err").innerText = "IDとパスワードの入力値を確認してください。";
            document.getElementById("err_notification").style.display = "block";
            document.getElementById("id_underline").style.background = "red";
            document.getElementById("pw_underline").style.background = "red";
        } else if (<%=Session["id_err_flag"] %>) {
            document.getElementById("err").innerText = "IDの入力値を確認してください。";
            document.getElementById("err_notification").style.display = "block";
            document.getElementById("id_underline").style.background = "red";
        } else if (<%=Session["pw_err_flag"] %>) {
            document.getElementById("err").innerText = "パスワードの入力値を確認してください。";
            document.getElementById("err_notification").style.display = "block";
            document.getElementById("pw_underline").style.background = "red";
        } else if (<%=Session["failed_login"] %>) {
            document.getElementById("err").innerText = "ログインに失敗しました。";
            document.getElementById("err_notification").style.display = "block";
        }
    </script>
</body>
</html>

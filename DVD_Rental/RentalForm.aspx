<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RentalForm.aspx.cs" Inherits="Rental_Form.RentalForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
        <link rel="stylesheet" href="./css/Rental_Style.css" />
</head>

<body>
    <div class="bg"></div>
    <div class="bg bg2"></div>
    <div class="bg bg3"></div>
    <form id="form1" runat="server">

        <%--<div style = "text-align: center">--%>
        <div class ="content ">
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            <br />

        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 231px" Text="ログアウト" Width="120px" />
        <br />

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
        <br />

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="会員ID"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" style="margin-top: 0px; margin-bottom: 3px;" OnTextChanged="TextBox1_TextChanged" TextMode ="Number" Width="172px"></asp:TextBox>
        <br />

        <asp:Label ID="Label3" runat="server" Text="商品一覧"></asp:Label>

             <div style = "text-align: left">
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" Height="21px" Width="351px">
        </asp:CheckBoxList>
             </div>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="margin-left: 62px" Text="選択した商品をレンタル" Width="242px" />
         <br />
        </div>

    </form>
</body>
</html>

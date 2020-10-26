<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RentalForm.aspx.cs" Inherits="Rental_Form.RentalForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 255px" Text="Button" Width="122px" />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 　&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 会員ID&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" style="margin-top: 0px"></asp:TextBox>
        <br />
        商品一覧<asp:CheckBoxList ID="CheckBoxList1" runat="server" Height="21px" Width="383px">
        </asp:CheckBoxList>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="margin-left: 135px" Text="Button" Width="250px" />
        <br />
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RentalConfirm.aspx.cs" Inherits="Rental_Form.RentalConfirm" %>

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

        <div class ="content ">

            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />

                 <div style = "text-align: left">
            <asp:BulletedList ID="BulletedList1" runat="server" style="margin-left: 22px" Height="232px" Width="278px">
            </asp:BulletedList>
                 </div>

            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="キャンセル" OnClick="Button1_Click" Width="115px" />
            
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="確定" OnClick="Button2_Click" Width="115px" />
            <br />
        </div>

    </form>
</body>
</html>

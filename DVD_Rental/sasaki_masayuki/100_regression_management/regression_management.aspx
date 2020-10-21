<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="regression_management.aspx.cs" Inherits="DVD_Rental.sasaki_masayuki._100_regression_management.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <%--右詰めでテキスト等を配置 --%>
        <div style="text-align: right">

            <%-- 1行目--%>
            <p>
                <%-- ログアウトボタン--%>
                <asp:Button ID="Button1" runat="server" Text="ログアウト" OnClick="Button1_Click" />
            </p>

            <%-- 2行目--%>
            <p>
                <%-- 会員ID（テキスト）の表示--%>
                <asp:Label ID="Label1" runat="server" Text="会員ID"></asp:Label>
                <%-- テキストボックスの挿入--%>
                <%--                            Columns:(テキストボックスの横幅) style:(入力テキストの右寄せ)--%>
                <asp:TextBox ID="TextBox1" runat="server" Columns="30" Style="text-align: right" OnTextChanged="TextBox1_TextChanged" Numeric="true"></asp:TextBox>
            </p>

            <%-- 3行目--%>
            <p>

                <asp:Button ID="Button2" runat="server" Text="レンタル中の商品を表示" OnClick="Button2_Click" />

            </p>

            <%-- 4行目--%>

            <asp:Label ID="Label2" runat="server" Text="レンタル商品一覧"></asp:Label>

            <%-- 5行目--%>
            <p>
                <%--チェックボックスのリスト--%>
                <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                </asp:CheckBoxList>
            </p>

            <%-- 6行目--%>
            <p>
                <asp:Button ID="Button3" runat="server" Text="選択した商品を返却" OnClick="Button3_Click" />
            </p>

        </div>
    </form>
</body>
</html>

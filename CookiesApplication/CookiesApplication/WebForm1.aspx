<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CookiesApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 329px">
    <form id="form1" runat="server">
        <div>
            Web Application Form1</div>
        <br />
        Name:<p>
            <asp:TextBox ID="textName" runat="server" Width="263px"></asp:TextBox>
        </p>
        Email:<p>
            <asp:TextBox ID="textEmail" runat="server" Width="264px"></asp:TextBox>
        </p>
        <asp:Button ID="btnSend1" runat="server" OnClick="btnSend1_Click" style="margin-left: 34px" Text="Send to Form2" Width="202px" />
    </form>
</body>
</html>

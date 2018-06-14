<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Enter your name:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
        <br />
        Hit submit to save the data in session. this data will then be remembered using
        Session variables.<br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" /><br />
        <br />
        You have entered:
        <asp:Label ID="Label1" runat="server" Font-Bold="True"></asp:Label><br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Check" OnClick="Button2_Click" /><br />
        <br />
        Use this check buttom to see you name has been remembered by the server.</div>
    </form>
</body>
</html>

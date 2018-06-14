<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PoliticalPage.aspx.cs" Inherits="ASPPoliticalReview.PoliticalPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Political Review</title>
</head>
<body>
    <form id="form1" runat="server">
        
        <table style="width: 100%;">
            <tr>
                <td align ="center">

                    <table style="width: 600px;">
                        <tr>
                            <td colspan="5">
                                <asp:Panel ID="Panel1" runat="server" GroupingText="Politicians" Font-Bold="True" Font-Italic="True" Font-Names="Arial" ForeColor="#3333CC">
                                    <asp:DropDownList ID="cboPoliticians" Width="98%" runat="server" AutoPostBack="True" OnSelectedIndexChanged="cboPoliticians_SelectedIndexChanged"></asp:DropDownList>
                                </asp:Panel>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="5">
                                <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>Years In Office:</td>
                            <td>
                                <asp:TextBox ID="txtYOF" runat="server"></asp:TextBox>
                            </td>
                            <td>Job:</td>
                            <td style ="width:150px;">
                                <asp:TextBox ID="txtJob" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:CheckBox ID="chkLiberal" runat="server" /> &nbsp;IsLiberal?</td>
                        </tr>
                    </table>

                </td>
            </tr>
        </table>
       
    </form>
</body>
</html>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="Adventure14.Views.Products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 68px;
        }
    </style>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="../scripts/Product.js"></script>
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>

            <table style="width: 100%;">
                <tr>
                    <td class="pageHeader">Product<input id="txtParams" type="hidden" runat="server" /></td>
                </tr>
                <tr>
                    <td align="left">
                        &nbsp;</td>
            
                </tr>
                <tr>
                    <td align="left">
                        <table style="width:auto">
                            <tr>
                                <td>
                                    <asp:RadioButton ID="optCultureEN" GroupName="Culture" runat="server" OnCheckedChanged ="optCultureEN_CheckedChanged" Text="English" CssClass="cellHeader" Checked="True" AutoPostBack="true" />
                                </td>
                                <td>
                                    <asp:RadioButton ID="optCultureFR" GroupName="Culture" runat="server" OnCheckedChanged ="optCultureEN_CheckedChanged" Text="French" CssClass="cellHeader" AutoPostBack="True" />
                                </td>
                                <td class="auto-style1">
                                    <asp:RadioButton ID="optCultureHR" GroupName="Culture" runat="server" OnCheckedChanged ="optCultureEN_CheckedChanged" Text="Hebrew" CssClass="cellHeader" AutoPostBack="true"/>
                                </td>
                                <td>
                                    <asp:RadioButton ID="optCultureAR" GroupName="Culture" runat="server" OnCheckedChanged ="optCultureEN_CheckedChanged" Text="Arab" CssClass="cellHeader" AutoPostBack="true"/>
                                </td>
                                <td style="width:200px;">

                                    <asp:RadioButton ID="optCultureGE" runat="server" AutoPostBack="true" CssClass="cellHeader" GroupName="Culture" OnCheckedChanged="optCultureEN_CheckedChanged" Text="German" />

                                </td>
                                <td id ="tdRecodrCount" runat="server" style="color:navy; font-weight:600; font-size:12px;">
                                        
                                    &nbsp;</td>
                            </tr>
                        </table>
                        <asp:Button ID="Button2" runat="server" Text="Button" />
                    </td> 
                </tr>
                <tr>
                    <td>
                        <div style="width:98%; height: 600px; overflow:auto;">
                            <table style="width: 100%;">
                                <tr>
                                    <td id="tdContent" runat="server"></td>
                                </tr>
                            </table>
                        </div>
                    </td>               
                </tr>
            </table>

        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>

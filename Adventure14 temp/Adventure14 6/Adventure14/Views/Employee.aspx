<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="Adventure14.Views.Employee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="../scripts/Employee.js"></script>
    <table style="width: 100%;">
        <tr>
            <td class="pageHeader">Employees</td>
        </tr>
        <tr>
            <td align="left">
                <asp:Label ID="lblMessage" runat="server"></asp:Label>
                <input id="txtSearch" type="hidden" runat="server"/>
            </td>
        </tr>
        <tr>
            <td align="left">
                <table style="width:auto; border-spacing:1px;">
                    <tr>
                        <td class="cellHeader" style="width:80px;" >Department: </td>
                        <td>
                            <asp:DropDownList ID="cboDepartment" runat="server" CssClass="dropdownmenu"  style="width:230px; height:25px;"/>
                        </td>
                        <td>
                            <asp:DropDownList ID="cboEmployees" runat="server" CssClass="dropdownmenu"  style="width:230px; height:25px;"/>
                        </td>
                        <td class="cellHeader">
                            <asp:Image ID="imgFilter" runat="server"  ToolTip="Search..." ImageAlign="Middle" ImageUrl="~/Images/Filter.jpg" />
                        </td>
                    </tr>
                </table>
            </td> 
        </tr>
        <tr>
            <td>
                <hr />
            </td>
        </tr>
        <tr>
            <td>

            </td>
        </tr>
    </table>

</asp:Content>

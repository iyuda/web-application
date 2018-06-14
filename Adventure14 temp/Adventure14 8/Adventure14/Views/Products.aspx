﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="Adventure14.Views.Products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">

        <ContentTemplate>

            <table style="width: 100%;">
                <tr>
                    <td class="pageHeader">Products<input id="txtParams" type="hidden" runat="server" /></td>
                </tr>
                <tr>
                    <td align="left">
                        <asp:Label ID="lblMessage" runat="server"></asp:Label>
                    </td>
            
                </tr>
                <tr>
                    <td align="left">
                        <table style="width:auto; border-spacing:1px;">
                            <tr>
                                <td class="cellHeader" style="width:80px;" >Product: </td>
                                <td>
                                    <asp:DropDownList ID="cboProduct" runat="server" CssClass="dropdownmenu"  style="width:230px; height:25px;"/>
                                </td>
                                <td class="cellHeader">
                                   <%-- <asp:Image ID="imgFilter" runat="server"  ToolTip="Search..." ImageAlign="Middle" ImageUrl="~/Images/Filter.jpg" />--%>
                                    <%--<asp:Button ID="btnSeachMe" runat="server" CssClass="menuButton" Text="Seach" ToolTip="Seach" Width="90" OnClick="btnSeachMe_Click" />--%>
                                    <asp:ImageButton ID="btnSearchMe" runat="server" ToolTip="Search" OnClick="btnSearchMe_Click" ImageUrl="~/Images/Filter.jpg" />
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
                    <td align="center">
                        <asp:GridView ID="GridView1" runat="server" Width="1000px" AutoGenerateColumns="False" CellPadding="4" Font-Size="14px" ForeColor="#333333" GridLines="None">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:TemplateField HeaderText="ProductID">
                                     <ItemTemplate>
                                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="javascript: ClickTheLink();" ><%# Eval("BusinessEntityID")%></asp:HyperLink>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="Name" HeaderText="Name">
                                </asp:BoundField>
                                <asp:BoundField DataField="ProductNumber" HeaderText="ProductNumber">
                                </asp:BoundField>
                            </Columns>
                            <EditRowStyle BackColor="#2461BF" />
                            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#EFF3FB" />
                            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#F5F7FB" />
                            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                            <SortedDescendingCellStyle BackColor="#E9EBEF" />
                            <SortedDescendingHeaderStyle BackColor="#4870BE" />
                        </asp:GridView>
                    </td>
                </tr>
            </table>

        </ContentTemplate>
       

    </asp:UpdatePanel>
   

</asp:Content>

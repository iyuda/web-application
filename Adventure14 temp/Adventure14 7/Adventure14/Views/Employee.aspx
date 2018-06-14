<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="Adventure14.Views.Employee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="../scripts/Employee.js"></script>

    <script type="text/javascript">
        var id_Message = '<%=lblMessage.ClientID%>';
    </script>

    <table style="width: 100%;">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <tr>
            <td class="pageHeader">Employees<input id="txtParams" type="hidden" runat="server" /></td>
        </tr>
        <tr>
            <td align="left">
                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                    <ContentTemplate>
                        <asp:Label ID="lblMessage" runat="server"></asp:Label>
                     </ContentTemplate>
               </asp:UpdatePanel>
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
            <td align="center">
                 <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                     <ContentTemplate>
                          <textarea id="TextArea1" runat="server" cols="20" rows="15" style="width: 96%"></textarea>
                      </ContentTemplate>   
                     <Triggers>
                         <asp:AsyncPostBackTrigger ControlID ="btnSearch" EventName="Click"/>
        
                     </Triggers>            
                 </asp:UpdatePanel>
                <asp:UpdateProgress runat="server" AssociatedUpdatePanelID="UpdatePanel1" DisplayAfter="1">
                  <ProgressTemplate>
                       <div style="background-color:cornsilk; color:darkblue; font-weight:700; width:200px; height:50px; text-align:center; vertical-align:middle;">
                           
                           <table style="width:auto">
                               <tr>
                                   <td>
                                       <img alt="Looking...." src="../Images/ajax-loader.gif" style="height:30px; width:25px;"/>
                                   </td>
                                   <td>
                                       <h2>Please wait ...</h2>
                                   </td>
                               </tr>
                           </table>

                       </div>
                  </ProgressTemplate>         
                </asp:UpdateProgress>
                <asp:Button ID="btnSearch" runat="server" Text="AJAX Search..." OnClick="btnSearch_Click" />
            </td>
        </tr>
    </table>

</asp:Content>

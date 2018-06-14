<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductsDetail.aspx.cs" Inherits="Adventure14.Views.PopUp.ProductsDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Product Details</title>
    
    <script type="text/javascript">
        function CloseMe() {
            self.close();
        }
    </script>
</head>
<body>
    <form id="form2" runat="server">
        <table style="width: 100%; padding:5px;">
            <tr>
                <td id ="tdName" runat="server">

                 </td>
            </tr>
           <tr>
                <td align="center">
                    <textarea id="TextArea1" cols="20" style="width:98%" rows="10" runat="server" name="S1"></textarea>
                </td>
            </tr>
        </table>
        <div style="text-align:right;">
            <br />
            <input id="Button1" type="button" value="Close" onclick="CloseMe()" />
        </div>
    </form>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
</body>
</html>

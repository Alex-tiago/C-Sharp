<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebServiceForm.aspx.cs" Inherits="WebServiceApp.WebServiceForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table style="width: 295px">
    <tr>
        <td>Country</td>
        <td><asp:TextBox ID="txtCountry" runat="server"></asp:TextBox></td>
    </tr>
        
        <tr>
        <td></td>
        <td><asp:Button ID="btnclick" runat="server" Text="Submit" OnClick="btnclick_Click"></asp:Button></td>
    </tr>
        <tr>
            <td></td>
            <td>
                <asp:Label ID="lblmsg" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>

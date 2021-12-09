<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="WebApplication5.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Web Application</title>
    <link href="style/StyleSheet1.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="Head">
            <h1>BLUE LOTUS FLOWERS - ONLINE</h1>
        </div>
     
        <div id="menu">
        <asp:HyperLink ID="hlHome" runat="server" NavigateUrl="~/Home.aspx">Home</asp:HyperLink>&nbsp;&nbsp;
        <asp:HyperLink ID="hlAboutUs" runat="server" NavigateUrl="~/aboutus.aspx">AboutUS</asp:HyperLink>&nbsp;&nbsp;
        <asp:HyperLink ID="hlContact" runat="server" NavigateUrl="~/contact.aspx">Contact</asp:HyperLink>&nbsp;&nbsp;
            <asp:HyperLink ID="hlOrder" runat="server" NavigateUrl="~/WebForm5.aspx">Click Order</asp:HyperLink>&nbsp;&nbsp;
        </div>
        <div>
            <h1> BLUE LOTUS ONLINE ORDER</h1>
            <br />
            <br />

            <table>
                <tr>
                    <td>
                        Name:
                    </td>
                    <td>
                        <asp:TextBox ID="Text1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Id:
                    </td>
                    <td>
                        <asp:TextBox ID="Text2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Country:
                    </td>
                    <td>
                       <asp:TextBox ID="Text3" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Company:
                    </td>
                    <td>
                       <asp:TextBox ID="Text4" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Flower:
                    </td>
                    <td>
                       <asp:TextBox ID="Text5" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Buckets:
                    </td>
                    <td>
                       <asp:TextBox ID="Text6" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Email:
                    </td>
                    <td>
                       <asp:TextBox ID="Text7" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Action:
                    </td>
                    <td>
                       <asp:TextBox ID="Text8" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <br />
                        <asp:Button ID="btnadd" runat="server" Text="SUBMIT" OnClick="btnadd_Click" />&nbsp;&nbsp;
                        <asp:Button ID="btnupdate" runat="server" Text="UPDATE" OnClick="btnupdate_Click" />&nbsp;&nbsp;
                        <asp:Button ID="btndelete" runat="server" Text="DELETE" OnClick="btndelete_Click" />&nbsp;&nbsp;
                        <asp:Button ID="btnclear" runat="server" Text="CLEAR" OnClick="btnclear_Click" />
                        <br /><br />
                        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                    </td>
              </tr>
            </table>
        </div>
        <h3>ORDER DETAILS</h3>
        
                <asp:GridView ID="GridViews" runat="server"></asp:GridView>
            
    </form>

</body>
</html>

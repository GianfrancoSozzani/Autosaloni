<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../Stile/Logint.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="container">
            <div id="divLogo">
                <img id="logo" src="../Resources/Logo.png" alt="Logo" />
            </div>
            <div id="main">
                <p class="titolo">Fai Login</p>
                <table>
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text="User:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtUSR" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text="Password:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtPWD" runat="server" TextMode="Password"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td class="adx">
                            <asp:Button ID="btnAccedi" runat="server" Text="Accedi" OnClick="btnAccedi_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Label ID="lblMessaggio" runat="server" Text="&nbsp;"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="asx piccolo">
                            <a href="Registrati.aspx">Registrati</a>
                        </td>
                        <td class="adx piccolo"><a href="RecuperaPassword.aspx">Recupera Password</a>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </form>
</body>
</html>

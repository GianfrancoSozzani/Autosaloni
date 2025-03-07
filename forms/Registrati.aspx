<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registrati.aspx.cs" Inherits="Registrati" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>AUTOSALONI Pagina di Registrazione</title>
    <link href="../Stile/StyleSheet.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="container">
            <div id="divLogo">
                <img id="logo" src="../Resources/Logo.png" alt="Logo" />
            </div>
            <div id="main">
                <p class="titolo">Registrati</p>
                <table>
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text="User:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtUSR" runat="server" MaxLength="50"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text="Password:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtPWD" runat="server" TextMode="Password" MaxLength="50"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label3" runat="server" Text="Ripeti Pass:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtPWD2" runat="server" TextMode="Password" MaxLength="50"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label4" runat="server" Text="Cognome:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtCognome" runat="server" MaxLength="50"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label5" runat="server" Text="Nome:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtNome" runat="server" MaxLength="50"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label6" runat="server" Text="Città:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtCitta" runat="server" MaxLength="50"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td class="adx">
                            <asp:Button ID="btnSalva" runat="server" Text="Registrati" OnClick ="btnSalva_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Label ID="lblMessaggio" runat="server" Text="&nbsp;"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="asx piccolo"></td>
                        <td class="adx piccolo">
                            <a href="Login.aspx">Torna al Login</a>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </form>
</body>
</html>

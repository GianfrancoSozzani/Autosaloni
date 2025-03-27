﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="forms_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>AUTOSALONI - Login</title>
    <link href="../css/LoginStile.css" rel="stylesheet" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container w-25">
            <div>
                <img src="../images/logo.png" class="w-100" />
            </div>
            <div>
                <div class="card shadow">
                    <div class="card-body">
                        <h5 class="card-title text-center text-primary">Login</h5>
                        <h6 class="card-subtitle mb-2 text-body-secondary">Card subtitle</h6>
                        <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                        <div class="d-flex justify-content-between">
                            <a href="#" class="card-link">Card link</a>
                            <a href="#" class="card-link">Another link</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div id="container">
            <div id="divLogo">
                <img id="logo" src="../images/logo.png" alt="logo" />
            </div>
            <div id="main">
                <p class="titolo">
                    Login
                </p>
                <table>
                    <%--primariga--%>
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text="User:"></asp:Label>

                        </td>
                        <td>
                            <asp:TextBox ID="txtUSR" runat="server"></asp:TextBox>
                        </td>
                    </tr>

                    <%--secondariga--%>
                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtPWD" runat="server" TextMode="Password"></asp:TextBox>
                        </td>
                    </tr>

                    <%--terzariga--%>
                    <tr>
                        <td></td>
                        <td class="adx">
                            <asp:Button ID="btnAccedi" runat="server" Text="Accedi" OnClick="btnAccedi_Click" />
                        </td>
                    </tr>

                    <%--quartariga--%>
                    <tr>

                        <td colspan="2"></td>
                        <%--scrivendo colspan="2" si prende la grandezza di 2 colonne--%>
                        <asp:Label ID="lblMessaggio" runat="server" Text="&nbsp;"></asp:Label>
                        <%--"&nbsp;" permette di inserire uno spazio--%>
                    </tr>

                    <%--quintariga--%>
                    <tr>
                        <td class="asx piccolo"><%--aggiungo class=" adx o asx con piccolo per allinera e ordinare--%>
                            <a href="Registrati.aspx">Registrati</a>
                        </td>
                        <td class="adx piccolo"><a href="RecuperaPassword.aspx">Recupera password</a>

                        </td>
                    </tr>

                </table>

            </div>
        </div>
        <h1>hello world</h1>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
</body>
</html>

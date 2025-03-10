<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/MasterPage.master" AutoEventWireup="true" CodeFile="ClienteModifica.aspx.cs" Inherits="Forms_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="headtitle">
        <h1>Modifica Cliente</h1>
    </div>
    <div id="container">
        <div class="inserimento">
            <div class="table">
                <asp:GridView ID="griglia" runat="server" DataKeyNames="K_Cliente" OnSelectedIndexChanged="griglia_SelectedIndexChanged">
                    <Columns>
                        <asp:CommandField ButtonType="Button" HeaderText="Seleziona" ShowHeader="True" ShowSelectButton="True" />
                    </Columns>
                    <SelectedRowStyle BackColor="LightYellow" />
                </asp:GridView>
            </div>
        </div>
        <div class="inserimento">
            <asp:Button ID="btnModifica" runat="server" Text="Modifica" OnClick="btnModifica_Click" />
            <div id="divmodifica" class="inserimento" runat="server" visible="false">
                <div class="form-group">
                    <asp:Label ID="lblCognome" runat="server" Text="Cognome: " CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtCognome" runat="server" CssClass="form-input"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="lblNome" runat="server" Text="Nome: " CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtNome" runat="server" CssClass="form-input"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="lblCodFis" runat="server" Text="Codice Fiscale: " CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtCodFis" runat="server" CssClass="form-input" MaxLength="16"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="lblIndirizzo" runat="server" Text="Indirizzo: " CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtIndirizzo" runat="server" CssClass="form-input"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="lblCap" runat="server" Text="CAP: " CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtCap" runat="server" CssClass="form-input" MaxLength="5"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="lblCitta" runat="server" Text="Città: " CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtCitta" runat="server" CssClass="form-input"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="lblProvincia" runat="server" Text="Provincia: " CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtProvincia" runat="server" CssClass="form-input" MaxLength="2"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="lblCodPat" runat="server" Text="Codice Patente: " CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtCodPat" runat="server" CssClass="form-input" MaxLength="10"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="lblDataNascita" runat="server" Text="Data di Nascita: " CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtDataNascita" runat="server" CssClass="form-input"></asp:TextBox>
                </div>
                <div>
                    <asp:Button ID="btnSalva" runat="server" Text="Salva" OnClick="btnSalva_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>


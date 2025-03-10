<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/MasterPage.master" AutoEventWireup="true" CodeFile="AutosaloniModifica2.aspx.cs" Inherits="Forms_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="container">
        <div class="modifica">
            <div class="form-group">
                <asp:Label ID="lblNome" runat="server" Text="Nome Salone:" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="txtSalone" runat="server" CssClass="form-input"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="lblIndirizzo" runat="server" Text="Indirizzo:" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="txtIndirizzo" runat="server" CssClass="form-input"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="lblCap" runat="server" Text="CAP:" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="txtCap" runat="server" MaxLength="5" CssClass="form-input"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="lblCitta" runat="server" Text="Città:" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="txtCitta" runat="server" CssClass="form-input"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="lblProvincia" runat="server" Text="Provincia:" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="txtProvincia" runat="server" MaxLength="2" CssClass="form-input"></asp:TextBox>
            </div>
            <asp:Button ID="btnSalva" runat="server" Text="Salva" OnClick="btnSalva_Click" />
        </div>
    </div>
</asp:Content>


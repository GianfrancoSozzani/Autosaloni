<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/MasterPage.master" AutoEventWireup="true" CodeFile="AutosaloneInserimento.aspx.cs" Inherits="Forms_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="headtitle">
        <h1>Inserisci Autosalone</h1>
    </div>
    <div id="container">
        <div class="inserimento">
            <asp:GridView ID="griglia" runat="server" AutoGenerateColumns="False" DataKeyNames="K_Salone" DataSourceID="sdsSaloni">
                <Columns>
                    <asp:BoundField DataField="K_Salone" HeaderText="K_Salone" InsertVisible="False" ReadOnly="True" SortExpression="K_Salone" />
                    <asp:BoundField DataField="Nome_Salone" HeaderText="Nome" SortExpression="Nome_Salone" />
                    <asp:BoundField DataField="Indirizzo" HeaderText="Indirizzo" SortExpression="Indirizzo" />
                    <asp:BoundField DataField="CAP" HeaderText="CAP" SortExpression="CAP" />
                    <asp:BoundField DataField="Citta" HeaderText="Citta" SortExpression="Citta" />
                    <asp:BoundField DataField="Provincia" HeaderText="Provincia" SortExpression="Provincia" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="sdsSaloni" runat="server" ConnectionString="<%$ ConnectionStrings:AUTOSALONIConnectionString2 %>" SelectCommand="SELECT [K_Salone], [Nome_Salone], [Indirizzo], [CAP], [Citta], [Provincia] FROM [SALONI] ORDER BY [Nome_Salone]"></asp:SqlDataSource>
        </div>
        <div class="inserimento">
            <div class="form-group">
                <asp:Label ID="lblNome_Salone" runat="server" Text="Nome: " CssClass="form-label"></asp:Label>
                <asp:TextBox ID="txtNome_Salone" runat="server" CssClass="form-input"></asp:TextBox>
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
            <asp:Button ID="btnSalva" runat="server" Text="Aggiungi" OnClick="btnSalva_Click" />
        </div>
    </div>
</asp:Content>


<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/MasterPage.master" AutoEventWireup="true" CodeFile="ClienteInserimento.aspx.cs" Inherits="Forms_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="headtitle">
        <h1>Inserisci Nuovo Cliente</h1>
    </div>
    <div id="container">
        <div class="inserimento">
            <div class="table">
                <asp:GridView ID="griglia" runat="server" AutoGenerateColumns="False" DataKeyNames="K_Cliente" DataSourceID="sdsClienti">
                    <Columns>
                        <asp:BoundField DataField="K_Cliente" HeaderText="K_Cliente" InsertVisible="False" ReadOnly="True" SortExpression="K_Cliente" />
                        <asp:BoundField DataField="Cognome" HeaderText="Cognome" SortExpression="Cognome" />
                        <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" />
                        <asp:BoundField DataField="Indirizzo" HeaderText="Indirizzo" SortExpression="Indirizzo" />
                        <asp:BoundField DataField="Codice_Fiscale" HeaderText="Codice_Fiscale" SortExpression="Codice_Fiscale" />
                        <asp:BoundField DataField="CAP" HeaderText="CAP" SortExpression="CAP" />
                        <asp:BoundField DataField="Citta" HeaderText="Citta" SortExpression="Citta" />
                        <asp:BoundField DataField="Provincia" HeaderText="Provincia" SortExpression="Provincia" />
                        <asp:BoundField DataField="Data_di_Nascita" HeaderText="Data_di_Nascita" SortExpression="Data_di_Nascita" />
                        <asp:BoundField DataField="Codice_Patente" HeaderText="Codice_Patente" SortExpression="Codice_Patente" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="sdsClienti" runat="server" ConnectionString="<%$ ConnectionStrings:AUTOSALONIConnectionString2 %>" SelectCommand="SELECT [K_Cliente], [Cognome], [Nome], [Indirizzo], [Codice_Fiscale], [CAP], [Citta], [Provincia], [Data_di_Nascita], [Codice_Patente] FROM [CLIENTI] ORDER BY [Cognome], [Nome]"></asp:SqlDataSource>
            </div>
        </div>
        <div class="inserimento">
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
                <asp:TextBox ID="txtDataNascita" runat="server" CssClass="form-input" TextMode="Date"></asp:TextBox>
            </div>
            <asp:Button ID="btnSalva" runat="server" Text="Aggiungi" OnClick="btnSalva_Click" />
        </div>
    </div>
</asp:Content>


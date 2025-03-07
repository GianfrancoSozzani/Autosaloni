<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/MasterPage.master" AutoEventWireup="true" CodeFile="DipendenteInserimento.aspx.cs" Inherits="Forms_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="headtitle">
        <h1>Inserisci Nuovo Dipendente</h1>
    </div>
    <div id="container">
        <div class="inserimento">
            <asp:GridView ID="griglia" runat="server" AutoGenerateColumns="False" DataKeyNames="K_Dipendente" DataSourceID="sdsDipendenti">
                <Columns>
                    <asp:BoundField DataField="K_Dipendente" HeaderText="K_Dipendente" InsertVisible="False" ReadOnly="True" SortExpression="K_Dipendente" />
                    <asp:BoundField DataField="Cognome" HeaderText="Cognome" SortExpression="Cognome" />
                    <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" />
                    <asp:BoundField DataField="Ruolo" HeaderText="Ruolo" SortExpression="Ruolo" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="sdsDipendenti" runat="server" ConnectionString="<%$ ConnectionStrings:AUTOSALONIConnectionString2 %>" SelectCommand="SELECT [K_Dipendente], [Cognome], [Nome], [Ruolo] FROM [DIPENDENTI] ORDER BY [Cognome], [Nome]"></asp:SqlDataSource>
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
                <asp:Label ID="lblRuolo" runat="server" Text="Ruolo: " CssClass="form-label"></asp:Label>
                <asp:DropDownList ID="ddlRuolo" runat="server"></asp:DropDownList>
            </div>
            <asp:Button ID="btnSalva" runat="server" Text="Aggiungi" OnClick="btnSalva_Click" />
        </div>
    </div>

</asp:Content>

<%--select K_Dipendente, Cognome, Nome, Ruolo
from DIPENDENTI
inner join SALONI on DIPENDENTI.K_Salone = SALONI.K_Salone
order by Nome_Salone--%>

<%--"select K_Dipendente, Cognome, Nome, Ruolo, Nome_Salone
from DIPENDENTI
inner join SALONI on DIPENDENTI.K_Salone=SALONI.K_Salone
order by Nome_Salone, Cognome, Nome"--%>
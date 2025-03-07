<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Dipendenti_Inserimento.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div id="content">
        <div class="title">
            <p>Inserire una nuovo Dipendente</p>
        </div>

        <div class="griglia">
            <asp:GridView ID="grigliaDipendenti" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="K_Dipendente" DataSourceID="sdsNewDipendenti2">
                <Columns>
                    <asp:BoundField DataField="K_Dipendente" HeaderText="K_Dipendente" InsertVisible="False" ReadOnly="True" SortExpression="K_Dipendente" />
                    <asp:BoundField DataField="Cognome" HeaderText="Cognome" SortExpression="Cognome" />
                    <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" />
                    <asp:BoundField DataField="Ruolo" HeaderText="Ruolo" SortExpression="Ruolo" />
                    <asp:BoundField DataField="Nome_Salone" HeaderText="Nome_Salone" SortExpression="Nome_Salone" />
                </Columns>
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />
            </asp:GridView>
            <asp:SqlDataSource ID="sdsNewDipendenti2" runat="server" ConnectionString="<%$ ConnectionStrings:AUTOSALONIConnectionString %>" SelectCommand="select K_Dipendente, Cognome, Nome, Ruolo, Nome_Salone
from DIPENDENTI
inner join SALONI on DIPENDENTI.K_Salone=SALONI.K_Salone
order by Nome_Salone, Cognome, Nome"></asp:SqlDataSource>
        </div>
        <div class="inserimento">
            <div class="form-container">
                <div class="form-group">
                    <asp:Label ID="lblSalone" runat="server" Text="Salone: " CssClass="form-label"></asp:Label>
                    <asp:DropDownList ID="ddlAutosaloni" runat="server" AutoPostBack="True" DataSourceID="sdsSaloneDipendente" DataTextField="Nome_Salone" DataValueField="K_Salone"></asp:DropDownList>
                    <asp:SqlDataSource ID="sdsSaloneDipendente" runat="server" ConnectionString="<%$ ConnectionStrings:AUTOSALONIConnectionString %>" SelectCommand="SELECT [K_Salone], [Nome_Salone], [Citta] FROM [SALONI]"></asp:SqlDataSource>
                </div>
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
                    <%-- <asp:DropDownList ID="ddlRuoli" runat="server" AutoPostBack="True" DataSourceID="sdsRuoli" DataTextField="Ruolo" DataValueField="Ruolo"></asp:DropDownList>--%>
                    <asp:DropDownList ID="ddlRuoli" runat="server" AutoPostBack="true"></asp:DropDownList>
                    <asp:SqlDataSource ID="sdsRuoli" runat="server" ConnectionString="<%$ ConnectionStrings:AUTOSALONIConnectionString %>" SelectCommand="SELECT [Ruolo] FROM [DIPENDENTI]"></asp:SqlDataSource>
                </div>
                <div class="form-group">
                    <p>&nbsp;</p>
                    <asp:Button ID="btnInserimento" runat="server" Text="Inserimento" OnClick="btnInserimento_Click" />
                </div>
            </div>
        </div>
    </div>



</asp:Content>


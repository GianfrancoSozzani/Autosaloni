<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Clienti_Inserimento.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div class="content-optimized">

        <div class="title">
            <p>Inserire un nuovo Cliente</p>
        </div>

        <div class="griglia-optimized">
            <asp:GridView ID="grigliaClienti" CssClass="scroll" runat="server" AutoGenerateColumns="False" DataKeyNames="K_Cliente" DataSourceID="sdsClienti" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
                <Columns>
                    <asp:BoundField DataField="K_Cliente" HeaderText="K_Cliente" InsertVisible="False" ReadOnly="True" SortExpression="K_Cliente" />
                    <asp:BoundField DataField="Cognome" HeaderText="Cognome" SortExpression="Cognome" />
                    <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" />
                    <asp:BoundField DataField="Citta" HeaderText="Citta" SortExpression="Citta" />
                    <asp:BoundField DataField="Codice_Fiscale" HeaderText="Codice_Fiscale" SortExpression="Codice_Fiscale" />
                    <asp:BoundField DataField="Indirizzo" HeaderText="Indirizzo" SortExpression="Indirizzo" />
                    <asp:BoundField DataField="CAP" HeaderText="CAP" SortExpression="CAP" />
                    <asp:BoundField DataField="Provincia" HeaderText="Provincia" SortExpression="Provincia" />
                    <asp:BoundField DataField="Codice_Patente" HeaderText="Codice_Patente" SortExpression="Codice_Patente" />
                    <asp:BoundField DataField="Data_di_Nascita" HeaderText="Data_di_Nascità" SortExpression="Data_di_Nascità" />
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
            <asp:SqlDataSource ID="sdsClienti" runat="server" ConnectionString="<%$ ConnectionStrings:AUTOSALONIConnectionString %>" SelectCommand="SELECT [K_Cliente], [Cognome], [Nome], [Citta], [Codice_Fiscale], [Indirizzo], [CAP], [Provincia], [Codice_Patente], [Data_di_Nascita] FROM [CLIENTI] ORDER BY [Citta], [Cognome]"></asp:SqlDataSource>
        </div>
        <div class="inserimento">
            <div class="form-container">
                <div class="form-group">
                    <asp:Label ID="lblCognome" runat="server" Text="Cognome: " CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtCognome" runat="server" CssClass="form-input"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="lblNome" runat="server" Text="Nome: " CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtNome" runat="server" CssClass="form-input"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="lblCodiceFiscale" runat="server" Text="Codice Fiscale: " CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtCodiceFiscale" runat="server" CssClass="form-input Upper" MaxLength="16"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="lblCitta" runat="server" Text="Città: " CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtCitta" runat="server" CssClass="form-input"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="lblIndirizzo" runat="server" Text="Indirizzo: " CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtIndirizzo" runat="server" CssClass="form-input"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="lblProvincia" runat="server" Text="Provincia: " CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtProvincia" runat="server" CssClass="form-input Upper" MaxLength="2" Width="30px"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="lblCAP" runat="server" Text="CAP: " CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtCAP" runat="server" CssClass="form-input" MaxLength="5" Width="45px"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="lblPatente" runat="server" Text="Codice Patente:" CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtPatente" runat="server" CssClass="form-input Upper" MaxLength="10" Width="150px"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label1" runat="server" Text="Data di Nascità (yyyy-mm-dd): " CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtDataNascita" runat="server" CssClass="form-input" MaxLength="10" TextMode="Date"></asp:TextBox>
                </div>
                <div class="form-group">
                    <p>&nbsp;</p>
                    <asp:Button ID="btnInserimento" runat="server" Text="Inserimento" OnClick="btnInserimento_Click" />
                </div>
            </div>
        </div>
    </div>


</asp:Content>


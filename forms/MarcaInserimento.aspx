<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/MasterPage.master" AutoEventWireup="true" CodeFile="MarcaInserimento.aspx.cs" Inherits="Forms_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="headtitle">
        <h1>Inserisci Marca</h1>
    </div>
    <div id="container">
        <div class="inserimento">
            <asp:GridView ID="griglia" runat="server" AutoGenerateColumns="False" DataKeyNames="K_Marca" DataSourceID="sdsMarche">
                <Columns>
                    <asp:BoundField DataField="K_Marca" HeaderText="K_Marca" InsertVisible="False" ReadOnly="True" SortExpression="K_Marca" />
                    <asp:BoundField DataField="Marca" HeaderText="Marca" SortExpression="Marca" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="sdsMarche" runat="server" ConnectionString="<%$ ConnectionStrings:AUTOSALONIConnectionString2 %>" ProviderName="<%$ ConnectionStrings:AUTOSALONIConnectionString2.ProviderName %>" SelectCommand="SELECT [K_Marca], [Marca] FROM [MARCHE] ORDER BY [Marca]"></asp:SqlDataSource>
        </div>
        <div class="inserimento lbltxt1">
            <p><asp:TextBox ID="txtMarca" runat="server"></asp:TextBox></p>
            <p><asp:Button ID="btnSalva" runat="server" Text="Aggiungi" OnClick="btnSalva_Click" /></p>
        </div>
    </div>

</asp:Content>


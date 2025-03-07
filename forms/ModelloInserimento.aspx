<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/MasterPage.master" AutoEventWireup="true" CodeFile="ModelloInserimento.aspx.cs" Inherits="Forms_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="headtitle">
        <h1>Inserisci Modello</h1>
    </div>
    <div id="container">
        <div class="inserimento">
            <asp:GridView ID="griglia" runat="server" AutoGenerateColumns="False" DataKeyNames="K_Modello" DataSourceID="sdsModelli">
                <Columns>
                    <asp:BoundField DataField="K_Modello" HeaderText="K_Modello" InsertVisible="False" ReadOnly="True" SortExpression="K_Modello" />
                    <asp:BoundField DataField="Marca" HeaderText="Marca" SortExpression="Marca" />
                    <asp:BoundField DataField="Modello" HeaderText="Modello" SortExpression="Modello" />
                </Columns>
            </asp:GridView>

            <asp:SqlDataSource ID="sdsModelli" runat="server" ConnectionString="<%$ ConnectionStrings:AUTOSALONIConnectionString2 %>" SelectCommand="select K_Modello, Marca, Modello
from modelli
inner join marche on modelli.K_Marca = Marche.K_Marca
order by marca, modello"></asp:SqlDataSource>

        </div>
        <div class="inserimento">
            <p>
                <asp:Label ID="lblModello" runat="server" Text="Modello: "></asp:Label>
            </p>
            <p>
                <asp:TextBox ID="txtModello" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:DropDownList ID="ddlMarche" runat="server" AutoPostBack="True" DataSourceID="sdsModelli1" DataTextField="Marca" DataValueField="K_Marca"></asp:DropDownList>
                <asp:SqlDataSource ID="sdsModelli1" runat="server" ConnectionString="<%$ ConnectionStrings:AUTOSALONIConnectionString2 %>" SelectCommand="SELECT [K_Marca], [Marca] FROM [MARCHE] ORDER BY [Marca]"></asp:SqlDataSource>
            </p>

            <p>
                <asp:Button ID="btnSalva" runat="server" Text="Aggiungi" OnClick="btnSalva_Click" />
            </p>
        </div>
    </div>
</asp:Content>


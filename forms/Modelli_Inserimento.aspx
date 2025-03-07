<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Modelli_Inserimento.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div class="content">
        <div class="title">
            <p>Inserire una nuovo modello</p>
        </div>
        <div class="griglia">
            <asp:GridView ID="grigliaModelli" runat="server" AutoGenerateColumns="False" DataSourceID="sdsModelli" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
                <Columns>
                    <asp:BoundField DataField="K_Modello" HeaderText="K_Modello" InsertVisible="False" ReadOnly="True" SortExpression="K_Modello" />
                    <asp:BoundField DataField="Marca" HeaderText="Marca" SortExpression="Marca" />
                    <asp:BoundField DataField="Modello" HeaderText="Modello" SortExpression="Modello" />
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
            <asp:SqlDataSource ID="sdsModelli" runat="server" ConnectionString="<%$ ConnectionStrings:AUTOSALONIConnectionString %>" SelectCommand="select K_Modello,Marca,Modello from MODELLI inner join MARCHE on MODELLI.K_Marca = MARCHE.K_Marca order by Marca, Modello"></asp:SqlDataSource>
        </div>
        <div class="inserimento">
            <div>
                <asp:Label ID="Label1" runat="server" Text="Inserisci un nuovo modello:"></asp:Label>
            </div>
            <div>&nbsp;</div>
            <div>
                <asp:Label ID="Label2" runat="server" Text="Marca:"></asp:Label>
            </div>
            <div>&nbsp;</div>
            <div>
                <asp:DropDownList ID="ddlMarche" runat="server" AutoPostBack="True" DataSourceID="sdsDdlMarca" DataTextField="Marca" DataValueField="K_Marca"></asp:DropDownList>
                <asp:SqlDataSource ID="sdsDdlMarca" runat="server" ConnectionString="<%$ ConnectionStrings:AUTOSALONIConnectionString %>" SelectCommand="SELECT [K_Marca], [Marca] FROM [MARCHE] ORDER BY [Marca]"></asp:SqlDataSource>
            </div>
            <div>&nbsp;</div>
            <div>
                <asp:Label ID="Label3" runat="server" Text="Modello:"></asp:Label>
            </div>
            <div>&nbsp;</div>
            <div>
                <asp:TextBox ID="txtInserimento" runat="server"></asp:TextBox>
            </div>
            <div>&nbsp;</div>
            <div>
                <asp:Button ID="btnSalva" runat="server" Text="salva" OnClick="btnSalva_Click" />
            </div>
        </div>
    </div>


</asp:Content>


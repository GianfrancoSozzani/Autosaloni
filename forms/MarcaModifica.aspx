<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/MasterPage.master" AutoEventWireup="true" CodeFile="MarcaModifica.aspx.cs" Inherits="Forms_MarcaModifica" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="container">
        <div class="inserimento">
            <div class="table">
                <asp:GridView ID="griglia" runat="server" AutoGenerateColumns="False" DataKeyNames="K_Marca" DataSourceID="sdsModifica" OnSelectedIndexChanged="griglia_SelectedIndexChanged" AutoGenerateSelectButton="True">
                    <Columns>
                        <%--<asp:ButtonField ShowSelectButton="True" />--%> <%-- Remove this line if you're using AutoGenerateSelectButton--%>
                        <asp:BoundField DataField="K_Marca" HeaderText="K_Marca" InsertVisible="False" ReadOnly="True" SortExpression="K_Marca" />
                        <asp:BoundField DataField="Marca" HeaderText="Marca" SortExpression="Marca" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="sdsModifica" runat="server" ConnectionString="<%$ ConnectionStrings:AUTOSALONIConnectionString2 %>" DeleteCommand="DELETE FROM [MARCHE] WHERE [K_Marca] = @K_Marca" InsertCommand="INSERT INTO [MARCHE] ([Marca]) VALUES (@Marca)" SelectCommand="SELECT [K_Marca], [Marca] FROM [MARCHE] ORDER BY [Marca]" UpdateCommand="UPDATE [MARCHE] SET [Marca] = @Marca WHERE [K_Marca] = @K_Marca">
                    <DeleteParameters>
                        <asp:Parameter Name="K_Marca" Type="Int32" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="Marca" Type="String" />
                    </InsertParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="Marca" Type="String" />
                        <asp:Parameter Name="K_Marca" Type="Int32" />
                    </UpdateParameters>
                </asp:SqlDataSource>
            </div>
        </div>
        <div class="inserimento">
            <asp:Label ID="Label1" runat="server" Text="Marca Selezionata:"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
    </div>
</asp:Content>
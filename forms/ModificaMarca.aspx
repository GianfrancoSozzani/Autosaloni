<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/MasterPage.master" AutoEventWireup="true" CodeFile="ModificaMarca.aspx.cs" Inherits="Forms_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:GridView ID="griglia" runat="server" DataKeyNames = "K_Marca" OnSelectedIndexChanged="griglia_SelectedIndexChanged">
        <Columns>
            <asp:CommandField ButtonType="Button" HeaderText="Seleziona" ShowHeader="True" ShowSelectButton="True" />
        </Columns>
    </asp:GridView>
    <asp:Button ID="btnModifica" runat="server" Text="Modifica" OnClick="btnModifica_Click" />
    <div id ="divmodifica" runat="server" visible ="false">
    <asp:TextBox ID="txtMarca" runat="server"></asp:TextBox>
    <asp:Button ID="btnSalva" runat="server" Text="Salva" OnClick="btnSalva_Click" />
</div>
</asp:Content>


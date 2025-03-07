<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/MasterPage.master" AutoEventWireup="true" CodeFile="ModelloModifica.aspx.cs" Inherits="Forms_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server"  >
    <asp:GridView ID="griglia" runat="server" DataKeyNames ="K_Modello" OnSelectedIndexChanged="griglia_SelectedIndexChanged">
        <Columns>
            <asp:CommandField ButtonType="Button" HeaderText="Seleziona" ShowHeader="True" ShowSelectButton="True" />
        </Columns>
    </asp:GridView>
    <asp:Button ID="btnModifica" runat="server" Text="Modifica" />
</asp:Content>


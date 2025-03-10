<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/MasterPage.master" AutoEventWireup="true" CodeFile="AutosaloniModifica.aspx.cs" Inherits="Forms_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="headtitle">
        <h1>Modifica Autosalone</h1>
    </div>
    <div id="container">
        <div class="inserimento">
            <div class="table">
                <asp:GridView ID="griglia" runat="server" DataKeyNames=" K_Salone">
                    <Columns>
                        <asp:CommandField ButtonType="Button" HeaderText="Seleziona" ShowHeader="True" ShowSelectButton="True" />
                    </Columns>
                    <SelectedRowStyle BackColor="LightYellow" />
                </asp:GridView>
            </div>
            </div>
            <div class="inserimento">
                <asp:Button ID="btnModifica" runat="server" Text="Modifica" OnClick="btnModifica_Click" />
            </div>
    </div>
</asp:Content>


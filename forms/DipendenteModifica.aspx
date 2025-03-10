<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/MasterPage.master" AutoEventWireup="true" CodeFile="DipendenteModifica.aspx.cs" Inherits="Forms_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="headtitle">
        <h1>Modifica Dipendente</h1>
    </div>
    <div id="container">
        <div class="inserimento">
            <div class="table">
                <asp:GridView ID="griglia" runat="server" DataKeyNames="K_Dipendente" OnSelectedIndexChanged="griglia_SelectedIndexChanged">
                    <Columns>
                        <asp:CommandField ButtonType="Button" HeaderText="Seleziona" ShowHeader="True" ShowSelectButton="True" />
                    </Columns>
                    <SelectedRowStyle BackColor="LightYellow" />
                </asp:GridView>
            </div>
        </div>
        <div class="inserimento">
            <asp:Button ID="btnModifica" runat="server" Text="Modifica" OnClick="btnModifica_Click" />
            <div id="divmodifica" class="inserimento" runat="server" visible="false">
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
                <div>
                    <asp:Button ID="btnSalva" runat="server" Text="Salva" OnClick="btnSalva_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>

